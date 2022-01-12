using System;
using System.Collections.Generic;
using Microsoft.Win32;
using ProtoBuf;

namespace VenomRAT_HVNC.Server.Helper
{
    // Token: 0x0200005F RID: 95
    public class RegistrySeeker
    {
        // Token: 0x1700008A RID: 138
        // (get) Token: 0x0600030F RID: 783 RVA: 0x0001EBB2 File Offset: 0x0001EBB2
        public RegistrySeeker.RegSeekerMatch[] Matches
        {
            get
            {
                List<RegistrySeeker.RegSeekerMatch> matches = this._matches;
                if (matches == null)
                {
                    return null;
                }
                return matches.ToArray();
            }
        }

        // Token: 0x06000310 RID: 784 RVA: 0x0001EBC5 File Offset: 0x0001EBC5
        public RegistrySeeker()
        {
            this._matches = new List<RegistrySeeker.RegSeekerMatch>();
        }

        // Token: 0x06000311 RID: 785 RVA: 0x0001EBD8 File Offset: 0x0001EBD8
        public void BeginSeeking(string rootKeyName)
        {
            if (!string.IsNullOrEmpty(rootKeyName))
            {
                using (RegistryKey rootKey = RegistrySeeker.GetRootKey(rootKeyName))
                {
                    if (rootKey != null && rootKey.Name != rootKeyName)
                    {
                        string name = rootKeyName.Substring(rootKey.Name.Length + 1);
                        using (RegistryKey registryKey = rootKey.OpenReadonlySubKeySafe(name))
                        {
                            if (registryKey != null)
                            {
                                this.Seek(registryKey);
                            }
                            return;
                        }
                    }
                    this.Seek(rootKey);
                    return;
                }
            }
            this.Seek(null);
        }

        // Token: 0x06000312 RID: 786 RVA: 0x0001EC70 File Offset: 0x0001EC70
        private void Seek(RegistryKey rootKey)
        {
            if (rootKey == null)
            {
                using (List<RegistryKey>.Enumerator enumerator = RegistrySeeker.GetRootKeys().GetEnumerator())
                {
                    while (enumerator.MoveNext())
                    {
                        RegistryKey registryKey = enumerator.Current;
                        this.ProcessKey(registryKey, registryKey.Name);
                    }
                    return;
                }
            }
            this.Search(rootKey);
        }

        // Token: 0x06000313 RID: 787 RVA: 0x0001ECD4 File Offset: 0x0001ECD4
        private void Search(RegistryKey rootKey)
        {
            foreach (string text in rootKey.GetSubKeyNames())
            {
                RegistryKey key = rootKey.OpenReadonlySubKeySafe(text);
                this.ProcessKey(key, text);
            }
        }

        // Token: 0x06000314 RID: 788 RVA: 0x0001ED0C File Offset: 0x0001ED0C
        private void ProcessKey(RegistryKey key, string keyName)
        {
            if (key != null)
            {
                List<RegistrySeeker.RegValueData> list = new List<RegistrySeeker.RegValueData>();
                foreach (string name in key.GetValueNames())
                {
                    RegistryValueKind valueKind = key.GetValueKind(name);
                    object value = key.GetValue(name);
                    list.Add(RegistryKeyHelper.CreateRegValueData(name, valueKind, value));
                }
                this.AddMatch(keyName, RegistryKeyHelper.AddDefaultValue(list), key.SubKeyCount);
                return;
            }
            this.AddMatch(keyName, RegistryKeyHelper.GetDefaultValues(), 0);
        }

        // Token: 0x06000315 RID: 789 RVA: 0x0001ED80 File Offset: 0x0001ED80
        private void AddMatch(string key, RegistrySeeker.RegValueData[] values, int subkeycount)
        {
            RegistrySeeker.RegSeekerMatch item = new RegistrySeeker.RegSeekerMatch
            {
                Key = key,
                Data = values,
                HasSubKeys = (subkeycount > 0)
            };
            this._matches.Add(item);
        }

