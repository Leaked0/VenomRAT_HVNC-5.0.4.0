using System.Security.Cryptography;
using System.Text;

namespace VenomRAT_HVNC.Server.Algorithm
{
    // Token: 0x020000B9 RID: 185
    public static class Sha256
    {
        // Token: 0x060005D9 RID: 1497 RVA: 0x0004706C File Offset: 0x0004706C
        public static string ComputeHash(string input)
        {
            byte[] array = Encoding.UTF8.GetBytes(input);
            using (SHA256Managed sha256Managed = new SHA256Managed())
            {
                array = sha256Managed.ComputeHash(array);
            }
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte b in array)
            {
                stringBuilder.Append(b.ToString("X2"));
            }
            return stringBuilder.ToString().ToUpper();
        }

        // Token: 0x060005DA RID: 1498 RVA: 0x000470F0 File Offset: 0x000470F0
        public static byte[] ComputeHash(byte[] input)
        {
            byte[] result;
            using (SHA256Managed sha256Managed = new SHA256Managed())
            {
                result = sha256Managed.ComputeHash(input);
            }
            return result;
        }
    }
}