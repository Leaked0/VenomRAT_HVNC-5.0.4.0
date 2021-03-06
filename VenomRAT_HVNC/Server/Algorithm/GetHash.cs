using System;
using System.IO;
using System.Security.Cryptography;

namespace VenomRAT_HVNC.Server.Algorithm
{
    // Token: 0x020000B8 RID: 184
    public static class GetHash
    {
        // Token: 0x060005D8 RID: 1496 RVA: 0x00047014 File Offset: 0x00047014
        public static string GetChecksum(string file)
        {
            string result;
            using (FileStream fileStream = File.OpenRead(file))
            {
                SHA256Managed sha256Managed = new SHA256Managed();
                byte[] value = sha256Managed.ComputeHash(fileStream);
                result = BitConverter.ToString(value).Replace("-", string.Empty);
            }
            return result;
        }
    }
}