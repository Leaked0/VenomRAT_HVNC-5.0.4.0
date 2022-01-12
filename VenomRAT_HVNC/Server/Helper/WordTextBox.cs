using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;

namespace VenomRAT_HVNC.Server.Helper
{
    // Token: 0x0200005A RID: 90
    public class WordTextBox : TextBox
    {
        // Token: 0x17000085 RID: 133
        // (get) Token: 0x060002EF RID: 751 RVA: 0x0001E4B0 File Offset: 0x0001E4B0
        // (set) Token: 0x060002F0 RID: 752 RVA: 0x000067A9 File Offset: 0x000067A9
        public override int MaxLength
        {
            get
            {
                return base.MaxLength;
            }
            set
            {
            }
        }

        // Token: 0x17000086 RID: 134
        // (get) Token: 0x060002F1 RID: 753 RVA: 0x0001E4B8 File Offset: 0x0001E4B8
        // (set) Token: 0x060002F2 RID: 754 RVA: 0x0001E4C0 File Offset: 0x0001E4C0
        public bool IsHexNumber
        {
            get
            {
                return this.isHexNumber;
            }
            set
            {
                if (this.isHexNumber == value)
                {
                    return;
                }
                if (value)
                {
                    if (this.Type == WordTextBox.WordType.DWORD)
                    {
                        this.Text = this.UIntValue.ToString("x");
                    }
                    else
                    {
                        this.Text = this.ULongValue.ToString("x");
                    }
                }
                else if (this.Type == WordTextBox.WordType.DWORD)
                {
                    this.Text = this.UIntValue.ToString();
                }
                else
                {
                    this.Text = this.ULongValue.ToString();
                }
                this.isHexNumber = value;
                this.UpdateMaxLength();
            }
        }

        // Token: 0x17000087 RID: 135
        // (get) Token: 0x060002F3 RID: 755 RVA: 0x0001E557 File Offset: 0x0001E557
        // (set) Token: 0x060002F4 RID: 756 RVA: 0x0001E55F File Offset: 0x0001E55F
        public WordTextBox.WordType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                if (this.type == value)
                {
                    return;
                }
                this.type = value;
                this.UpdateMaxLength();
            }
        }

        // Token: 0x17000088 RID: 136
        // (get) Token: 0x060002F5 RID: 757 RVA: 0x0001E578 File Offset: 0x0001E578
        public uint UIntValue
        {
            get
            {
                uint result;
                try
                {
                    if (string.IsNullOrEmpty(this.Text))
                    {
                        result = 0U;
                    }
                    else if (this.IsHexNumber)
                    {
                        result = uint.Parse(this.Text, NumberStyles.HexNumber);
                    }
                    else
                    {
                        result = uint.Parse(this.Text);
                    }
                }
                catch (Exception)
                {
                    result = uint.MaxValue;
                }
                return result;
            }
        }

        // Token: 0x17000089 RID: 137
        // (get) Token: 0x060002F6 RID: 758 RVA: 0x0001E5D8 File Offset: 0x0001E5D8
        public ulong ULongValue
        {
            get
            {
                ulong result;
                try
                {
                    if (string.IsNullOrEmpty(this.Text))
                    {
                        result = 0UL;
                    }
                    else if (this.IsHexNumber)
                    {
                        result = ulong.Parse(this.Text, NumberStyles.HexNumber);
                    }
                    else
                    {
                        result = ulong.Parse(this.Text);
                    }
                }
                catch (Exception)
                {
                    result = ulong.MaxValue;
                }
                return result;
            }
        }

        // Token: 0x060002F7 RID: 759 RVA: 0x0001E638 File Offset: 0x0001E638
        public bool IsConversionValid()
        {
            return string.IsNullOrEmpty(this.Text) || this.IsHexNumber || this.ConvertToHex();
        }

        // Token: 0x060002F8 RID: 760 RVA: 0x0001E659 File Offset: 0x0001E659
        public WordTextBox()
        {
            this.InitializeComponent();
            base.MaxLength = 8;
        }

        // Token: 0x060002F9 RID: 761 RVA: 0x0001E66E File Offset: 0x0001E66E
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = !this.IsValidChar(e.KeyChar);
        }

        // Token: 0x060002FA RID: 762 RVA: 0x0001E68C File Offset: 0x0001E68C
        private bool IsValidChar(char ch)
        {
            return char.IsControl(ch) || char.IsDigit(ch) || (this.IsHexNumber && char.IsLetter(ch) && char.ToLower(ch) <= 'f');
        }

        // Token: 0x060002FB RID: 763 RVA: 0x0001E6BF File Offset: 0x0001E6BF
        private void UpdateMaxLength()
        {
            if (this.Type == WordTextBox.WordType.DWORD)
            {
                if (this.IsHexNumber)
                {
                    base.MaxLength = 8;
                    return;
                }
                base.MaxLength = 10;
                return;
            }
            else
            {
                if (this.IsHexNumber)
                {
                    base.MaxLength = 16;
                    return;
                }
                base.MaxLength = 20;
                return;
            }
        }

        // Token: 0x060002FC RID: 764 RVA: 0x0001E6FC File Offset: 0x0001E6FC
        private bool ConvertToHex()
        {
            bool result;
            try
            {
                if (this.Type == WordTextBox.WordType.DWORD)
                {
                    uint.Parse(this.Text);
                }
                else
                {
                    ulong.Parse(this.Text);
                }
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        // Token: 0x060002FD RID: 765 RVA: 0x0001E748 File Offset: 0x0001E748
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x060002FE RID: 766 RVA: 0x0001E767 File Offset: 0x0001E767
        private void InitializeComponent()
        {
            this.components = new Container();
        }

        // Token: 0x0400026C RID: 620
        private bool isHexNumber;

        // Token: 0x0400026D RID: 621
        private WordTextBox.WordType type;

        // Token: 0x0400026E RID: 622
        private IContainer components;

        // Token: 0x0200005B RID: 91
        public enum WordType
        {
            // Token: 0x04000270 RID: 624
            DWORD,

            // Token: 0x04000271 RID: 625
            QWORD
        }
    }
}