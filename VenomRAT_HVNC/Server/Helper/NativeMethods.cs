using System;
using System.Runtime.InteropServices;

namespace VenomRAT_HVNC.Server.Helper
{
    // Token: 0x02000053 RID: 83
    public static class NativeMethods
    {
        // Token: 0x060002D2 RID: 722
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr SendMessage(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

        // Token: 0x060002D3 RID: 723
        [DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SendMessage")]
        internal static extern IntPtr SendMessageListViewItem(IntPtr hWnd, uint msg, IntPtr wParam, ref NativeMethods.LVITEM lParam);

        // Token: 0x060002D4 RID: 724
        [DllImport("user32.dll")]
        internal static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, int vk);

        // Token: 0x060002D5 RID: 725
        [DllImport("user32.dll")]
        internal static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        // Token: 0x060002D6 RID: 726
        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        internal static extern int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

        // Token: 0x02000054 RID: 84
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        internal struct LVITEM
        {
            // Token: 0x04000258 RID: 600
            public uint mask;

            // Token: 0x04000259 RID: 601
            public int iItem;

            // Token: 0x0400025A RID: 602
            public int iSubItem;

            // Token: 0x0400025B RID: 603
            public int state;

            // Token: 0x0400025C RID: 604
            public int stateMask;

            // Token: 0x0400025D RID: 605
            [MarshalAs(UnmanagedType.LPTStr)]
            public string pszText;

            // Token: 0x0400025E RID: 606
            public int cchTextMax;

            // Token: 0x0400025F RID: 607
            public int iImage;

            // Token: 0x04000260 RID: 608
            public IntPtr lParam;

            // Token: 0x04000261 RID: 609
            public int iIndent;

            // Token: 0x04000262 RID: 610
            public int iGroupId;

            // Token: 0x04000263 RID: 611
            public uint cColumns;

            // Token: 0x04000264 RID: 612
            public IntPtr puColumns;

            // Token: 0x04000265 RID: 613
            public IntPtr piColFmt;

            // Token: 0x04000266 RID: 614
            public int iGroup;
        }
    }
}