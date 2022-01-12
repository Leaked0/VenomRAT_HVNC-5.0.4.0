using System;
using System.Windows.Forms;
using VenomRAT_HVNC.Server.Helper;

namespace VenomRAT_HVNC.Server.Forms
{
    // Token: 0x02000075 RID: 117
    public partial class FormRegValueEditMultiString : Form
    {
        // Token: 0x0600044F RID: 1103 RVA: 0x00028B34 File Offset: 0x00028B34
        public FormRegValueEditMultiString(RegistrySeeker.RegValueData value)
        {
            this._value = value;
            this.InitializeComponent();
            this.valueNameTxtBox.Text = value.Name;
            this.valueDataTxtBox.Text = string.Join("\r\n", global::VenomRAT_HVNC.Server.Helper.ByteConverter.ToStringArray(value.Data));
        }

        // Token: 0x06000450 RID: 1104 RVA: 0x00028B88 File Offset: 0x00028B88
        private void okButton_Click(object sender, EventArgs e)
        {
            this._value.Data = global::VenomRAT_HVNC.Server.Helper.ByteConverter.GetBytes(this.valueDataTxtBox.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries));
            base.Tag = this._value;
            base.DialogResult = DialogResult.OK;
            base.Close();
        }

        // Token: 0x0400034C RID: 844
        private readonly RegistrySeeker.RegValueData _value;
    }
}