using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MonoFlat
{
	// Token: 0x0200000B RID: 11
	public class MonoFlat_SocialButton : Control
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000EE88 File Offset: 0x0000D088
		// (set) Token: 0x06000093 RID: 147 RVA: 0x0000EEA0 File Offset: 0x0000D0A0
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

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000094 RID: 148 RVA: 0x0000EEE4 File Offset: 0x0000D0E4
		protected Size ImageSize
		{
			get
			{
				return this._ImageSize;
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000EEFC File Offset: 0x0000D0FC
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			base.Size = new Size(54, 54);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000EF17 File Offset: 0x0000D117
		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			this.EllipseColor = Color.FromArgb(181, 41, 42);
			this.Refresh();
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000EF3D File Offset: 0x0000D13D
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			this.EllipseColor = Color.FromArgb(66, 76, 85);
			this.Refresh();
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000EF60 File Offset: 0x0000D160
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			this.EllipseColor = Color.FromArgb(153, 34, 34);
			base.Focus();
			this.Refresh();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000EF8D File Offset: 0x0000D18D
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			this.EllipseColor = Color.FromArgb(181, 41, 42);
			this.Refresh();
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000EFB4 File Offset: 0x0000D1B4
		private static PointF ImageLocation(StringFormat SF, SizeF Area, SizeF ImageArea)
		{
			PointF result = default(PointF);
			StringAlignment stringAlignment = SF.Alignment;
			if (stringAlignment == StringAlignment.Center)
			{
				result.X = (Area.Width - ImageArea.Width) / 2f;
			}
			stringAlignment = SF.LineAlignment;
			if (stringAlignment == StringAlignment.Center)
			{
				result.Y = (Area.Height - ImageArea.Height) / 2f;
			}
			return result;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000F02C File Offset: 0x0000D22C
		private StringFormat GetStringFormat(ContentAlignment _ContentAlignment)
		{
			StringFormat stringFormat = new StringFormat();
			if (_ContentAlignment == ContentAlignment.MiddleCenter)
			{
				stringFormat.LineAlignment = StringAlignment.Center;
				stringFormat.Alignment = StringAlignment.Center;
			}
			return stringFormat;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000F060 File Offset: 0x0000D260
		public MonoFlat_SocialButton()
		{
			this.DoubleBuffered = true;
			this.EllipseColor = Color.FromArgb(66, 76, 85);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000F084 File Offset: 0x0000D284
		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics graphics = e.Graphics;
			graphics.Clear(base.Parent.BackColor);
			graphics.SmoothingMode = SmoothingMode.HighQuality;
			PointF pointF = MonoFlat_SocialButton.ImageLocation(this.GetStringFormat(ContentAlignment.MiddleCenter), base.Size, this.ImageSize);
			graphics.FillEllipse(new SolidBrush(this.EllipseColor), new Rectangle(0, 0, 53, 53));
			if (this.Image != null)
			{
				graphics.DrawImage(this._Image, (int)pointF.X, (int)pointF.Y, this.ImageSize.Width, this.ImageSize.Height);
			}
		}

		// Token: 0x040000EE RID: 238
		private Image _Image;

		// Token: 0x040000EF RID: 239
		private Size _ImageSize;

		// Token: 0x040000F0 RID: 240
		private Color EllipseColor;
	}
}
