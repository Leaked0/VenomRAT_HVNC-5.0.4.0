using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace VenomRAT_HVNC.Server.Helper.HexEditor
{
    // Token: 0x02000069 RID: 105
    public class Caret
    {
        // Token: 0x170000A2 RID: 162
        // (get) Token: 0x0600036D RID: 877 RVA: 0x0001FCDE File Offset: 0x0001FCDE
        public int SelectionStart
        {
            get
            {
                if (this._endIndex < this._startIndex)
                {
                    return this._endIndex;
                }
                return this._startIndex;
            }
        }

        // Token: 0x170000A3 RID: 163
        // (get) Token: 0x0600036E RID: 878 RVA: 0x0001FCFB File Offset: 0x0001FCFB
        public int SelectionLength
        {
            get
            {
                if (this._endIndex < this._startIndex)
                {
                    return this._startIndex - this._endIndex;
                }
                return this._endIndex - this._startIndex;
            }
        }

        // Token: 0x170000A4 RID: 164
        // (get) Token: 0x0600036F RID: 879 RVA: 0x0001FD26 File Offset: 0x0001FD26
        public bool Focused
        {
            get
            {
                return this._isCaretActive;
            }
        }

        // Token: 0x170000A5 RID: 165
        // (get) Token: 0x06000370 RID: 880 RVA: 0x0001FD2E File Offset: 0x0001FD2E
        public int CurrentIndex
        {
            get
            {
                return this._endIndex;
            }
        }

        // Token: 0x170000A6 RID: 166
        // (get) Token: 0x06000371 RID: 881 RVA: 0x0001FD36 File Offset: 0x0001FD36
        public Point Location
        {
            get
            {
                return this._location;
            }
        }

        // Token: 0x1400000B RID: 11
        // (add) Token: 0x06000372 RID: 882 RVA: 0x0001FD40 File Offset: 0x0001FD40
        // (remove) Token: 0x06000373 RID: 883 RVA: 0x0001FD78 File Offset: 0x0001FD78
        public event EventHandler SelectionStartChanged;

        // Token: 0x1400000C RID: 12
        // (add) Token: 0x06000374 RID: 884 RVA: 0x0001FDB0 File Offset: 0x0001FDB0
        // (remove) Token: 0x06000375 RID: 885 RVA: 0x0001FDE8 File Offset: 0x0001FDE8
        public event EventHandler SelectionLengthChanged;

        // Token: 0x06000376 RID: 886 RVA: 0x0001FE1D File Offset: 0x0001FE1D
        public Caret(HexEditor editor)
        {
            this._editor = editor;
            this._isCaretActive = false;
            this._startIndex = 0;
            this._endIndex = 0;
            this._isCaretHidden = true;
            this._location = new Point(0, 0);
        }

        // Token: 0x06000377 RID: 887 RVA: 0x0001FE58 File Offset: 0x0001FE58
        private bool Create(IntPtr hWHandler)
        {
            if (!this._isCaretActive)
            {
                this._isCaretActive = true;
                return Caret.CreateCaret(hWHandler, IntPtr.Zero, 0, (int)this._editor.CharSize.Height - 2);
            }
            return false;
        }

        // Token: 0x06000378 RID: 888 RVA: 0x0001FE98 File Offset: 0x0001FE98
        private bool Show(IntPtr hWnd)
        {
            if (this._isCaretActive)
            {
                this._isCaretHidden = false;
                return Caret.ShowCaret(hWnd);
            }
            return false;
        }

        // Token: 0x06000379 RID: 889 RVA: 0x0001FEB1 File Offset: 0x0001FEB1
        public bool Hide(IntPtr hWnd)
        {
            if (this._isCaretActive && !this._isCaretHidden)
            {
                this._isCaretHidden = true;
                return Caret.HideCaret(hWnd);
            }
            return false;
        }

        // Token: 0x0600037A RID: 890 RVA: 0x0001FED2 File Offset: 0x0001FED2
        public bool Destroy()
        {
            if (this._isCaretActive)
            {
                this._isCaretActive = false;
                this.DeSelect();
                Caret.DestroyCaret();
            }
            return false;
        }

        // Token: 0x0600037B RID: 891 RVA: 0x0001FEF0 File Offset: 0x0001FEF0
        public void SetStartIndex(int index)
        {
            this._startIndex = index;
            this._endIndex = this._startIndex;
            if (this.SelectionStartChanged != null)
            {
                this.SelectionStartChanged(this, EventArgs.Empty);
            }
            if (this.SelectionLengthChanged != null)
            {
                this.SelectionLengthChanged(this, EventArgs.Empty);
            }
        }

        // Token: 0x0600037C RID: 892 RVA: 0x0001FF42 File Offset: 0x0001FF42
        public void SetEndIndex(int index)
        {
            this._endIndex = index;
            if (this.SelectionStartChanged != null)
            {
                this.SelectionStartChanged(this, EventArgs.Empty);
            }
            if (this.SelectionLengthChanged != null)
            {
                this.SelectionLengthChanged(this, EventArgs.Empty);
            }
        }

        // Token: 0x0600037D RID: 893 RVA: 0x0001FF80 File Offset: 0x0001FF80
        public void SetCaretLocation(Point start)
        {
            this.Create(this._editor.Handle);
            this._location = start;
            Caret.SetCaretPos(this._location.X, this._location.Y);
            this.Show(this._editor.Handle);
        }

        // Token: 0x0600037E RID: 894 RVA: 0x0001FFD4 File Offset: 0x0001FFD4
        public bool IsSelected(int byteIndex)
        {
            return this.SelectionStart <= byteIndex && byteIndex < this.SelectionStart + this.SelectionLength;
        }

        // Token: 0x0600037F RID: 895 RVA: 0x0001FFF4 File Offset: 0x0001FFF4
        private void DeSelect()
        {
            if (this._endIndex < this._startIndex)
            {
                this._startIndex = this._endIndex;
            }
            else
            {
                this._endIndex = this._startIndex;
            }
            if (this.SelectionStartChanged != null)
            {
                this.SelectionStartChanged(this, EventArgs.Empty);
            }
            if (this.SelectionLengthChanged != null)
            {
                this.SelectionLengthChanged(this, EventArgs.Empty);
            }
        }

        // Token: 0x06000380 RID: 896
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool CreateCaret(IntPtr hWnd, IntPtr hBitmap, int nWidth, int nHeight);

        // Token: 0x06000381 RID: 897
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool DestroyCaret();

        // Token: 0x06000382 RID: 898
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool SetCaretPos(int x, int y);

        // Token: 0x06000383 RID: 899
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool ShowCaret(IntPtr hWnd);

        // Token: 0x06000384 RID: 900
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool HideCaret(IntPtr hWnd);

        // Token: 0x040002B8 RID: 696
        private int _startIndex;

        // Token: 0x040002B9 RID: 697
        private int _endIndex;

        // Token: 0x040002BA RID: 698
        private bool _isCaretActive;

        // Token: 0x040002BB RID: 699
        private bool _isCaretHidden;

        // Token: 0x040002BC RID: 700
        private Point _location;

        // Token: 0x040002BD RID: 701
        private HexEditor _editor;
    }
}