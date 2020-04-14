using System;
using System.Windows.Forms;

namespace center
{
	// Token: 0x02000021 RID: 33
	internal static class Program
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x00012140 File Offset: 0x00010340
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
