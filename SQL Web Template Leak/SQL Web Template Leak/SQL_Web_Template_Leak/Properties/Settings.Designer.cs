using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace SQL_Web_Template_Leak.Properties
{
	// Token: 0x02000020 RID: 32
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00011EEC File Offset: 0x000100EC
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x04000132 RID: 306
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
