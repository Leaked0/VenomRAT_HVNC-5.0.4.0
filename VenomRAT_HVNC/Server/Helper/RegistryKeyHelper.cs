using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Win32;

namespace VenomRAT_HVNC.Server.Helper
{
    // Token: 0x0200005D RID: 93
    public static class RegistryKeyHelper
    {
        // Token: 0x06000303 RID: 771 RVA: 0x0001E940 File Offset: 0x0001E940
        public static bool AddRegistryKeyValue(RegistryHive hive, string path, string name, string value, bool addQuotes = false)
        {
            bool result;
            try
            {
                using (RegistryKey registryKey = RegistryKey.OpenBaseKey(hive, RegistryView.Registry64).OpenWritableSubKeySafe(path))
                {
                    if (registryKey == null)
                    {
                        result = false;
                    }
                    else
                    {
                        if (addQuotes && !value.StartsWith("\"") && !value.EndsWith("\""))
                        {
                            value = "\"" + value + "\"";
                        }
                        registryKey.SetValue(name, value);
                        result = true;
                    }
                }
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        // Token: 0x06000304 RID: 772 RVA: 0x0001E9D0 File Offset: 0x0001E9D0
        public static RegistryKey OpenReadonlySubKey(RegistryHive hive, string path)
        {
            RegistryKey result;
            try
            {
                result = RegistryKey.OpenBaseKey(hive, RegistryView.Registry64).OpenSubKey(path, false);
            }
            catch
            {
                result = null;
            }
            return result;
        }

        // Token: 0x06000305 RID: 773 RVA: 0x0001EA08 File Offset: 0x0001EA08
        public static bool DeleteRegistryKeyValue(RegistryHive hive, string path, string name)
        {
            bool result;
            try
            {
                using (RegistryKey registryKey = RegistryKey.OpenBaseKey(hive, RegistryView.Registry64).OpenWritableSubKeySafe(path))
                {
                    if (registryKey == null)
                    {
                        result = false;
                    }
                    else
                    {
                        registryKey.DeleteValue(name, true);
                        result = true;
                    }
                }
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        // Token: 0x06000306 RID: 774 RVA: 0x0001E1FC File Offset: 0x0001E1FC
        public static bool IsDefaultValue(string valueName)
        {
            return string.IsNullOrEmpty(valueName);
        }

        // Token: 0x06000307 RID: 775 RVA: 0x0001EA68 File Offset: 0x0001EA68
        public static RegistrySeeker.RegValueData[] AddDefaultValue(List<RegistrySeeker.RegValueData> values)
        {
            if (!values.Any((RegistrySeeker.RegValueData value) => RegistryKeyHelper.IsDefaultValue(value.Name)))
            {
                values.Add(RegistryKeyHelper.GetDefaultValue());
            }
            return values.ToArray();
        }

        // Token: 0x06000308 RID: 776 RVA: 0x0001EAA2 File Offset: 0x0001EAA2
        public static RegistrySeeker.RegValueData[] GetDefaultValues()
        {
            return new RegistrySeeker.RegValueData[] { RegistryKeyHelper.GetDefaultValue() };
        }

        // Token: 0x06000309 RID: 777 RVA: 0x0001EAB4 File Offset: 0x0001EAB4
        public static RegistrySeeker.RegValueData CreateRegValueData(string name, RegistryValueKind kind, object value = null)
        {
            RegistrySeeker.RegValueData regValueData = new RegistrySeeker.RegValueData
            {
                Name = name,
                Kind = kind
            };
            if (value == null)
            {
                regValueData.Data = new byte[0];
            }
            else
            {
                switch (regValueData.Kind)
                {
                    case RegistryValueKind.String:
                    case RegistryValueKind.ExpandString:
                        regValueData.Data = ByteConverter.GetBytes((string)value);
                        break;

                    case RegistryValueKind.Binary:
                        regValueData.Data = (byte[])value;
                        break;

                    case RegistryValueKind.DWord:
                        regValueData.Data = ByteConverter.GetBytes((uint)((int)value));
                        break;

                    case RegistryValueKind.MultiString:
                        regValueData.Data = ByteConverter.GetBytes((string[])value);
                        break;

                    case RegistryValueKind.QWord:
                        regValueData.Data = ByteConverter.GetBytes((ulong)((long)value));
                        break;
                }
            }
            return regValueData;
        }

        // Token: 0x0600030A RID: 778 RVA: 0x0001EB7F File Offset: 0x0001EB7F
        private static RegistrySeeker.RegValueData GetDefaultValue()
        {
            return RegistryKeyHelper.CreateRegValueData(RegistryKeyHelper.DEFAULT_VALUE, RegistryValueKind.String, null);
        }

        // Token: 0x04000272 RID: 626
        private static string DEFAULT_VALUE = string.Empty;
    }
}