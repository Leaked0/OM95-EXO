using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonoFlat
{
	// Token: 0x02000018 RID: 24
	public class MonoFlat_Separator : Control
	{
		// Token: 0x060000EA RID: 234 RVA: 0x00010832 File Offset: 0x0000EA32
		public MonoFlat_Separator()
		{
			base.SetStyle(ControlStyles.ResizeRedraw, true);
			base.Size = (Size)new Point(120, 10);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0001085C File Offset: 0x0000EA5C
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			e.Graphics.DrawLine(new Pen(Color.FromArgb(45, 57, 68)), 0, 5, base.Width, 5);
		}
	}
}
