using Server;
using VenomRAT_HVNC.Server;

namespace VenomRAT_HVNC.Quasar.Server.Forms
{
    // Token: 0x02000026 RID: 38
    internal class ReverseProxyHandler
    {
        // Token: 0x0600013C RID: 316 RVA: 0x0000E7C3 File Offset: 0x0000E7C3
        public ReverseProxyHandler(Client[] clients)
        {
            this.clients = clients;
        }

        // Token: 0x040000DC RID: 220
        private Client[] clients;
    }
}