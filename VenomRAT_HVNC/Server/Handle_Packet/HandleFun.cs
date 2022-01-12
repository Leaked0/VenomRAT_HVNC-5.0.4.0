using System.Windows.Forms;
using Server.MessagePack;
using VenomRAT_HVNC.Server.Connection;
using VenomRAT_HVNC.Server.Forms;

namespace VenomRAT_HVNC.Server.Handle_Packet
{
    // Token: 0x02000097 RID: 151
    public class HandleFun
    {
        // Token: 0x0600058B RID: 1419 RVA: 0x00042C8C File Offset: 0x00042C8C
        public void Fun(Clients client, MsgPack unpack_msgpack)
        {
            try
            {
                FormFun formFun = (FormFun)Application.OpenForms["fun:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
                if (formFun != null && formFun.Client == null)
                {
                    formFun.Client = client;
                    formFun.timer1.Enabled = true;
                }
            }
            catch
            {
            }
        }
    }
}