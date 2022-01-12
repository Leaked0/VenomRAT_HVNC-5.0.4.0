using System.Collections;
using System.Windows.Forms;

namespace VenomRAT_HVNC.Server.Helper
{
    // Token: 0x0200004E RID: 78
    public class ListViewColumnSorter : IComparer
    {
        // Token: 0x060002BB RID: 699 RVA: 0x0001DBA6 File Offset: 0x0001DBA6
        public ListViewColumnSorter()
        {
            this.ColumnToSort = 0;
            this.OrderOfSort = SortOrder.None;
            this.ObjectCompare = new CaseInsensitiveComparer();
        }

        // Token: 0x060002BC RID: 700 RVA: 0x0001DBC8 File Offset: 0x0001DBC8
        public int Compare(object x, object y)
        {
            ListViewItem listViewItem = (ListViewItem)x;
            ListViewItem listViewItem2 = (ListViewItem)y;
            int num = this.ObjectCompare.Compare(listViewItem.SubItems[this.ColumnToSort].Text, listViewItem2.SubItems[this.ColumnToSort].Text);
            if (this.OrderOfSort == SortOrder.Ascending)
            {
                return num;
            }
            if (this.OrderOfSort == SortOrder.Descending)
            {
                return -num;
            }
            return 0;
        }

        // Token: 0x1700007D RID: 125
        // (get) Token: 0x060002BE RID: 702 RVA: 0x0001DC3C File Offset: 0x0001DC3C
        // (set) Token: 0x060002BD RID: 701 RVA: 0x0001DC33 File Offset: 0x0001DC33
        public int SortColumn
        {
            get
            {
                return this.ColumnToSort;
            }
            set
            {
                this.ColumnToSort = value;
            }
        }

        // Token: 0x1700007E RID: 126
        // (get) Token: 0x060002C0 RID: 704 RVA: 0x0001DC4D File Offset: 0x0001DC4D
        // (set) Token: 0x060002BF RID: 703 RVA: 0x0001DC44 File Offset: 0x0001DC44
        public SortOrder Order
        {
            get
            {
                return this.OrderOfSort;
            }
            set
            {
                this.OrderOfSort = value;
            }
        }

        // Token: 0x04000245 RID: 581
        private int ColumnToSort;

        // Token: 0x04000246 RID: 582
        private SortOrder OrderOfSort;

        // Token: 0x04000247 RID: 583
        private CaseInsensitiveComparer ObjectCompare;
    }
}