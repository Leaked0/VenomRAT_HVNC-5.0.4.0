using System;
using System.IO;

namespace Server.MessagePack
{
    // Token: 0x02000042 RID: 66
    internal class WriteTools
    {
        // Token: 0x06000291 RID: 657 RVA: 0x0001D04D File Offset: 0x0001D04D
        public static void WriteNull(Stream ms)
        {
            ms.WriteByte(192);
        }

        // Token: 0x06000292 RID: 658 RVA: 0x0001D05C File Offset: 0x0001D05C
        public static void WriteString(Stream ms, string strVal)
        {
            byte[] utf8Bytes = BytesTools.GetUtf8Bytes(strVal);
            int num = utf8Bytes.Length;
            if (num <= 31)
            {
                int value = 160 + (byte)num;
                ms.WriteByte((byte)value);
            }
            else if (num <= 255)
            {
                byte value = 217;
                ms.WriteByte(value);
                value = (byte)num;
                ms.WriteByte(value);
            }
            else if (num <= 65535)
            {
                byte value = 218;
                ms.WriteByte(value);
                byte[] array = BytesTools.SwapBytes(BitConverter.GetBytes((short)num));
                ms.Write(array, 0, array.Length);
            }
            else
            {
                byte value = 219;
                ms.WriteByte(value);
                byte[] array = BytesTools.SwapBytes(BitConverter.GetBytes(num));
                ms.Write(array, 0, array.Length);
            }
            ms.Write(utf8Bytes, 0, utf8Bytes.Length);
        }

        // Token: 0x06000293 RID: 659 RVA: 0x0001D110 File Offset: 0x0001D110
        public static void WriteBinary(Stream ms, byte[] rawBytes)
        {
            int num = rawBytes.Length;
            if (num <= 255)
            {
                byte value = 196;
                ms.WriteByte(value);
                value = (byte)num;
                ms.WriteByte(value);
            }
            else if (num <= 65535)
            {
                byte value = 197;
                ms.WriteByte(value);
                byte[] array = BytesTools.SwapBytes(BitConverter.GetBytes((short)num));
                ms.Write(array, 0, array.Length);
            }
            else
            {
                byte value = 198;
                ms.WriteByte(value);
                byte[] array = BytesTools.SwapBytes(BitConverter.GetBytes(num));
                ms.Write(array, 0, array.Length);
            }
            ms.Write(rawBytes, 0, rawBytes.Length);
        }

        // Token: 0x06000294 RID: 660 RVA: 0x0001D1A4 File Offset: 0x0001D1A4
        public static void WriteFloat(Stream ms, double fVal)
        {
            ms.WriteByte(203);
            ms.Write(BytesTools.SwapDouble(fVal), 0, 8);
        }

        // Token: 0x06000295 RID: 661 RVA: 0x0001D1BF File Offset: 0x0001D1BF
        public static void WriteSingle(Stream ms, float fVal)
        {
            ms.WriteByte(202);
            ms.Write(BytesTools.SwapBytes(BitConverter.GetBytes(fVal)), 0, 4);
        }

        // Token: 0x06000296 RID: 662 RVA: 0x0001D1DF File Offset: 0x0001D1DF
        public static void WriteBoolean(Stream ms, bool bVal)
        {
            if (bVal)
            {
                ms.WriteByte(195);
                return;
            }
            ms.WriteByte(194);
        }

        // Token: 0x06000297 RID: 663 RVA: 0x0001D1FC File Offset: 0x0001D1FC
        public static void WriteUInt64(Stream ms, ulong iVal)
        {
            ms.WriteByte(207);
            byte[] bytes = BitConverter.GetBytes(iVal);
            ms.Write(BytesTools.SwapBytes(bytes), 0, 8);
        }

        // Token: 0x06000298 RID: 664 RVA: 0x0001D22C File Offset: 0x0001D22C
        public static void WriteInteger(Stream ms, long iVal)
        {
            if (iVal >= 0L)
            {
                if (iVal <= 127L)
                {
                    ms.WriteByte((byte)iVal);
                    return;
                }
                if (iVal <= 255L)
                {
                    ms.WriteByte(204);
                    ms.WriteByte((byte)iVal);
                    return;
                }
                if (iVal <= 65535L)
                {
                    ms.WriteByte(205);
                    ms.Write(BytesTools.SwapInt16((short)iVal), 0, 2);
                    return;
                }
                if (iVal <= (long)((ulong)(1)))
                {
                    ms.WriteByte(206);
                    ms.Write(BytesTools.SwapInt32((int)iVal), 0, 4);
                    return;
                }
                ms.WriteByte(211);
                ms.Write(BytesTools.SwapInt64(iVal), 0, 8);
                return;
            }
            else
            {
                if (iVal <= -2147483648L)
                {
                    ms.WriteByte(211);
                    ms.Write(BytesTools.SwapInt64(iVal), 0, 8);
                    return;
                }
                if (iVal <= -32768L)
                {
                    ms.WriteByte(210);
                    ms.Write(BytesTools.SwapInt32((int)iVal), 0, 4);
                    return;
                }
                if (iVal <= -128L)
                {
                    ms.WriteByte(209);
                    ms.Write(BytesTools.SwapInt16((short)iVal), 0, 2);
                    return;
                }
                if (iVal <= -32L)
                {
                    ms.WriteByte(208);
                    ms.WriteByte((byte)iVal);
                    return;
                }
                ms.WriteByte((byte)iVal);
                return;
            }
        }
    }
}