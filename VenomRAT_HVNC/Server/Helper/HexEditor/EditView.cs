using System;
using System.Drawing;
using System.Windows.Forms;

namespace VenomRAT_HVNC.Server.Helper.HexEditor
{
    // Token: 0x0200006A RID: 106
    public class EditView : IKeyMouseEventHandler
    {
        // Token: 0x06000385 RID: 901 RVA: 0x0002005B File Offset: 0x0002005B
        public EditView(HexEditor editor)
        {
            this._editor = editor;
            this._hexView = new HexViewHandler(editor);
            this._stringView = new StringViewHandler(editor);
        }

        // Token: 0x06000386 RID: 902 RVA: 0x00020082 File Offset: 0x00020082
        public void OnKeyPress(KeyPressEventArgs e)
        {
            if (this.InHexView(this._editor.CaretPosX))
            {
                this._hexView.OnKeyPress(e);
                return;
            }
            this._stringView.OnKeyPress(e);
        }

        // Token: 0x06000387 RID: 903 RVA: 0x000200B0 File Offset: 0x000200B0
        public void OnKeyDown(KeyEventArgs e)
        {
            if (this.InHexView(this._editor.CaretPosX))
            {
                this._hexView.OnKeyDown(e);
                return;
            }
            this._stringView.OnKeyDown(e);
        }

        // Token: 0x06000388 RID: 904 RVA: 0x000067A9 File Offset: 0x000067A9
        public void OnKeyUp(KeyEventArgs e)
        {
        }

        // Token: 0x06000389 RID: 905 RVA: 0x000200E0 File Offset: 0x000200E0
        public void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.InHexView(e.X))
                {
                    this._hexView.OnMouseDown(e.X, e.Y);
                    return;
                }
                this._stringView.OnMouseDown(e.X, e.Y);
            }
        }

        // Token: 0x0600038A RID: 906 RVA: 0x00020138 File Offset: 0x00020138
        public void OnMouseDragged(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.InHexView(e.X))
                {
                    this._hexView.OnMouseDragged(e.X, e.Y);
                    return;
                }
                this._stringView.OnMouseDragged(e.X, e.Y);
            }
        }

        // Token: 0x0600038B RID: 907 RVA: 0x000067A9 File Offset: 0x000067A9
        public void OnMouseUp(MouseEventArgs e)
        {
        }

        // Token: 0x0600038C RID: 908 RVA: 0x0002018F File Offset: 0x0002018F
        public void OnMouseDoubleClick(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.InHexView(e.X))
                {
                    this._hexView.OnMouseDoubleClick();
                    return;
                }
                this._stringView.OnMouseDoubleClick();
            }
        }

        // Token: 0x0600038D RID: 909 RVA: 0x000201C3 File Offset: 0x000201C3
        public void OnGotFocus(EventArgs e)
        {
            if (this.InHexView(this._editor.CaretPosX))
            {
                this._hexView.Focus();
                return;
            }
            this._stringView.Focus();
        }

        // Token: 0x0600038E RID: 910 RVA: 0x000201EF File Offset: 0x000201EF
        public void SetLowerCase()
        {
            this._hexView.SetLowerCase();
        }

        // Token: 0x0600038F RID: 911 RVA: 0x000201FC File Offset: 0x000201FC
        public void SetUpperCase()
        {
            this._hexView.SetUpperCase();
        }

        // Token: 0x06000390 RID: 912 RVA: 0x00020209 File Offset: 0x00020209
        public void Update(int startPositionX, Rectangle area)
        {
            this._hexView.Update(startPositionX, area);
            this._stringView.Update(this._hexView.MaxWidth, area);
        }

        // Token: 0x06000391 RID: 913 RVA: 0x00020230 File Offset: 0x00020230
        public void Paint(Graphics g, int startIndex, int endIndex)
        {
            int num = 0;
            while (num + startIndex < endIndex)
            {
                this._hexView.Paint(g, num, startIndex);
                this._stringView.Paint(g, num, startIndex);
                num++;
            }
        }

        // Token: 0x06000392 RID: 914 RVA: 0x00020267 File Offset: 0x00020267
        private bool InHexView(int x)
        {
            return x < this._hexView.MaxWidth + this._editor.EntityMargin - 2;
        }

        // Token: 0x040002C0 RID: 704
        private HexViewHandler _hexView;

        // Token: 0x040002C1 RID: 705
        private StringViewHandler _stringView;

        // Token: 0x040002C2 RID: 706
        private HexEditor _editor;
    }
}