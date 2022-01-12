using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VenomRAT_HVNC.Server.Helper
{
    // Token: 0x02000051 RID: 81
    public static class Methods
    {
        // Token: 0x060002C8 RID: 712 RVA: 0x0001DDF0 File Offset: 0x0001DDF0
        public static string BytesToString(long byteCount)
        {
            string[] array = new string[] { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
            if (byteCount == 0L)
            {
                return "0" + array[0];
            }
            long num = Math.Abs(byteCount);
            int num2 = Convert.ToInt32(Math.Floor(Math.Log((double)num, 1024.0)));
            double num3 = Math.Round((double)num / Math.Pow(1024.0, (double)num2), 1);
            return ((double)Math.Sign(byteCount) * num3).ToString() + array[num2];
        }

        // Token: 0x060002C9 RID: 713 RVA: 0x0001DEA4 File Offset: 0x0001DEA4
        public static async Task FadeIn(Form o, int interval = 80)
        {
            while (o.Opacity < 1.0)
            {
                await Task.Delay(interval);
                o.Opacity += 0.05;
            }
        }

        // Token: 0x060002CA RID: 714 RVA: 0x0001DEF0 File Offset: 0x0001DEF0
        public static double DiffSeconds(DateTime startTime, DateTime endTime)
        {
            TimeSpan timeSpan = new TimeSpan(endTime.Ticks - startTime.Ticks);
            return Math.Abs(timeSpan.TotalSeconds);
        }

        // Token: 0x060002CB RID: 715 RVA: 0x0001DF20 File Offset: 0x0001DF20
        public static string GetRandomString(int length)
        {
            StringBuilder stringBuilder = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                stringBuilder.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"[Methods.Random.Next("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".Length)]);
            }
            return stringBuilder.ToString();
        }

        // Token: 0x060002CC RID: 716 RVA: 0x0001DC8A File Offset: 0x0001DC8A
        public static int MakeWin32Long(short wLow, short wHigh)
        {
            return ((int)wLow << 16) | (int)wHigh;
        }

        // Token: 0x060002CD RID: 717 RVA: 0x0001DF6C File Offset: 0x0001DF6C
        public static void SetItemState(IntPtr handle, int itemIndex, int mask, int value)
        {
            NativeMethods.LVITEM lvitem = new NativeMethods.LVITEM
            {
                stateMask = mask,
                state = value
            };
            NativeMethods.SendMessageListViewItem(handle, 4139U, new IntPtr(itemIndex), ref lvitem);
        }

        // Token: 0x060002CE RID: 718 RVA: 0x0001DFA7 File Offset: 0x0001DFA7
        public static void ScrollToBottom(IntPtr handle)
        {
            NativeMethods.SendMessage(handle, 277U, Methods.SB_PAGEBOTTOM, IntPtr.Zero);
        }

        // Token: 0x0400024D RID: 589
        private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        // Token: 0x0400024E RID: 590
        public static Random Random = new Random();

        // Token: 0x0400024F RID: 591
        private const int LVM_FIRST = 4096;

        // Token: 0x04000250 RID: 592
        private const int LVM_SETITEMSTATE = 4139;

        // Token: 0x04000251 RID: 593
        private const int WM_VSCROLL = 277;

        // Token: 0x04000252 RID: 594
        private static readonly IntPtr SB_PAGEBOTTOM = new IntPtr(7);
    }
}