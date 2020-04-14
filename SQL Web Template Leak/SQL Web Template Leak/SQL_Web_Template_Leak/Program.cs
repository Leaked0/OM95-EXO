using System;
using System.Windows.Forms;

namespace SQL_Web_Template_Leak
{
	// Token: 0x0200001E RID: 30
	internal static class Program
	{
		// Token: 0x06000114 RID: 276 RVA: 0x000116AA File Offset: 0x0000F8AA
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new login());
		}
	}
}
