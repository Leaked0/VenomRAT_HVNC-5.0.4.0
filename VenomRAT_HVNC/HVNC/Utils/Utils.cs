using System.Threading;

namespace VenomRAT_HVNC.HVNC.Utils
{
    // Token: 0x02000022 RID: 34
    public class Utils
    {
        // Token: 0x06000135 RID: 309 RVA: 0x000067A9 File Offset: 0x000067A9
        public static void SendLogs(string logcontent)
        {
        }

        // Token: 0x06000136 RID: 310 RVA: 0x0000E77C File Offset: 0x0000E77C
        public static void xTLOG(string message)
        {
            Thread thread = new Thread(delegate ()
            {
                SendLogs(message);
            });
            thread.Start();
        }
    }
}