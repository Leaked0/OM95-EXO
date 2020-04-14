using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MonoFlat
{
	// Token: 0x02000016 RID: 22
	[DefaultEvent("TextChanged")]
	public class MonoFlat_TextBox : Control
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000CB RID: 203 RVA: 0x0000FEA8 File Offset: 0x0000E0A8
		// (set) Token: 0x060000CC RID: 204 RVA: 0x0000FEC0 File Offset: 0x0000E0C0
		public HorizontalAlignment TextAlignment
		{
			get
			{
				return this.ALNType;
			}
			set
			{
				this.ALNType = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000CD RID: 205 RVA: 0x0000FED4 File Offset: 0x0000E0D4
		// (set) Token: 0x060000CE RID: 206 RVA: 0x0000FEEC File Offset: 0x0000E0EC
		public int MaxLength
		{
			get
			{
				return this._maxchars;
			}
			set
			{
				this._maxchars = value;
				this.MonoFlatTB.MaxLength = this.MaxLength;
				base.Invalidate();
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000CF RID: 207 RVA: 0x0000FF10 File Offset: 0x0000E110
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x0000FF28 File Offset: 0x0000E128
		public bool UseSystemPasswordChar
		{
			get
			{
				return this.isPasswordMasked;
			}
			set
			{
				this.MonoFlatTB.UseSystemPasswordChar = this.UseSystemPasswordChar;
				this.isPasswordMasked = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x0000FF4C File Offset: 0x0000E14C
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x0000FF64 File Offset: 0x0000E164
		public bool ReadOnly
		{
			get
			{
				return this._ReadOnly;
			}
			set
			{
				this._ReadOnly = value;
				if (this.MonoFlatTB != null)
				{
					this.MonoFlatTB.ReadOnly = value;
				}
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x0000FF98 File Offset: 0x0000E198
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x0000FFB0 File Offset: 0x0000E1B0
		public bool Multiline
		{
			get
			{
				return this._Multiline;
			}
			set
			{
				this._Multiline = value;
				if (this.MonoFlatTB != null)
				{
					this.MonoFlatTB.Multiline = value;
					if (value)
					{
						this.MonoFlatTB.Height = base.Height - 23;
					}
					else
					{
						base.Height = this.MonoFlatTB.Height + 23;
					}
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x0001001C File Offset: 0x0000E21C
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00010034 File Offset: 0x0000E234
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
				if (this.Image == null)
				{
					this.MonoFlatTB.Location = new Point(8, 10);
				}
				else
				{
					this.MonoFlatTB.Location = new Point(35, 11);
				}
				base.Invalidate();
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x000100B8 File Offset: 0x0000E2B8
		protected Size ImageSize
		{
			get
			{
				return this._ImageSize;
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000100D0 File Offset: 0x0000E2D0
		private void _Enter(object Obj, EventArgs e)
		{
			this.P1 = new Pen(Color.FromArgb(181, 41, 42));
			this.Refresh();
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000100F3 File Offset: 0x0000E2F3
		private void _Leave(object Obj, EventArgs e)
		{
			this.P1 = new Pen(Color.FromArgb(32, 41, 50));
			this.Refresh();
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00010113 File Offset: 0x0000E313
		private void OnBaseTextChanged(object s, EventArgs e)
		{
			this.Text = this.MonoFlatTB.Text;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00010128 File Offset: 0x0000E328
		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			this.MonoFlatTB.Text = this.Text;
			base.Invalidate();
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0001014C File Offset: 0x0000E34C
		protected override void OnForeColorChanged(EventArgs e)
		{
			base.OnForeColorChanged(e);
			this.MonoFlatTB.ForeColor = this.ForeColor;
			base.Invalidate();
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00010170 File Offset: 0x0000E370
		protected override void OnFontChanged(EventArgs e)
		{
			base.OnFontChanged(e);
			this.MonoFlatTB.Font = this.Font;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0001018D File Offset: 0x0000E38D
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			base.OnPaintBackground(e);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00010198 File Offset: 0x0000E398
		private void _OnKeyDown(object Obj, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.A)
			{
				this.MonoFlatTB.SelectAll();
				e.SuppressKeyPress = true;
			}
			if (e.Control && e.KeyCode == Keys.C)
			{
				this.MonoFlatTB.Copy();
				e.SuppressKeyPress = true;
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0001020C File Offset: 0x0000E40C
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			if (this._Multiline)
			{
				this.MonoFlatTB.Height = base.Height - 23;
			}
			else
			{
				base.Height = this.MonoFlatTB.Height + 23;
			}
			this.Shape = new GraphicsPath();
			this.Shape.AddArc(0, 0, 10, 10, 180f, 90f);
			this.Shape.AddArc(base.Width - 11, 0, 10, 10, -90f, 90f);
			this.Shape.AddArc(base.Width - 11, base.Height - 11, 10, 10, 0f, 90f);
			this.Shape.AddArc(0, base.Height - 11, 10, 10, 90f, 90f);
			this.Shape.CloseAllFigures();
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00010306 File Offset: 0x0000E506
		protected override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);
			this.MonoFlatTB.Focus();
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0001031D File Offset: 0x0000E51D
		public void _TextChanged(object sender, EventArgs e)
		{
			this.Text = this.MonoFlatTB.Text;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00010332 File Offset: 0x0000E532
		public void _BaseTextChanged(object sender, EventArgs e)
		{
			this.MonoFlatTB.Text = this.Text;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00010348 File Offset: 0x0000E548
		public void AddTextBox()
		{
			this.MonoFlatTB.Location = new Point(8, 10);
			this.MonoFlatTB.Text = string.Empty;
			this.MonoFlatTB.BorderStyle = BorderStyle.None;
			this.MonoFlatTB.TextAlign = HorizontalAlignment.Left;
			this.MonoFlatTB.Font = new Font("Tahoma", 11f);
			this.MonoFlatTB.UseSystemPasswordChar = this.UseSystemPasswordChar;
			this.MonoFlatTB.Multiline = false;
			this.MonoFlatTB.BackColor = Color.FromArgb(66, 76, 85);
			this.MonoFlatTB.ScrollBars = ScrollBars.None;
			this.MonoFlatTB.KeyDown += this._OnKeyDown;
			this.MonoFlatTB.Enter += this._Enter;
			this.MonoFlatTB.Leave += this._Leave;
			this.MonoFlatTB.TextChanged += this.OnBaseTextChanged;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00010454 File Offset: 0x0000E654
		public MonoFlat_TextBox()
		{
			base.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(ControlStyles.UserPaint, true);
			this.AddTextBox();
			base.Controls.Add(this.MonoFlatTB);
			this.P1 = new Pen(Color.FromArgb(32, 41, 50));
			this.B1 = new SolidBrush(Color.FromArgb(66, 76, 85));
			this.BackColor = Color.Transparent;
			this.ForeColor = Color.FromArgb(176, 183, 191);
			this.Text = null;
			this.Font = new Font("Tahoma", 11f);
			base.Size = new Size(135, 43);
			this.DoubleBuffered = true;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00010544 File Offset: 0x0000E744
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Bitmap bitmap = new Bitmap(base.Width, base.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.SmoothingMode = SmoothingMode.AntiAlias;
			if (this.Image == null)
			{
				this.MonoFlatTB.Width = base.Width - 18;
			}
			else
			{
				this.MonoFlatTB.Width = base.Width - 45;
			}
			this.MonoFlatTB.TextAlign = this.TextAlignment;
			this.MonoFlatTB.UseSystemPasswordChar = this.UseSystemPasswordChar;
			graphics.Clear(Color.Transparent);
			graphics.FillPath(this.B1, this.Shape);
			graphics.DrawPath(this.P1, this.Shape);
			if (this.Image != null)
			{
				graphics.DrawImage(this._Image, 5, 8, 24, 24);
			}
			e.Graphics.DrawImage((Image)bitmap.Clone(), 0, 0);
			graphics.Dispose();
			bitmap.Dispose();
		}

		// Token: 0x04000103 RID: 259
		public TextBox MonoFlatTB = new TextBox();

		// Token: 0x04000104 RID: 260
		private int _maxchars = 32767;

		// Token: 0x04000105 RID: 261
		private bool _ReadOnly;

		// Token: 0x04000106 RID: 262
		private bool _Multiline;

		// Token: 0x04000107 RID: 263
		private Image _Image;

		// Token: 0x04000108 RID: 264
		private Size _ImageSize;

		// Token: 0x04000109 RID: 265
		private HorizontalAlignment ALNType;

		// Token: 0x0400010A RID: 266
		private bool isPasswordMasked = false;

		// Token: 0x0400010B RID: 267
		private Pen P1;

		// Token: 0x0400010C RID: 268
		private SolidBrush B1;

		// Token: 0x0400010D RID: 269
		private GraphicsPath Shape;
	}
}