        // Token: 0x06000316 RID: 790 RVA: 0x0001EDB8 File Offset: 0x0001EDB8
        public static RegistryKey GetRootKey(string subkeyFullPath)
        {
            string[] array = subkeyFullPath.Split(new char[] { '\\' });
            RegistryKey result;
            try
            {
                string a = array[0];
                if (!(a == "HKEY_CLASSES_ROOT"))
                {
                    if (!(a == "HKEY_CURRENT_USER"))
                    {
                        if (!(a == "HKEY_LOCAL_MACHINE"))
                        {
                            if (!(a == "HKEY_USERS"))
                            {
                                if (!(a == "HKEY_CURRENT_CONFIG"))
                                {
                                    throw new Exception("Invalid rootkey, could not be found.");
                                }
                                result = RegistryKey.OpenBaseKey(RegistryHive.CurrentConfig, RegistryView.Registry64);
                            }
                            else
                            {
                                result = RegistryKey.OpenBaseKey(RegistryHive.Users, RegistryView.Registry64);
                            }
                        }
                        else
                        {
                            result = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                        }
                    }
                    else
                    {
                        result = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64);
                    }
                }
                else
                {
                    result = RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry64);
                }
            }
            catch (SystemException)
            {
                throw new Exception("Unable to open root registry key, you do not have the needed permissions.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        // Token: 0x06000317 RID: 791 RVA: 0x0001EEB0 File Offset: 0x0001EEB0
        public static List<RegistryKey> GetRootKeys()
        {
            List<RegistryKey> list = new List<RegistryKey>();
            try
            {
                list.Add(RegistryKey.OpenBaseKey(RegistryHive.ClassesRoot, RegistryView.Registry64));
                list.Add(RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64));
                list.Add(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64));
                list.Add(RegistryKey.OpenBaseKey(RegistryHive.Users, RegistryView.Registry64));
                list.Add(RegistryKey.OpenBaseKey(RegistryHive.CurrentConfig, RegistryView.Registry64));
            }
            catch (SystemException)
            {
                throw new Exception("Could not open root registry keys, you may not have the needed permission");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return list;
        }

        // Token: 0x04000275 RID: 629
        private readonly List<RegistrySeeker.RegSeekerMatch> _matches;

        // Token: 0x02000060 RID: 96
        [ProtoContract]
        public class RegSeekerMatch
        {
            // Token: 0x1700008B RID: 139
            // (get) Token: 0x06000318 RID: 792 RVA: 0x0001EF5C File Offset: 0x0001EF5C
            // (set) Token: 0x06000319 RID: 793 RVA: 0x0001EF64 File Offset: 0x0001EF64
            [ProtoMember(1)]
            public string Key { get; set; }

            // Token: 0x1700008C RID: 140
            // (get) Token: 0x0600031A RID: 794 RVA: 0x0001EF6D File Offset: 0x0001EF6D
            // (set) Token: 0x0600031B RID: 795 RVA: 0x0001EF75 File Offset: 0x0001EF75
            [ProtoMember(2)]
            public RegistrySeeker.RegValueData[] Data { get; set; }

            // Token: 0x1700008D RID: 141
            // (get) Token: 0x0600031C RID: 796 RVA: 0x0001EF7E File Offset: 0x0001EF7E
            // (set) Token: 0x0600031D RID: 797 RVA: 0x0001EF86 File Offset: 0x0001EF86
            [ProtoMember(3)]
            public bool HasSubKeys { get; set; }

            // Token: 0x0600031E RID: 798 RVA: 0x0001EF8F File Offset: 0x0001EF8F
            public override string ToString()
            {
                return string.Format("({0}:{1})", this.Key, this.Data);
            }
        }

        // Token: 0x02000061 RID: 97
        [ProtoContract]
        public class RegValueData
        {
            // Token: 0x1700008E RID: 142
            // (get) Token: 0x06000320 RID: 800 RVA: 0x0001EFA7 File Offset: 0x0001EFA7
            // (set) Token: 0x06000321 RID: 801 RVA: 0x0001EFAF File Offset: 0x0001EFAF
            [ProtoMember(1)]
            public string Name { get; set; }

            // Token: 0x1700008F RID: 143
            // (get) Token: 0x06000322 RID: 802 RVA: 0x0001EFB8 File Offset: 0x0001EFB8
            // (set) Token: 0x06000323 RID: 803 RVA: 0x0001EFC0 File Offset: 0x0001EFC0
            [ProtoMember(2)]
            public RegistryValueKind Kind { get; set; }

            // Token: 0x17000090 RID: 144
            // (get) Token: 0x06000324 RID: 804 RVA: 0x0001EFC9 File Offset: 0x0001EFC9
            // (set) Token: 0x06000325 RID: 805 RVA: 0x0001EFD1 File Offset: 0x0001EFD1
            [ProtoMember(3)]
            public byte[] Data { get; set; }
        }
    }
}