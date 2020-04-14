using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonoFlat
{
	// Token: 0x0200000C RID: 12
	public class MonoFlat_Label : Label
	{
		// Token: 0x0600009E RID: 158 RVA: 0x0000F13C File Offset: 0x0000D33C
		public MonoFlat_Label()
		{
			this.Font = new Font("Segoe UI", 9f);
			this.ForeColor = Color.FromArgb(116, 125, 132);
			this.BackColor = Color.Transparent;
		}
	}
}
