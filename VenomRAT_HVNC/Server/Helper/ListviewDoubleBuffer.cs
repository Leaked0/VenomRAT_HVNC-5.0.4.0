using System.Reflection;
using System.Windows.Forms;

namespace VenomRAT_HVNC.Server.Helper
{
    // Token: 0x0200004F RID: 79
    public static class ListviewDoubleBuffer
    {
        // Token: 0x060002C1 RID: 705 RVA: 0x0001DC58 File Offset: 0x0001DC58
        public static void Enable(ListView listView)
        {
            PropertyInfo property = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            property.SetValue(listView, true, null);
        }
    }
}