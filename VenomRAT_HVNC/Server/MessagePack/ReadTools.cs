using System;
using System.IO;

namespace Server.MessagePack
{
	// Token: 0x02000041 RID: 65
	internal class ReadTools
	{
		// Token: 0x0600028D RID: 653 RVA: 0x0001CF68 File Offset: 0x0001CF68
		public static string ReadString(Stream ms, int len)
		{
			byte[] array = new byte[len];
			ms.Read(array, 0, len);
			return BytesTools.GetString(array);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0001CF8C File Offset: 0x0001CF8C
		public static string ReadString(Stream ms)
		{
			byte strFlag = (byte)ms.ReadByte();
			return ReadTools.ReadString(strFlag, ms);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0001CFA8 File Offset: 0x0001CFA8
		public static string ReadString(byte strFlag, Stream ms)
		{
			int num = 0;
			byte[] array;
			if (strFlag >= 160 && strFlag <= 191)
			{
				num = (int)(strFlag - 160);
			}
			else if (strFlag == 217)
			{
				num = ms.ReadByte();
			}
			else if (strFlag == 218)
			{
				array = new byte[2];
				ms.Read(array, 0, 2);
				array = BytesTools.SwapBytes(array);
				num = (int)BitConverter.ToUInt16(array, 0);
			}
			else if (strFlag == 219)
			{
				array = new byte[4];
				ms.Read(array, 0, 4);
				array = BytesTools.SwapBytes(array);
				num = BitConverter.ToInt32(array, 0);
			}
			array = new byte[num];
			ms.Read(array, 0, num);
			return BytesTools.GetString(array);
		}
	}
}
