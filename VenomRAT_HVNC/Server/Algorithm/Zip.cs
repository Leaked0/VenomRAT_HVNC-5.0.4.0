using System;
using System.IO;
using System.IO.Compression;

namespace VenomRAT_HVNC.Server.Algorithm
{
    // Token: 0x020000BA RID: 186
    public static class Zip
    {
        // Token: 0x060005DB RID: 1499 RVA: 0x00047128 File Offset: 0x00047128
        public static byte[] Decompress(byte[] input)
        {
            byte[] result;
            using (MemoryStream memoryStream = new MemoryStream(input))
            {
                byte[] array = new byte[4];
                memoryStream.Read(array, 0, 4);
                int num = BitConverter.ToInt32(array, 0);
                using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
                {
                    byte[] array2 = new byte[num];
                    gzipStream.Read(array2, 0, num);
                    result = array2;
                }
            }
            return result;
        }

        // Token: 0x060005DC RID: 1500 RVA: 0x000471A8 File Offset: 0x000471A8
        public static byte[] Compress(byte[] input)
        {
            byte[] result;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                byte[] bytes = BitConverter.GetBytes(input.Length);
                memoryStream.Write(bytes, 0, 4);
                using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Compress))
                {
                    gzipStream.Write(input, 0, input.Length);
                    gzipStream.Flush();
                }
                result = memoryStream.ToArray();
            }
            return result;
        }
    }
}