using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonoFlat
{
	// Token: 0x0200000D RID: 13
	public class MonoFlat_LinkLabel : LinkLabel
	{
		// Token: 0x0600009F RID: 159 RVA: 0x0000F18C File Offset: 0x0000D38C
		public MonoFlat_LinkLabel()
		{
			this.Font = new Font("Segoe UI", 9f, FontStyle.Regular);
			this.BackColor = Color.Transparent;
			base.LinkColor = Color.FromArgb(181, 41, 42);
			base.ActiveLinkColor = Color.FromArgb(153, 34, 34);
			base.VisitedLinkColor = Color.FromArgb(181, 41, 42);
			base.LinkBehavior = LinkBehavior.NeverUnderline;
		}
	}
}
