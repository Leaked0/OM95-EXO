using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonoFlat
{
	// Token: 0x02000008 RID: 8
	internal class MonoFlat_ControlBox : Control
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0000DFC4 File Offset: 0x0000C1C4
		// (set) Token: 0x06000073 RID: 115 RVA: 0x0000DFDC File Offset: 0x0000C1DC
		public bool EnableMaximizeButton
		{
			get
			{
				return this._EnableMaximize;
			}
			set
			{
				this._EnableMaximize = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000074 RID: 116 RVA: 0x0000DFF0 File Offset: 0x0000C1F0
		// (set) Token: 0x06000075 RID: 117 RVA: 0x0000E008 File Offset: 0x0000C208
		public bool EnableMinimizeButton
		{
			get
			{
				return this._EnableMinimize;
			}
			set
			{
				this._EnableMinimize = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000E01C File Offset: 0x0000C21C
		// (set) Token: 0x06000077 RID: 119 RVA: 0x0000E034 File Offset: 0x0000C234
		public bool EnableHoverHighlight
		{
			get
			{
				return this._EnableHoverHighlight;
			}
			set
			{
				this._EnableHoverHighlight = value;
				base.Invalidate();
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000E045 File Offset: 0x0000C245
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			base.Size = new Size(100, 25);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000E060 File Offset: 0x0000C260
		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
			int x = e.Location.X;
			int y = e.Location.Y;
			if (y > 0 && y < base.Height - 2)
			{
				if (x > 0 && x < 34)
				{
					this.ButtonHState = MonoFlat_ControlBox.ButtonHoverState.Minimize;
				}
				else if (x > 33 && x < 65)
				{
					this.ButtonHState = MonoFlat_ControlBox.ButtonHoverState.Maximize;
				}
				else if (x > 64 && x < base.Width)
				{
					this.ButtonHState = MonoFlat_ControlBox.ButtonHoverState.Close;
				}
				else
				{
					this.ButtonHState = MonoFlat_ControlBox.ButtonHoverState.None;
				}
			}
			else
			{
				this.ButtonHState = MonoFlat_ControlBox.ButtonHoverState.None;
			}
			base.Invalidate();
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000E130 File Offset: 0x0000C330
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			switch (this.ButtonHState)
			{
			case MonoFlat_ControlBox.ButtonHoverState.Minimize:
				if (this._EnableMinimize)
				{
					base.Parent.FindForm().WindowState = FormWindowState.Minimized;
				}
				break;
			case MonoFlat_ControlBox.ButtonHoverState.Maximize:
				if (this._EnableMaximize)
				{
					if (base.Parent.FindForm().WindowState == FormWindowState.Normal)
					{
						base.Parent.FindForm().WindowState = FormWindowState.Maximized;
					}
					else
					{
						base.Parent.FindForm().WindowState = FormWindowState.Normal;
					}
				}
				break;
			case MonoFlat_ControlBox.ButtonHoverState.Close:
				base.Parent.FindForm().Close();
				break;
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000E1EF File Offset: 0x0000C3EF
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			this.ButtonHState = MonoFlat_ControlBox.ButtonHoverState.None;
			base.Invalidate();
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000E208 File Offset: 0x0000C408
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			base.Focus();
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000E21A File Offset: 0x0000C41A
		public MonoFlat_ControlBox()
		{
			this.DoubleBuffered = true;
			this.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000E254 File Offset: 0x0000C454
		protected override void OnCreateControl()
		{
			base.OnCreateControl();
			try
			{
				base.Location = new Point(base.Parent.Width - 112, 15);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000E2A0 File Offset: 0x0000C4A0
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics graphics = e.Graphics;
			graphics.Clear(Color.FromArgb(181, 41, 42));
			if (this._EnableHoverHighlight)
			{
				switch (this.ButtonHState)
				{
				case MonoFlat_ControlBox.ButtonHoverState.Minimize:
					if (this._EnableMinimize)
					{
						graphics.FillRectangle(new SolidBrush(Color.FromArgb(156, 35, 35)), new Rectangle(3, 0, 30, base.Height));
					}
					break;
				case MonoFlat_ControlBox.ButtonHoverState.Maximize:
					if (this._EnableMaximize)
					{
						graphics.FillRectangle(new SolidBrush(Color.FromArgb(156, 35, 35)), new Rectangle(35, 0, 30, base.Height));
					}
					break;
				case MonoFlat_ControlBox.ButtonHoverState.Close:
					graphics.FillRectangle(new SolidBrush(Color.FromArgb(156, 35, 35)), new Rectangle(66, 0, 35, base.Height));
					break;
				case MonoFlat_ControlBox.ButtonHoverState.None:
					graphics.Clear(Color.FromArgb(181, 41, 42));
					break;
				}
			}
			graphics.DrawString("r", new Font("Marlett", 12f), new SolidBrush(Color.FromArgb(255, 254, 255)), new Point(base.Width - 16, 8), new StringFormat
			{
				Alignment = StringAlignment.Center
			});
			switch (base.Parent.FindForm().WindowState)
			{
			case FormWindowState.Normal:
				if (this._EnableMaximize)
				{
					graphics.DrawString("1", new Font("Marlett", 12f), new SolidBrush(Color.FromArgb(255, 254, 255)), new Point(51, 7), new StringFormat
					{
						Alignment = StringAlignment.Center
					});
				}
				else
				{
					graphics.DrawString("1", new Font("Marlett", 12f), new SolidBrush(Color.LightGray), new Point(51, 7), new StringFormat
					{
						Alignment = StringAlignment.Center
					});
				}
				break;
			case FormWindowState.Maximized:
				if (this._EnableMaximize)
				{
					graphics.DrawString("2", new Font("Marlett", 12f), new SolidBrush(Color.FromArgb(255, 254, 255)), new Point(51, 7), new StringFormat
					{
						Alignment = StringAlignment.Center
					});
				}
				else
				{
					graphics.DrawString("2", new Font("Marlett", 12f), new SolidBrush(Color.LightGray), new Point(51, 7), new StringFormat
					{
						Alignment = StringAlignment.Center
					});
				}
				break;
			}
			if (this._EnableMinimize)
			{
				graphics.DrawString("0", new Font("Marlett", 12f), new SolidBrush(Color.FromArgb(255, 254, 255)), new Point(20, 7), new StringFormat
				{
					Alignment = StringAlignment.Center
				});
			}
			else
			{
				graphics.DrawString("0", new Font("Marlett", 12f), new SolidBrush(Color.LightGray), new Point(20, 7), new StringFormat
				{
					Alignment = StringAlignment.Center
				});
			}
		}

		// Token: 0x040000D9 RID: 217
		private MonoFlat_ControlBox.ButtonHoverState ButtonHState = MonoFlat_ControlBox.ButtonHoverState.None;

		// Token: 0x040000DA RID: 218
		private bool _EnableMaximize = true;

		// Token: 0x040000DB RID: 219
		private bool _EnableMinimize = true;

		// Token: 0x040000DC RID: 220
		private bool _EnableHoverHighlight = false;

		// Token: 0x02000009 RID: 9
		public enum ButtonHoverState
		{
			// Token: 0x040000DE RID: 222
			Minimize,
			// Token: 0x040000DF RID: 223
			Maximize,
			// Token: 0x040000E0 RID: 224
			Close,
			// Token: 0x040000E1 RID: 225
			None
		}
	}
}
