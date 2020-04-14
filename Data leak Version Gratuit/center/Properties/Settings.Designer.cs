using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace center.Properties
{
	// Token: 0x02000023 RID: 35
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00012234 File Offset: 0x00010434
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x040000FC RID: 252
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
