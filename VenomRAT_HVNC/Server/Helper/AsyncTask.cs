using System.Collections.Generic;

namespace VenomRAT_HVNC.Server.Helper
{
    // Token: 0x02000043 RID: 67
    public class AsyncTask
    {
        // Token: 0x0600029A RID: 666 RVA: 0x0001D355 File Offset: 0x0001D355
        public AsyncTask(byte[] _msgPack, string _id, bool _admin)
        {
            this.msgPack = _msgPack;
            this.id = _id;
            this.admin = _admin;
            this.doneClient = new List<string>();
        }

        // Token: 0x0400021F RID: 543
        public byte[] msgPack;

        // Token: 0x04000220 RID: 544
        public string id;

        // Token: 0x04000221 RID: 545
        public bool admin;

        // Token: 0x04000222 RID: 546
        public List<string> doneClient;
    }
}