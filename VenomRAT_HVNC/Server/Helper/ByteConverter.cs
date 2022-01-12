using System;
using System.Collections.Generic;
using System.Text;

namespace VenomRAT_HVNC.Server.Helper
{
    // Token: 0x02000044 RID: 68
    public class ByteConverter
    {
        // Token: 0x0600029B RID: 667 RVA: 0x0001D37D File Offset: 0x0001D37D
        public static byte[] GetBytes(int value)
        {
            return BitConverter.GetBytes(value);
        }

        // Token: 0x0600029C RID: 668 RVA: 0x0001D385 File Offset: 0x0001D385
        public static byte[] GetBytes(long value)
        {
            return BitConverter.GetBytes(value);
        }

        // Token: 0x0600029D RID: 669 RVA: 0x0001D38D File Offset: 0x0001D38D
        public static byte[] GetBytes(uint value)
        {
            return BitConverter.GetBytes(value);
        }

        // Token: 0x0600029E RID: 670 RVA: 0x0001D395 File Offset: 0x0001D395
        public static byte[] GetBytes(ulong value)
        {
            return BitConverter.GetBytes(value);
        }

        // Token: 0x0600029F RID: 671 RVA: 0x0001D39D File Offset: 0x0001D39D
        public static byte[] GetBytes(string value)
        {
            return ByteConverter.StringToBytes(value);
        }

        // Token: 0x060002A0 RID: 672 RVA: 0x0001D3A5 File Offset: 0x0001D3A5
        public static byte[] GetBytes(string[] value)
        {
            return ByteConverter.StringArrayToBytes(value);
        }

        // Token: 0x060002A1 RID: 673 RVA: 0x0001D3AD File Offset: 0x0001D3AD
        public static int ToInt32(byte[] bytes)
        {
            return BitConverter.ToInt32(bytes, 0);
        }

        // Token: 0x060002A2 RID: 674 RVA: 0x0001D3B6 File Offset: 0x0001D3B6
        public static long ToInt64(byte[] bytes)
        {
            return BitConverter.ToInt64(bytes, 0);
        }

        // Token: 0x060002A3 RID: 675 RVA: 0x0001D3BF File Offset: 0x0001D3BF
        public static uint ToUInt32(byte[] bytes)
        {
            return BitConverter.ToUInt32(bytes, 0);
        }

        // Token: 0x060002A4 RID: 676 RVA: 0x0001D3C8 File Offset: 0x0001D3C8
        public static ulong ToUInt64(byte[] bytes)
        {
            return BitConverter.ToUInt64(bytes, 0);
        }

        // Token: 0x060002A5 RID: 677 RVA: 0x0001D3D1 File Offset: 0x0001D3D1
        public static string ToString(byte[] bytes)
        {
            return ByteConverter.BytesToString(bytes);
        }

        // Token: 0x060002A6 RID: 678 RVA: 0x0001D3D9 File Offset: 0x0001D3D9
        public static string[] ToStringArray(byte[] bytes)
        {
            return ByteConverter.BytesToStringArray(bytes);
        }

        // Token: 0x060002A7 RID: 679 RVA: 0x0001D3E1 File Offset: 0x0001D3E1
        private static byte[] GetNullBytes()
        {
            return new byte[]
            {
                ByteConverter.NULL_BYTE,
                ByteConverter.NULL_BYTE
            };
        }

        // Token: 0x060002A8 RID: 680 RVA: 0x0001D3FC File Offset: 0x0001D3FC
        private static byte[] StringToBytes(string value)
        {
            byte[] array = new byte[value.Length * 2];
            Buffer.BlockCopy(value.ToCharArray(), 0, array, 0, array.Length);
            return array;
        }

        // Token: 0x060002A9 RID: 681 RVA: 0x0001D42C File Offset: 0x0001D42C
        private static byte[] StringArrayToBytes(string[] strings)
        {
            List<byte> list = new List<byte>();
            foreach (string value in strings)
            {
                list.AddRange(ByteConverter.StringToBytes(value));
                list.AddRange(ByteConverter.GetNullBytes());
            }
            return list.ToArray();
        }

        // Token: 0x060002AA RID: 682 RVA: 0x0001D470 File Offset: 0x0001D470
        private static string BytesToString(byte[] bytes)
        {
            int num = (int)Math.Ceiling((double)((float)bytes.Length / 2f));
            char[] array = new char[num];
            Buffer.BlockCopy(bytes, 0, array, 0, bytes.Length);
            return new string(array);
        }

        // Token: 0x060002AB RID: 683 RVA: 0x0001D4A8 File Offset: 0x0001D4A8
        private static string[] BytesToStringArray(byte[] bytes)
        {
            List<string> list = new List<string>();
            int i = 0;
            StringBuilder stringBuilder = new StringBuilder(bytes.Length);
            while (i < bytes.Length)
            {
                int num = 0;
                while (i < bytes.Length && num < 3)
                {
                    if (bytes[i] == ByteConverter.NULL_BYTE)
                    {
                        num++;
                    }
                    else
                    {
                        stringBuilder.Append(Convert.ToChar(bytes[i]));
                        num = 0;
                    }
                    i++;
                }
                list.Add(stringBuilder.ToString());
                stringBuilder.Clear();
            }
            return list.ToArray();
        }

        // Token: 0x04000223 RID: 547
        private static byte NULL_BYTE;
    }
}