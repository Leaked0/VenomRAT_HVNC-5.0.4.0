using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using VenomRAT_HVNC.Server.Connection;

namespace VenomRAT_HVNC.Server
{
    // Token: 0x02000035 RID: 53
    public static class Settings
    {
        // Token: 0x17000034 RID: 52
        // (get) Token: 0x060001D3 RID: 467 RVA: 0x0001A872 File Offset: 0x0001A872
        // (set) Token: 0x060001D4 RID: 468 RVA: 0x0001A879 File Offset: 0x0001A879
        public static long SentValue { get; set; }

        // Token: 0x17000035 RID: 53
        // (get) Token: 0x060001D5 RID: 469 RVA: 0x0001A881 File Offset: 0x0001A881
        // (set) Token: 0x060001D6 RID: 470 RVA: 0x0001A888 File Offset: 0x0001A888
        public static long ReceivedValue { get; set; }

        // Token: 0x040001D8 RID: 472
        public static List<string> Blocked = new List<string>();

        // Token: 0x040001D9 RID: 473
        public static object LockBlocked = new object();

        // Token: 0x040001DC RID: 476
        public static object LockReceivedSendValue = new object();

        // Token: 0x040001DD RID: 477
        public static string CertificatePath = Application.StartupPath + "\\ServerCertificate.p12";

        // Token: 0x040001DE RID: 478
        public static X509Certificate2 ServerCertificate;

        // Token: 0x040001DF RID: 479
        public static readonly string Version = "VenomRAT_HVNC  5.0.4";

        // Token: 0x040001E0 RID: 480
        public static object LockListviewClients = new object();

        // Token: 0x040001E1 RID: 481
        public static object LockListviewLogs = new object();

        // Token: 0x040001E2 RID: 482
        public static object LockListviewThumb = new object();

        // Token: 0x040001E3 RID: 483
        public static bool ReportWindow = false;

        // Token: 0x040001E4 RID: 484
        public static List<Clients> ReportWindowClients = new List<Clients>();

        // Token: 0x040001E5 RID: 485
        public static object LockReportWindowClients = new object();
    }
}