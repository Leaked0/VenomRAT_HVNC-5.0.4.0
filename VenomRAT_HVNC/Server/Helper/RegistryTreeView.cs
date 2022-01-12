using System.Windows.Forms;

namespace VenomRAT_HVNC.Server.Helper
{
    // Token: 0x02000058 RID: 88
    public class RegistryTreeView : TreeView
    {
        // Token: 0x060002E2 RID: 738 RVA: 0x0001E30D File Offset: 0x0001E30D
        public RegistryTreeView()
        {
            base.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }
    }
}