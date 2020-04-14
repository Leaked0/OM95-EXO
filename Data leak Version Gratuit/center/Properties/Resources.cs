using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace center.Properties
{
	// Token: 0x02000022 RID: 34
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[CompilerGenerated]
	[DebuggerNonUserCode]
	internal class Resources
	{
		// Token: 0x060000F1 RID: 241 RVA: 0x0001215B File Offset: 0x0001035B
		internal Resources()
		{
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00012168 File Offset: 0x00010368
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("center.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x000121B4 File Offset: 0x000103B4
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x000121CB File Offset: 0x000103CB
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x000121D4 File Offset: 0x000103D4
		internal static Bitmap Screenshot_1
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("Screenshot_1", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00012204 File Offset: 0x00010404
		internal static Bitmap server__datacenter__database__storage_512
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("server__datacenter__database__storage-512", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x040000FA RID: 250
		private static ResourceManager resourceMan;

		// Token: 0x040000FB RID: 251
		private static CultureInfo resourceCulture;
	}
}
