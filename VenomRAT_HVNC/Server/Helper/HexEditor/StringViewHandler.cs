using System;
using System.Drawing;
using System.Windows.Forms;

namespace VenomRAT_HVNC.Server.Helper.HexEditor
{
    // Token: 0x0200006F RID: 111
    public class StringViewHandler
    {
        // Token: 0x170000C0 RID: 192
        // (get) Token: 0x06000405 RID: 1029 RVA: 0x0002288F File Offset: 0x0002288F
        public int MaxWidth
        {
            get
            {
                return this._recStringView.X + this._recStringView.Width;
            }
        }

        // Token: 0x06000406 RID: 1030 RVA: 0x000228A8 File Offset: 0x000228A8
        public StringViewHandler(HexEditor editor)
        {
            this._editor = editor;
            this._stringFormat = new StringFormat(StringFormat.GenericTypographic);
            this._stringFormat.Alignment = StringAlignment.Center;
            this._stringFormat.LineAlignment = StringAlignment.Center;
        }

        // Token: 0x06000407 RID: 1031 RVA: 0x000228DF File Offset: 0x000228DF
        public void OnKeyPress(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                this.HandleUserInput(e.KeyChar);
            }
        }

        // Token: 0x06000408 RID: 1032 RVA: 0x000228FC File Offset: 0x000228FC
        public void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                if (this._editor.SelectionLength > 0)
                {
                    this.HandleUserRemove();
                    int caretIndex = this._editor.CaretIndex;
                    Point caretLocation = this.GetCaretLocation(caretIndex);
                    this._editor.SetCaretStart(caretIndex, caretLocation);
                    return;
                }
                if (this._editor.CaretIndex < this._editor.LastVisibleByte && e.KeyCode == Keys.Delete)
                {
                    this._editor.RemoveByteAt(this._editor.CaretIndex);
                    Point caretLocation2 = this.GetCaretLocation(this._editor.CaretIndex);
                    this._editor.SetCaretStart(this._editor.CaretIndex, caretLocation2);
                    return;
                }
                if (this._editor.CaretIndex > 0 && e.KeyCode == Keys.Back)
                {
                    int index = this._editor.CaretIndex - 1;
                    this._editor.RemoveByteAt(index);
                    Point caretLocation3 = this.GetCaretLocation(index);
                    this._editor.SetCaretStart(index, caretLocation3);
                    return;
                }
            }
            else if (e.KeyCode == Keys.Up && this._editor.CaretIndex - this._editor.BytesPerLine >= 0)
            {
                int num = this._editor.CaretIndex - this._editor.BytesPerLine;
                if (num % this._editor.BytesPerLine != 0 || this._editor.CaretPosX < this._recStringView.X + this._recStringView.Width)
                {
                    this.HandleArrowKeys(num, e.Shift);
                    return;
                }
                Point location = new Point(this._editor.CaretPosX, this._editor.CaretPosY - this._recStringView.Height);
                if (num == 0)
                {
                    location = new Point(this._editor.CaretPosX, this._editor.CaretPosY);
                    num = this._editor.BytesPerLine;
                }
                if (e.Shift)
                {
                    this._editor.SetCaretEnd(num, location);
                    return;
                }
                this._editor.SetCaretStart(num, location);
                return;
            }
            else if (e.KeyCode == Keys.Down && (this._editor.CaretIndex - 1) / this._editor.BytesPerLine < this._editor.HexTableLength / this._editor.BytesPerLine)
            {
                int num2 = this._editor.CaretIndex + this._editor.BytesPerLine;
                if (num2 > this._editor.HexTableLength)
                {
                    num2 = this._editor.HexTableLength;
                    this.HandleArrowKeys(num2, e.Shift);
                    return;
                }
                Point location2 = new Point(this._editor.CaretPosX, this._editor.CaretPosY + this._recStringView.Height);
                if (e.Shift)
                {
                    this._editor.SetCaretEnd(num2, location2);
                    return;
                }
                this._editor.SetCaretStart(num2, location2);
                return;
            }
            else
            {
                if (e.KeyCode == Keys.Left && this._editor.CaretIndex - 1 >= 0)
                {
                    int index2 = this._editor.CaretIndex - 1;
                    this.HandleArrowKeys(index2, e.Shift);
                    return;
                }
                if (e.KeyCode == Keys.Right && this._editor.CaretIndex + 1 <= this._editor.LastVisibleByte)
                {
                    int index3 = this._editor.CaretIndex + 1;
                    this.HandleArrowKeys(index3, e.Shift);
                }
            }
        }

        // Token: 0x06000409 RID: 1033 RVA: 0x00022C60 File Offset: 0x00022C60
        public void HandleArrowKeys(int index, bool isShiftDown)
        {
            Point caretLocation = this.GetCaretLocation(index);
            if (isShiftDown)
            {
                this._editor.SetCaretEnd(index, caretLocation);
                return;
            }
            this._editor.SetCaretStart(index, caretLocation);
        }

        // Token: 0x0600040A RID: 1034 RVA: 0x00022C94 File Offset: 0x00022C94
        public void OnMouseDown(int x, int y)
        {
            int num = (x - this._recStringView.X) / (int)this._editor.CharSize.Width;
            int num2 = (y - this._recStringView.Y) / this._recStringView.Height;
            num = ((num > this._editor.BytesPerLine) ? this._editor.BytesPerLine : num);
            num = ((num < 0) ? 0 : num);
            num2 = ((num2 > this._editor.MaxBytesV) ? this._editor.MaxBytesV : num2);
            num2 = ((num2 < 0) ? 0 : num2);
            if ((this._editor.LastVisibleByte - this._editor.FirstVisibleByte) / this._editor.BytesPerLine <= num2)
            {
                if ((this._editor.LastVisibleByte - this._editor.FirstVisibleByte) % this._editor.BytesPerLine <= num)
                {
                    num = (this._editor.LastVisibleByte - this._editor.FirstVisibleByte) % this._editor.BytesPerLine;
                }
                num2 = (this._editor.LastVisibleByte - this._editor.FirstVisibleByte) / this._editor.BytesPerLine;
            }
            int index = Math.Min(this._editor.LastVisibleByte, this._editor.FirstVisibleByte + num + num2 * this._editor.BytesPerLine);
            int x2 = num * (int)this._editor.CharSize.Width + this._recStringView.X;
            int y2 = num2 * this._recStringView.Height + this._recStringView.Y;
            this._editor.SetCaretStart(index, new Point(x2, y2));
        }

        // Token: 0x0600040B RID: 1035 RVA: 0x00022E40 File Offset: 0x00022E40
        public void OnMouseDragged(int x, int y)
        {
            int num = (x - this._recStringView.X) / (int)this._editor.CharSize.Width;
            int num2 = (y - this._recStringView.Y) / this._recStringView.Height;
            num = ((num > this._editor.BytesPerLine) ? this._editor.BytesPerLine : num);
            num = ((num < 0) ? 0 : num);
            num2 = ((num2 > this._editor.MaxBytesV) ? this._editor.MaxBytesV : num2);
            if (this._editor.FirstVisibleByte > 0)
            {
                num2 = ((num2 < 0) ? (-1) : num2);
            }
            else
            {
                num2 = ((num2 < 0) ? 0 : num2);
            }
            if ((this._editor.LastVisibleByte - this._editor.FirstVisibleByte) / this._editor.BytesPerLine <= num2)
            {
                if ((this._editor.LastVisibleByte - this._editor.FirstVisibleByte) % this._editor.BytesPerLine <= num)
                {
                    num = (this._editor.LastVisibleByte - this._editor.FirstVisibleByte) % this._editor.BytesPerLine;
                }
                num2 = (this._editor.LastVisibleByte - this._editor.FirstVisibleByte) / this._editor.BytesPerLine;
            }
            int index = Math.Min(this._editor.LastVisibleByte, this._editor.FirstVisibleByte + num + num2 * this._editor.BytesPerLine);
            int x2 = num * (int)this._editor.CharSize.Width + this._recStringView.X;
            int y2 = num2 * this._recStringView.Height + this._recStringView.Y;
            this._editor.SetCaretEnd(index, new Point(x2, y2));
        }

        // Token: 0x0600040C RID: 1036 RVA: 0x00023004 File Offset: 0x00023004
        public void OnMouseDoubleClick()
        {
            if (this._editor.CaretIndex < this._editor.LastVisibleByte)
            {
                int index = this._editor.CaretIndex + 1;
                Point caretLocation = this.GetCaretLocation(index);
                this._editor.SetCaretEnd(index, caretLocation);
            }
        }

        // Token: 0x0600040D RID: 1037 RVA: 0x0002304C File Offset: 0x0002304C
        public void Focus()
        {
            int caretIndex = this._editor.CaretIndex;
            Point caretLocation = this.GetCaretLocation(caretIndex);
            this._editor.SetCaretStart(caretIndex, caretLocation);
        }

        // Token: 0x0600040E RID: 1038 RVA: 0x0002307C File Offset: 0x0002307C
        public void Update(int startPositionX, Rectangle area)
        {
            this._recStringView = new Rectangle(startPositionX, area.Y, (int)(this._editor.CharSize.Width * (float)this._editor.BytesPerLine), (int)this._editor.CharSize.Height - 2);
            this._recStringView.X = this._recStringView.X + this._editor.EntityMargin;
        }

        // Token: 0x0600040F RID: 1039 RVA: 0x000230F0 File Offset: 0x000230F0
        public void Paint(Graphics g, int index, int startIndex)
        {
            Point byteColumnAndRow = this.GetByteColumnAndRow(index);
            if (this._editor.IsSelected(index + startIndex))
            {
                this.PaintByteAsSelected(g, byteColumnAndRow, index + startIndex);
                return;
            }
            this.PaintByte(g, byteColumnAndRow, index + startIndex);
        }

        // Token: 0x06000410 RID: 1040 RVA: 0x0002312C File Offset: 0x0002312C
        private void PaintByteAsSelected(Graphics g, Point point, int index)
        {
            SolidBrush brush = new SolidBrush(this._editor.SelectionBackColor);
            SolidBrush brush2 = new SolidBrush(this._editor.SelectionForeColor);
            RectangleF bound = this.GetBound(point);
            char byteAsChar = this._editor.GetByteAsChar(index);
            string s = (char.IsControl(byteAsChar) ? "." : byteAsChar.ToString());
            g.FillRectangle(brush, bound);
            g.DrawString(s, this._editor.Font, brush2, bound, this._stringFormat);
        }

        // Token: 0x06000411 RID: 1041 RVA: 0x000231AC File Offset: 0x000231AC
        private void PaintByte(Graphics g, Point point, int index)
        {
            SolidBrush brush = new SolidBrush(this._editor.ForeColor);
            RectangleF bound = this.GetBound(point);
            char byteAsChar = this._editor.GetByteAsChar(index);
            string s = (char.IsControl(byteAsChar) ? "." : byteAsChar.ToString());
            g.DrawString(s, this._editor.Font, brush, bound, this._stringFormat);
        }

        // Token: 0x06000412 RID: 1042 RVA: 0x00023210 File Offset: 0x00023210
        private Point GetCaretLocation(int index)
        {
            int x = this._recStringView.X + (int)this._editor.CharSize.Width * (index % this._editor.BytesPerLine);
            int y = this._recStringView.Y + this._recStringView.Height * ((index - (this._editor.FirstVisibleByte + index % this._editor.BytesPerLine)) / this._editor.BytesPerLine);
            Point result = new Point(x, y);
            return result;
        }

        // Token: 0x06000413 RID: 1043 RVA: 0x00023298 File Offset: 0x00023298
        private void HandleUserRemove()
        {
            int selectionStart = this._editor.SelectionStart;
            Point caretLocation = this.GetCaretLocation(selectionStart);
            this._editor.RemoveSelectedBytes();
            this._editor.SetCaretStart(selectionStart, caretLocation);
        }

        // Token: 0x06000414 RID: 1044 RVA: 0x000232D4 File Offset: 0x000232D4
        private void HandleUserInput(char key)
        {
            if (!this._editor.CaretFocused)
            {
                return;
            }
            this.HandleUserRemove();
            byte item = Convert.ToByte(key);
            if (this._editor.HexTableLength <= 0)
            {
                this._editor.AppendByte(item);
            }
            else
            {
                this._editor.InsertByte(this._editor.CaretIndex, item);
            }
            int index = this._editor.CaretIndex + 1;
            Point caretLocation = this.GetCaretLocation(index);
            this._editor.SetCaretStart(index, caretLocation);
        }

        // Token: 0x06000415 RID: 1045 RVA: 0x00023354 File Offset: 0x00023354
        private Point GetByteColumnAndRow(int index)
        {
            int x = index % this._editor.BytesPerLine;
            int y = index / this._editor.BytesPerLine;
            Point result = new Point(x, y);
            return result;
        }

        // Token: 0x06000416 RID: 1046 RVA: 0x00023388 File Offset: 0x00023388
        private RectangleF GetBound(Point point)
        {
            RectangleF result = new RectangleF((float)(this._recStringView.X + point.X * (int)this._editor.CharSize.Width), (float)(this._recStringView.Y + point.Y * this._recStringView.Height), this._editor.CharSize.Width, (float)this._recStringView.Height);
            return result;
        }

        // Token: 0x040002F3 RID: 755
        private Rectangle _recStringView;

        // Token: 0x040002F4 RID: 756
        private StringFormat _stringFormat;

        // Token: 0x040002F5 RID: 757
        private HexEditor _editor;
    }
}