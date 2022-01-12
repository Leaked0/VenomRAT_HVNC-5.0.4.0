using System;
using System.Windows.Forms;

namespace VenomRAT_HVNC.Server.Helper
{
    // Token: 0x02000050 RID: 80
    internal class AeroListView : ListView
    {
        // Token: 0x060002C2 RID: 706 RVA: 0x0001DC8A File Offset: 0x0001DC8A
        public static int MakeWin32Long(short wLow, short wHigh)
        {
            return ((int)wLow << 16) | (int)wHigh;
        }

        // Token: 0x1700007F RID: 127
        // (get) Token: 0x060002C3 RID: 707 RVA: 0x0001DC92 File Offset: 0x0001DC92
        // (set) Token: 0x060002C4 RID: 708 RVA: 0x0001DC9A File Offset: 0x0001DC9A
        private ListViewColumnSorter LvwColumnSorter { get; set; }

        // Token: 0x060002C5 RID: 709 RVA: 0x0001DCA4 File Offset: 0x0001DCA4
        public AeroListView()
        {
            base.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.LvwColumnSorter = new ListViewColumnSorter();
            base.ListViewItemSorter = this.LvwColumnSorter;
            base.View = View.Details;
            base.FullRowSelect = true;
        }

        // Token: 0x060002C6 RID: 710 RVA: 0x0001DCFC File Offset: 0x0001DCFC
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version.Major >= 6)
            {
                NativeMethods.SetWindowTheme(base.Handle, "explorer", null);
            }
            if (Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version.Major >= 5)
            {
                NativeMethods.SendMessage(base.Handle, 295U, this._removeDots, IntPtr.Zero);
            }
        }

        // Token: 0x060002C7 RID: 711 RVA: 0x0001DD7C File Offset: 0x0001DD7C
        protected override void OnColumnClick(ColumnClickEventArgs e)
        {
            base.OnColumnClick(e);
            if (e.Column == this.LvwColumnSorter.SortColumn)
            {
                this.LvwColumnSorter.Order = ((this.LvwColumnSorter.Order == SortOrder.Ascending) ? SortOrder.Descending : SortOrder.Ascending);
            }
            else
            {
                this.LvwColumnSorter.SortColumn = e.Column;
                this.LvwColumnSorter.Order = SortOrder.Ascending;
            }
            if (!base.VirtualMode)
            {
                base.Sort();
            }
        }

        // Token: 0x04000248 RID: 584
        private const uint WM_CHANGEUISTATE = 295U;

        // Token: 0x04000249 RID: 585
        private const short UIS_SET = 1;

        // Token: 0x0400024A RID: 586
        private const short UISF_HIDEFOCUS = 1;

        // Token: 0x0400024B RID: 587
        private readonly IntPtr _removeDots = new IntPtr(AeroListView.MakeWin32Long(1, 1));
    }
}