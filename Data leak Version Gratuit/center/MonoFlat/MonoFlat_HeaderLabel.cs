using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonoFlat
{
	// Token: 0x0200000E RID: 14
	public class MonoFlat_HeaderLabel : Label
	{
		// Token: 0x060000A0 RID: 160 RVA: 0x0000F20C File Offset: 0x0000D40C
		public MonoFlat_HeaderLabel()
		{
			this.Font = new Font("Segoe UI", 11f, FontStyle.Bold);
			this.ForeColor = Color.FromArgb(255, 255, 255);
			this.BackColor = Color.Transparent;
		}
	}
}
