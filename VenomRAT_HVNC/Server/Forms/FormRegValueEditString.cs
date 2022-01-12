using System;
using System.Windows.Forms;
using VenomRAT_HVNC.Server.Helper;

namespace VenomRAT_HVNC.Server.Forms
{
    // Token: 0x02000076 RID: 118
    public partial class FormRegValueEditString : Form
    {
        // Token: 0x06000453 RID: 1107 RVA: 0x00029700 File Offset: 0x00029700
        public FormRegValueEditString(RegistrySeeker.RegValueData value)
        {
            this._value = value;
            this.InitializeComponent();
            this.valueNameTxtBox.Text = RegValueHelper.GetName(value.Name);
            this.valueDataTxtBox.Text = global::VenomRAT_HVNC.Server.Helper.ByteConverter.ToString(value.Data);
        }

        // Token: 0x06000454 RID: 1108 RVA: 0x0002974C File Offset: 0x0002974C
        private void okButton_Click(object sender, EventArgs e)
        {
            this._value.Data = global::VenomRAT_HVNC.Server.Helper.ByteConverter.GetBytes(this.valueDataTxtBox.Text);
            base.Tag = this._value;
            base.DialogResult = DialogResult.OK;
            base.Close();
        }

        // Token: 0x0400035B RID: 859
        private readonly RegistrySeeker.RegValueData _value;
    }
}