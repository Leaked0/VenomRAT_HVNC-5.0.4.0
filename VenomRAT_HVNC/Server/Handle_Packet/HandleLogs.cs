using System;
using System.Drawing;
using System.Windows.Forms;
using Server;

namespace VenomRAT_HVNC.Server.Handle_Packet
{
    // Token: 0x020000AC RID: 172
    public class HandleLogs
    {
        // Token: 0x060005BB RID: 1467 RVA: 0x00045608 File Offset: 0x00045608
        public void Addmsg(string Msg, Color color)
        {
            try
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = DateTime.Now.ToLongTimeString();
                listViewItem.SubItems.Add(Msg);
                listViewItem.ForeColor = color;
                if (Program.form1.InvokeRequired)
                {
                    Program.form1.Invoke(new MethodInvoker(delegate ()
                    {
                        object lockListviewLogs2 = Settings.LockListviewLogs;
                        lock (lockListviewLogs2)
                        {
                        }
                    }));
                }
                else
                {
                    object lockListviewLogs = Settings.LockListviewLogs;
                    lock (lockListviewLogs)
                    {
                    }
                }
            }
            catch
            {
            }
        }
    }
}