using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace VenomRAT_HVNC.Server.Properties
{
	// Token: 0x02000039 RID: 57
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0001B73C File Offset: 0x0001B73C
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600021E RID: 542 RVA: 0x0001B743 File Offset: 0x0001B743
		// (set) Token: 0x0600021F RID: 543 RVA: 0x0001B755 File Offset: 0x0001B755
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Ports
		{
			get
			{
				return (string)this["Ports"];
			}
			set
			{
				this["Ports"] = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000220 RID: 544 RVA: 0x0001B763 File Offset: 0x0001B763
		// (set) Token: 0x06000221 RID: 545 RVA: 0x0001B775 File Offset: 0x0001B775
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Filename
		{
			get
			{
				return (string)this["Filename"];
			}
			set
			{
				this["Filename"] = value;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0001B783 File Offset: 0x0001B783
		// (set) Token: 0x06000223 RID: 547 RVA: 0x0001B795 File Offset: 0x0001B795
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool Notification
		{
			get
			{
				return (bool)this["Notification"];
			}
			set
			{
				this["Notification"] = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0001B7A8 File Offset: 0x0001B7A8
		// (set) Token: 0x06000225 RID: 549 RVA: 0x0001B7BA File Offset: 0x0001B7BA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Paste_bin
		{
			get
			{
				return (string)this["Paste_bin"];
			}
			set
			{
				this["Paste_bin"] = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000226 RID: 550 RVA: 0x0001B7C8 File Offset: 0x0001B7C8
		// (set) Token: 0x06000227 RID: 551 RVA: 0x0001B7DA File Offset: 0x0001B7DA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string IP
		{
			get
			{
				return (string)this["IP"];
			}
			set
			{
				this["IP"] = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000228 RID: 552 RVA: 0x0001B7E8 File Offset: 0x0001B7E8
		// (set) Token: 0x06000229 RID: 553 RVA: 0x0001B7FA File Offset: 0x0001B7FA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string ProductName
		{
			get
			{
				return (string)this["ProductName"];
			}
			set
			{
				this["ProductName"] = value;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600022A RID: 554 RVA: 0x0001B808 File Offset: 0x0001B808
		// (set) Token: 0x0600022B RID: 555 RVA: 0x0001B81A File Offset: 0x0001B81A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string txtDescription
		{
			get
			{
				return (string)this["txtDescription"];
			}
			set
			{
				this["txtDescription"] = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600022C RID: 556 RVA: 0x0001B828 File Offset: 0x0001B828
		// (set) Token: 0x0600022D RID: 557 RVA: 0x0001B83A File Offset: 0x0001B83A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string txtCompany
		{
			get
			{
				return (string)this["txtCompany"];
			}
			set
			{
				this["txtCompany"] = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600022E RID: 558 RVA: 0x0001B848 File Offset: 0x0001B848
		// (set) Token: 0x0600022F RID: 559 RVA: 0x0001B85A File Offset: 0x0001B85A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string txtCopyright
		{
			get
			{
				return (string)this["txtCopyright"];
			}
			set
			{
				this["txtCopyright"] = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000230 RID: 560 RVA: 0x0001B868 File Offset: 0x0001B868
		// (set) Token: 0x06000231 RID: 561 RVA: 0x0001B87A File Offset: 0x0001B87A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string txtTrademarks
		{
			get
			{
				return (string)this["txtTrademarks"];
			}
			set
			{
				this["txtTrademarks"] = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0001B888 File Offset: 0x0001B888
		// (set) Token: 0x06000233 RID: 563 RVA: 0x0001B89A File Offset: 0x0001B89A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string txtOriginalFilename
		{
			get
			{
				return (string)this["txtOriginalFilename"];
			}
			set
			{
				this["txtOriginalFilename"] = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000234 RID: 564 RVA: 0x0001B8A8 File Offset: 0x0001B8A8
		// (set) Token: 0x06000235 RID: 565 RVA: 0x0001B8BA File Offset: 0x0001B8BA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0.0.0.0")]
		public string txtProductVersion
		{
			get
			{
				return (string)this["txtProductVersion"];
			}
			set
			{
				this["txtProductVersion"] = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000236 RID: 566 RVA: 0x0001B8C8 File Offset: 0x0001B8C8
		// (set) Token: 0x06000237 RID: 567 RVA: 0x0001B8DA File Offset: 0x0001B8DA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0.0.0.0")]
		public string txtFileVersion
		{
			get
			{
				return (string)this["txtFileVersion"];
			}
			set
			{
				this["txtFileVersion"] = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000238 RID: 568 RVA: 0x0001B8E8 File Offset: 0x0001B8E8
		// (set) Token: 0x06000239 RID: 569 RVA: 0x0001B8FA File Offset: 0x0001B8FA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string txtBlocked
		{
			get
			{
				return (string)this["txtBlocked"];
			}
			set
			{
				this["txtBlocked"] = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600023A RID: 570 RVA: 0x0001B908 File Offset: 0x0001B908
		// (set) Token: 0x0600023B RID: 571 RVA: 0x0001B91A File Offset: 0x0001B91A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("Default")]
		public string Group
		{
			get
			{
				return (string)this["Group"];
			}
			set
			{
				this["Group"] = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600023C RID: 572 RVA: 0x0001B928 File Offset: 0x0001B928
		// (set) Token: 0x0600023D RID: 573 RVA: 0x0001B93A File Offset: 0x0001B93A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool DingDing
		{
			get
			{
				return (bool)this["DingDing"];
			}
			set
			{
				this["DingDing"] = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600023E RID: 574 RVA: 0x0001B94D File Offset: 0x0001B94D
		// (set) Token: 0x0600023F RID: 575 RVA: 0x0001B95F File Offset: 0x0001B95F
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string WebHook
		{
			get
			{
				return (string)this["WebHook"];
			}
			set
			{
				this["WebHook"] = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000240 RID: 576 RVA: 0x0001B96D File Offset: 0x0001B96D
		// (set) Token: 0x06000241 RID: 577 RVA: 0x0001B97F File Offset: 0x0001B97F
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Secret
		{
			get
			{
				return (string)this["Secret"];
			}
			set
			{
				this["Secret"] = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000242 RID: 578 RVA: 0x0001B98D File Offset: 0x0001B98D
		// (set) Token: 0x06000243 RID: 579 RVA: 0x0001B99F File Offset: 0x0001B99F
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("3128")]
		public decimal ReverseProxyPort
		{
			get
			{
				return (decimal)this["ReverseProxyPort"];
			}
			set
			{
				this["ReverseProxyPort"] = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0001B9B2 File Offset: 0x0001B9B2
		// (set) Token: 0x06000245 RID: 581 RVA: 0x0001B9C4 File Offset: 0x0001B9C4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("VenomRAT_HVNCMutex_VenomRAT_HVNC")]
		public string Mutex
		{
			get
			{
				return (string)this["Mutex"];
			}
			set
			{
				this["Mutex"] = value;
			}
		}

		// Token: 0x040001F7 RID: 503
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
