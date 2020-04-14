using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MonoFlat
{
	// Token: 0x02000017 RID: 23
	public class MonoFlat_Panel : ContainerControl
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x0001065C File Offset: 0x0000E85C
		public MonoFlat_Panel()
		{
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(ControlStyles.UserPaint, true);
			this.BackColor = Color.FromArgb(39, 51, 63);
			base.Size = new Size(187, 117);
			base.Padding = new Padding(5, 5, 5, 5);
			this.DoubleBuffered = true;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000106C8 File Offset: 0x0000E8C8
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			this.Shape = new GraphicsPath();
			this.Shape.AddArc(0, 0, 10, 10, 180f, 90f);
			this.Shape.AddArc(base.Width - 11, 0, 10, 10, -90f, 90f);
			this.Shape.AddArc(base.Width - 11, base.Height - 11, 10, 10, 0f, 90f);
			this.Shape.AddArc(0, base.Height - 11, 10, 10, 90f, 90f);
			this.Shape.CloseAllFigures();
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00010788 File Offset: 0x0000E988
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Bitmap bitmap = new Bitmap(base.Width, base.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.Clear(Color.FromArgb(32, 41, 50));
			graphics.FillPath(new SolidBrush(Color.FromArgb(39, 51, 63)), this.Shape);
			graphics.DrawPath(new Pen(Color.FromArgb(39, 51, 63)), this.Shape);
			graphics.Dispose();
			e.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);
			bitmap.Dispose();
		}

		// Token: 0x0400010E RID: 270
		private GraphicsPath Shape;
	}
}
