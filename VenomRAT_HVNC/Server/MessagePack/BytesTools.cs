using System;
using System.Text;

namespace Server.MessagePack
{
	// Token: 0x0200003A RID: 58
	public class BytesTools
	{
		// Token: 0x06000248 RID: 584 RVA: 0x0001B9F0 File Offset: 0x0001B9F0
		public static byte[] GetUtf8Bytes(string s)
		{
			return BytesTools.utf8Encode.GetBytes(s);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0001B9FD File Offset: 0x0001B9FD
		public static string GetString(byte[] utf8Bytes)
		{
			return BytesTools.utf8Encode.GetString(utf8Bytes);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0001BA0C File Offset: 0x0001BA0C
		public static string BytesAsString(byte[] bytes)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in bytes)
			{
				stringBuilder.Append(string.Format("{0:D3} ", b));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0001BA50 File Offset: 0x0001BA50
		public static string BytesAsHexString(byte[] bytes)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (byte b in bytes)
			{
				stringBuilder.Append(string.Format("{0:X2} ", b));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0001BA94 File Offset: 0x0001BA94
		public static byte[] SwapBytes(byte[] v)
		{
			byte[] array = new byte[v.Length];
			int num = v.Length - 1;
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = v[num];
				num--;
			}
			return array;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0001BAC9 File Offset: 0x0001BAC9
		public static byte[] SwapInt64(long v)
		{
			return BytesTools.SwapBytes(BitConverter.GetBytes(v));
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0001BAD8 File Offset: 0x0001BAD8
		public static byte[] SwapInt32(int v)
		{
			byte[] array = new byte[]
			{
				0,
				0,
				0,
				(byte)v
			};
			array[2] = (byte)(v >> 8);
			array[1] = (byte)(v >> 16);
			array[0] = (byte)(v >> 24);
			return array;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0001BB0C File Offset: 0x0001BB0C
		public static byte[] SwapInt16(short v)
		{
			byte[] array = new byte[]
			{
				0,
				(byte)v
			};
			array[0] = (byte)(v >> 8);
			return array;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0001BB2D File Offset: 0x0001BB2D
		public static byte[] SwapDouble(double v)
		{
			return BytesTools.SwapBytes(BitConverter.GetBytes(v));
		}

		// Token: 0x040001F8 RID: 504
		private static UTF8Encoding utf8Encode = new UTF8Encoding();
	}
}
