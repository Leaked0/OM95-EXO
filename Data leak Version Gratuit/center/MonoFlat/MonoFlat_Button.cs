using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MonoFlat
{
	// Token: 0x0200000A RID: 10
	public class MonoFlat_Button : Control
	{
		// Token: 0x06000080 RID: 128 RVA: 0x0000E650 File Offset: 0x0000C850
		private static PointF ImageLocation(StringFormat SF, SizeF Area, SizeF ImageArea)
		{
			PointF result = default(PointF);
			switch (SF.Alignment)
			{
			case StringAlignment.Near:
				result.X = 2f;
				break;
			case StringAlignment.Center:
				result.X = (Area.Width - ImageArea.Width) / 2f;
				break;
			case StringAlignment.Far:
				result.X = Area.Width - ImageArea.Width - 2f;
				break;
			}
			switch (SF.LineAlignment)
			{
			case StringAlignment.Near:
				result.Y = 2f;
				break;
			case StringAlignment.Center:
				result.Y = (Area.Height - ImageArea.Height) / 2f;
				break;
			case StringAlignment.Far:
				result.Y = Area.Height - ImageArea.Height - 2f;
				break;
			}
			return result;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000E740 File Offset: 0x0000C940
		private StringFormat GetStringFormat(ContentAlignment _ContentAlignment)
		{
			StringFormat stringFormat = new StringFormat();
			if (_ContentAlignment <= ContentAlignment.MiddleCenter)
			{
				switch (_ContentAlignment)
				{
				case ContentAlignment.TopLeft:
					stringFormat.LineAlignment = StringAlignment.Near;
					stringFormat.Alignment = StringAlignment.Near;
					break;
				case ContentAlignment.TopCenter:
					stringFormat.LineAlignment = StringAlignment.Near;
					stringFormat.Alignment = StringAlignment.Center;
					break;
				case (ContentAlignment)3:
					break;
				case ContentAlignment.TopRight:
					stringFormat.LineAlignment = StringAlignment.Near;
					stringFormat.Alignment = StringAlignment.Far;
					break;
				default:
					if (_ContentAlignment != ContentAlignment.MiddleLeft)
					{
						if (_ContentAlignment == ContentAlignment.MiddleCenter)
						{
							stringFormat.LineAlignment = StringAlignment.Center;
							stringFormat.Alignment = StringAlignment.Center;
						}
					}
					else
					{
						stringFormat.LineAlignment = StringAlignment.Center;
						stringFormat.Alignment = StringAlignment.Near;
					}
					break;
				}
			}
			else if (_ContentAlignment <= ContentAlignment.BottomLeft)
			{
				if (_ContentAlignment != ContentAlignment.MiddleRight)
				{
					if (_ContentAlignment == ContentAlignment.BottomLeft)
					{
						stringFormat.LineAlignment = StringAlignment.Far;
						stringFormat.Alignment = StringAlignment.Near;
					}
				}
				else
				{
					stringFormat.LineAlignment = StringAlignment.Center;
					stringFormat.Alignment = StringAlignment.Far;
				}
			}
			else if (_ContentAlignment != ContentAlignment.BottomCenter)
			{
				if (_ContentAlignment == ContentAlignment.BottomRight)
				{
					stringFormat.LineAlignment = StringAlignment.Far;
					stringFormat.Alignment = StringAlignment.Far;
				}
			}
			else
			{
				stringFormat.LineAlignment = StringAlignment.Far;
				stringFormat.Alignment = StringAlignment.Center;
			}
			return stringFormat;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0000E864 File Offset: 0x0000CA64
		// (set) Token: 0x06000083 RID: 131 RVA: 0x0000E87C File Offset: 0x0000CA7C
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

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000084 RID: 132 RVA: 0x0000E8C0 File Offset: 0x0000CAC0
		protected Size ImageSize
		{
			get
			{
				return this._ImageSize;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000085 RID: 133 RVA: 0x0000E8D8 File Offset: 0x0000CAD8
		// (set) Token: 0x06000086 RID: 134 RVA: 0x0000E8F0 File Offset: 0x0000CAF0
		public ContentAlignment ImageAlign
		{
			get
			{
				return this._ImageAlign;
			}
			set
			{
				this._ImageAlign = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000087 RID: 135 RVA: 0x0000E904 File Offset: 0x0000CB04
		// (set) Token: 0x06000088 RID: 136 RVA: 0x0000E91C File Offset: 0x0000CB1C
		public StringAlignment TextAlignment
		{
			get
			{
				return this._TextAlignment;
			}
			set
			{
				this._TextAlignment = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000089 RID: 137 RVA: 0x0000E930 File Offset: 0x0000CB30
		// (set) Token: 0x0600008A RID: 138 RVA: 0x0000E948 File Offset: 0x0000CB48
		public override Color ForeColor
		{
			get
			{
				return this._TextColor;
			}
			set
			{
				this._TextColor = value;
				base.Invalidate();
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000E959 File Offset: 0x0000CB59
		protected override void OnMouseUp(MouseEventArgs e)
		{
			this.MouseState = 0;
			base.Invalidate();
			base.OnMouseUp(e);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000E972 File Offset: 0x0000CB72
		protected override void OnMouseDown(MouseEventArgs e)
		{
			this.MouseState = 1;
			base.Focus();
			base.Invalidate();
			base.OnMouseDown(e);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000E992 File Offset: 0x0000CB92
		protected override void OnMouseLeave(EventArgs e)
		{
			this.MouseState = 0;
			base.Invalidate();
			base.OnMouseLeave(e);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000E9AB File Offset: 0x0000CBAB
		protected override void OnTextChanged(EventArgs e)
		{
			base.Invalidate();
			base.OnTextChanged(e);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000E9C0 File Offset: 0x0000CBC0
		public MonoFlat_Button()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.BackColor = Color.Transparent;
			this.DoubleBuffered = true;
			this.Font = new Font("Segoe UI", 12f);
			this.ForeColor = Color.FromArgb(255, 255, 255);
			base.Size = new Size(146, 41);
			this._TextAlignment = StringAlignment.Center;
			this.P1 = new Pen(Color.FromArgb(181, 41, 42));
			this.P3 = new Pen(Color.FromArgb(165, 37, 37));
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000EA84 File Offset: 0x0000CC84
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			if (base.Width > 0 && base.Height > 0)
			{
				this.Shape = new GraphicsPath();
				this.R1 = new Rectangle(0, 0, base.Width, base.Height);
				this.InactiveGB = new LinearGradientBrush(new Rectangle(0, 0, base.Width, base.Height), Color.FromArgb(181, 41, 42), Color.FromArgb(181, 41, 42), 90f);
				this.PressedGB = new LinearGradientBrush(new Rectangle(0, 0, base.Width, base.Height), Color.FromArgb(165, 37, 37), Color.FromArgb(165, 37, 37), 90f);
			}
			this.Shape.AddArc(0, 0, 10, 10, 180f, 90f);
			this.Shape.AddArc(base.Width - 11, 0, 10, 10, -90f, 90f);
			this.Shape.AddArc(base.Width - 11, base.Height - 11, 10, 10, 0f, 90f);
			this.Shape.AddArc(0, base.Height - 11, 10, 10, 90f, 90f);
			this.Shape.CloseAllFigures();
			base.Invalidate();
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000EC04 File Offset: 0x0000CE04
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			PointF pointF = MonoFlat_Button.ImageLocation(this.GetStringFormat(this.ImageAlign), base.Size, this.ImageSize);
			switch (this.MouseState)
			{
			case 0:
				graphics.FillPath(this.InactiveGB, this.Shape);
				graphics.DrawPath(this.P1, this.Shape);
				if (this.Image == null)
				{
					graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), this.R1, new StringFormat
					{
						Alignment = this._TextAlignment,
						LineAlignment = StringAlignment.Center
					});
				}
				else
				{
					graphics.DrawImage(this._Image, pointF.X, pointF.Y, (float)this.ImageSize.Width, (float)this.ImageSize.Height);
					graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), this.R1, new StringFormat
					{
						Alignment = this._TextAlignment,
						LineAlignment = StringAlignment.Center
					});
				}
				break;
			case 1:
				graphics.FillPath(this.PressedGB, this.Shape);
				graphics.DrawPath(this.P3, this.Shape);
				if (this.Image == null)
				{
					graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), this.R1, new StringFormat
					{
						Alignment = this._TextAlignment,
						LineAlignment = StringAlignment.Center
					});
				}
				else
				{
					graphics.DrawImage(this._Image, pointF.X, pointF.Y, (float)this.ImageSize.Width, (float)this.ImageSize.Height);
					graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), this.R1, new StringFormat
					{
						Alignment = this._TextAlignment,
						LineAlignment = StringAlignment.Center
					});
				}
				break;
			}
			base.OnPaint(e);
		}

		// Token: 0x040000E2 RID: 226
		private int MouseState;

		// Token: 0x040000E3 RID: 227
		private GraphicsPath Shape;

		// Token: 0x040000E4 RID: 228
		private LinearGradientBrush InactiveGB;

		// Token: 0x040000E5 RID: 229
		private LinearGradientBrush PressedGB;

		// Token: 0x040000E6 RID: 230
		private Rectangle R1;

		// Token: 0x040000E7 RID: 231
		private Pen P1;

		// Token: 0x040000E8 RID: 232
		private Pen P3;

		// Token: 0x040000E9 RID: 233
		private Image _Image;

		// Token: 0x040000EA RID: 234
		private Size _ImageSize;

		// Token: 0x040000EB RID: 235
		private StringAlignment _TextAlignment = StringAlignment.Center;

		// Token: 0x040000EC RID: 236
		private Color _TextColor;

		// Token: 0x040000ED RID: 237
		private ContentAlignment _ImageAlign = ContentAlignment.MiddleLeft;
	}
}
