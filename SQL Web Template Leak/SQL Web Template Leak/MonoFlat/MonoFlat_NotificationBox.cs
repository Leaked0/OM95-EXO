using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace MonoFlat
{
	// Token: 0x0200001C RID: 28
	public class MonoFlat_NotificationBox : Control
	{
		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00010FA4 File Offset: 0x0000F1A4
		// (set) Token: 0x06000105 RID: 261 RVA: 0x00010FBC File Offset: 0x0000F1BC
		public MonoFlat_NotificationBox.Type NotificationType
		{
			get
			{
				return this._NotificationType;
			}
			set
			{
				this._NotificationType = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00010FD0 File Offset: 0x0000F1D0
		// (set) Token: 0x06000107 RID: 263 RVA: 0x00010FE8 File Offset: 0x0000F1E8
		public bool RoundCorners
		{
			get
			{
				return this._RoundedCorners;
			}
			set
			{
				this._RoundedCorners = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00010FFC File Offset: 0x0000F1FC
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00011014 File Offset: 0x0000F214
		public bool ShowCloseButton
		{
			get
			{
				return this._ShowCloseButton;
			}
			set
			{
				this._ShowCloseButton = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00011028 File Offset: 0x0000F228
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00011040 File Offset: 0x0000F240
		public int BorderCurve
		{
			get
			{
				return this._BorderCurve;
			}
			set
			{
				this._BorderCurve = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00011054 File Offset: 0x0000F254
		// (set) Token: 0x0600010D RID: 269 RVA: 0x0001106C File Offset: 0x0000F26C
		public Image Image
		{
			get
			{
				return this._Image;
			}
			set
			{
				if (value == null)
				{
					this._ImageSize = Size.Empty;
				}
				else
				{
					this._ImageSize = value.Size;
				}
				this._Image = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600010E RID: 270 RVA: 0x000110B0 File Offset: 0x0000F2B0
		protected Size ImageSize
		{
			get
			{
				return this._ImageSize;
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000110C8 File Offset: 0x0000F2C8
		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
			if (e.X >= base.Width - 19 && e.X <= base.Width - 10 && e.Y > this.CloseCoordinates.Y && e.Y < this.CloseCoordinates.Y + 12)
			{
				this.IsOverClose = true;
			}
			else
			{
				this.IsOverClose = false;
			}
			base.Invalidate();
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00011150 File Offset: 0x0000F350
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			if (this._ShowCloseButton)
			{
				if (this.IsOverClose)
				{
					base.Dispose();
				}
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0001118C File Offset: 0x0000F38C
		internal GraphicsPath CreateRoundRect(Rectangle r, int curve)
		{
			try
			{
				this.CreateRoundPath = new GraphicsPath(FillMode.Winding);
				this.CreateRoundPath.AddArc(r.X, r.Y, curve, curve, 180f, 90f);
				this.CreateRoundPath.AddArc(r.Right - curve, r.Y, curve, curve, 270f, 90f);
				this.CreateRoundPath.AddArc(r.Right - curve, r.Bottom - curve, curve, curve, 0f, 90f);
				this.CreateRoundPath.AddArc(r.X, r.Bottom - curve, curve, curve, 90f, 90f);
				this.CreateRoundPath.CloseFigure();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + Environment.NewLine + Environment.NewLine + "Value must be either '1' or higher", "Invalid Integer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this._BorderCurve = 8;
				this.BorderCurve = 8;
			}
			return this.CreateRoundPath;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000112B0 File Offset: 0x0000F4B0
		public MonoFlat_NotificationBox()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.Font = new Font("Tahoma", 9f);
			this.MinimumSize = new Size(100, 40);
			this.RoundCorners = false;
			this.ShowCloseButton = true;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00011318 File Offset: 0x0000F518
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics graphics = e.Graphics;
			Color color = default(Color);
			Color color2 = default(Color);
			Color color3 = default(Color);
			Font font = new Font(this.Font.FontFamily, this.Font.Size, FontStyle.Bold);
			Rectangle rectangle = new Rectangle(0, 0, base.Width - 1, base.Height - 1);
			GraphicsPath graphicsPath = this.CreateRoundRect(rectangle, this._BorderCurve);
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
			graphics.Clear(base.Parent.BackColor);
			switch (this._NotificationType)
			{
			case MonoFlat_NotificationBox.Type.Notice:
				color2 = Color.FromArgb(111, 177, 199);
				color3 = Color.FromArgb(111, 177, 199);
				color = Color.White;
				break;
			case MonoFlat_NotificationBox.Type.Success:
				color2 = Color.FromArgb(91, 195, 162);
				color3 = Color.FromArgb(91, 195, 162);
				color = Color.White;
				break;
			case MonoFlat_NotificationBox.Type.Warning:
				color2 = Color.FromArgb(254, 209, 108);
				color3 = Color.FromArgb(254, 209, 108);
				color = Color.DimGray;
				break;
			case MonoFlat_NotificationBox.Type.Error:
				color2 = Color.FromArgb(217, 103, 93);
				color3 = Color.FromArgb(217, 103, 93);
				color = Color.White;
				break;
			}
			if (this._RoundedCorners)
			{
				graphics.FillPath(new SolidBrush(color2), graphicsPath);
				graphics.DrawPath(new Pen(color3), graphicsPath);
			}
			else
			{
				graphics.FillRectangle(new SolidBrush(color2), rectangle);
				graphics.DrawRectangle(new Pen(color3), rectangle);
			}
			switch (this._NotificationType)
			{
			case MonoFlat_NotificationBox.Type.Notice:
				this.NotificationText = "NOTICE";
				break;
			case MonoFlat_NotificationBox.Type.Success:
				this.NotificationText = "SUCCESS";
				break;
			case MonoFlat_NotificationBox.Type.Warning:
				this.NotificationText = "WARNING";
				break;
			case MonoFlat_NotificationBox.Type.Error:
				this.NotificationText = "ERROR";
				break;
			}
			if (this.Image == null)
			{
				graphics.DrawString(this.NotificationText, font, new SolidBrush(color), new Point(10, 5));
				graphics.DrawString(this.Text, this.Font, new SolidBrush(color), new Rectangle(10, 21, base.Width - 17, base.Height - 5));
			}
			else
			{
				graphics.DrawImage(this._Image, 12, 4, 16, 16);
				graphics.DrawString(this.NotificationText, font, new SolidBrush(color), new Point(30, 5));
				graphics.DrawString(this.Text, this.Font, new SolidBrush(color), new Rectangle(10, 21, base.Width - 17, base.Height - 5));
			}
			this.CloseCoordinates = new Point(base.Width - 26, 4);
			if (this._ShowCloseButton)
			{
				graphics.DrawString("r", new Font("Marlett", 7f, FontStyle.Regular), new SolidBrush(Color.FromArgb(130, 130, 130)), new Rectangle(base.Width - 20, 10, base.Width, base.Height), new StringFormat
				{
					Alignment = StringAlignment.Near,
					LineAlignment = StringAlignment.Near
				});
			}
			graphicsPath.Dispose();
		}

		// Token: 0x04000121 RID: 289
		private Point CloseCoordinates;

		// Token: 0x04000122 RID: 290
		private bool IsOverClose;

		// Token: 0x04000123 RID: 291
		private int _BorderCurve = 8;

		// Token: 0x04000124 RID: 292
		private GraphicsPath CreateRoundPath;

		// Token: 0x04000125 RID: 293
		private string NotificationText = null;

		// Token: 0x04000126 RID: 294
		private MonoFlat_NotificationBox.Type _NotificationType;

		// Token: 0x04000127 RID: 295
		private bool _RoundedCorners;

		// Token: 0x04000128 RID: 296
		private bool _ShowCloseButton;

		// Token: 0x04000129 RID: 297
		private Image _Image;

		// Token: 0x0400012A RID: 298
		private Size _ImageSize;

		// Token: 0x0200001D RID: 29
		public enum Type
		{
			// Token: 0x0400012C RID: 300
			Notice,
			// Token: 0x0400012D RID: 301
			Success,
			// Token: 0x0400012E RID: 302
			Warning,
			// Token: 0x0400012F RID: 303
			Error
		}
	}
}
