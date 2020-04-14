using System;
using System.Drawing;
using System.Windows.Forms;

namespace MonoFlat
{
	// Token: 0x02000006 RID: 6
	public class MonoFlat_ThemeContainer : ContainerControl
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000054 RID: 84 RVA: 0x0000CF48 File Offset: 0x0000B148
		// (set) Token: 0x06000055 RID: 85 RVA: 0x0000CF60 File Offset: 0x0000B160
		public bool Sizable
		{
			get
			{
				return this._Sizable;
			}
			set
			{
				this._Sizable = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000056 RID: 86 RVA: 0x0000CF6C File Offset: 0x0000B16C
		// (set) Token: 0x06000057 RID: 87 RVA: 0x0000CF84 File Offset: 0x0000B184
		public bool SmartBounds
		{
			get
			{
				return this._SmartBounds;
			}
			set
			{
				this._SmartBounds = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0000CF90 File Offset: 0x0000B190
		// (set) Token: 0x06000059 RID: 89 RVA: 0x0000CFA8 File Offset: 0x0000B1A8
		public bool RoundCorners
		{
			get
			{
				return this._RoundCorners;
			}
			set
			{
				this._RoundCorners = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600005A RID: 90 RVA: 0x0000CFBC File Offset: 0x0000B1BC
		protected bool IsParentForm
		{
			get
			{
				return this._IsParentForm;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600005B RID: 91 RVA: 0x0000CFD4 File Offset: 0x0000B1D4
		protected bool IsParentMdi
		{
			get
			{
				return base.Parent != null && base.Parent.Parent != null;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600005C RID: 92 RVA: 0x0000D00C File Offset: 0x0000B20C
		// (set) Token: 0x0600005D RID: 93 RVA: 0x0000D024 File Offset: 0x0000B224
		protected bool ControlMode
		{
			get
			{
				return this._ControlMode;
			}
			set
			{
				this._ControlMode = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600005E RID: 94 RVA: 0x0000D038 File Offset: 0x0000B238
		// (set) Token: 0x0600005F RID: 95 RVA: 0x0000D078 File Offset: 0x0000B278
		public FormStartPosition StartPosition
		{
			get
			{
				FormStartPosition startPosition;
				if (this._IsParentForm && !this._ControlMode)
				{
					startPosition = base.ParentForm.StartPosition;
				}
				else
				{
					startPosition = this._StartPosition;
				}
				return startPosition;
			}
			set
			{
				this._StartPosition = value;
				if (this._IsParentForm && !this._ControlMode)
				{
					base.ParentForm.StartPosition = value;
				}
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000D0B4 File Offset: 0x0000B2B4
		protected sealed override void OnParentChanged(EventArgs e)
		{
			base.OnParentChanged(e);
			if (base.Parent != null)
			{
				this._IsParentForm = (base.Parent is Form);
				if (!this._ControlMode)
				{
					this.InitializeMessages();
					if (this._IsParentForm)
					{
						base.ParentForm.FormBorderStyle = FormBorderStyle.None;
						base.ParentForm.TransparencyKey = Color.Fuchsia;
						if (!base.DesignMode)
						{
							base.ParentForm.Shown += this.FormShown;
						}
					}
					base.Parent.BackColor = this.BackColor;
				}
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000D16C File Offset: 0x0000B36C
		protected sealed override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			if (!this._ControlMode)
			{
				this.HeaderRect = new Rectangle(0, 0, base.Width - 14, this.MoveHeight - 7);
			}
			base.Invalidate();
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000D1B4 File Offset: 0x0000B3B4
		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			base.Focus();
			if (e.Button == MouseButtons.Left)
			{
				this.SetState(MonoFlat_ThemeContainer.MouseState.Down);
			}
			if ((!this._IsParentForm || base.ParentForm.WindowState != FormWindowState.Maximized) && !this._ControlMode)
			{
				if (this.HeaderRect.Contains(e.Location))
				{
					base.Capture = false;
					this.WM_LMBUTTONDOWN = true;
					this.DefWndProc(ref this.Messages[0]);
				}
				else if (this._Sizable && this.Previous != 0)
				{
					base.Capture = false;
					this.WM_LMBUTTONDOWN = true;
					this.DefWndProc(ref this.Messages[this.Previous]);
				}
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000D298 File Offset: 0x0000B498
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			this.Cap = false;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000D2AC File Offset: 0x0000B4AC
		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
			if ((!_IsParentForm || base.ParentForm.WindowState != FormWindowState.Maximized) && _Sizable && !_ControlMode)
			{
				InvalidateMouse();
			}
			if (Cap)
			{
				base.Parent.Location = (Point)(object)(Convert.ToDouble(Control.MousePosition) - Convert.ToDouble(MouseP));
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000D346 File Offset: 0x0000B546
		protected override void OnInvalidated(InvalidateEventArgs e)
		{
			base.OnInvalidated(e);
			base.ParentForm.Text = this.Text;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000D363 File Offset: 0x0000B563
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			base.OnPaintBackground(e);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000D36E File Offset: 0x0000B56E
		protected override void OnTextChanged(EventArgs e)
		{
			base.OnTextChanged(e);
			base.Invalidate();
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000D380 File Offset: 0x0000B580
		private void FormShown(object sender, EventArgs e)
		{
			if (!this._ControlMode && !this.HasShown)
			{
				if (this._StartPosition == FormStartPosition.CenterParent || this._StartPosition == FormStartPosition.CenterScreen)
				{
					Rectangle bounds = Screen.PrimaryScreen.Bounds;
					Rectangle bounds2 = base.ParentForm.Bounds;
					base.ParentForm.Location = new Point(bounds.Width / 2 - bounds2.Width / 2, bounds.Height / 2 - bounds2.Width / 2);
				}
				this.HasShown = true;
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000D41E File Offset: 0x0000B61E
		private void SetState(MonoFlat_ThemeContainer.MouseState current)
		{
			this.State = current;
			base.Invalidate();
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000D430 File Offset: 0x0000B630
		private int GetIndex()
		{
			this.GetIndexPoint = base.PointToClient(Control.MousePosition);
			this.B1x = (this.GetIndexPoint.X < 7);
			this.B2x = (this.GetIndexPoint.X > base.Width - 7);
			this.B3 = (this.GetIndexPoint.Y < 7);
			this.B4 = (this.GetIndexPoint.Y > base.Height - 7);
			int result;
			if (this.B1x && this.B3)
			{
				result = 4;
			}
			else if (this.B1x && this.B4)
			{
				result = 7;
			}
			else if (this.B2x && this.B3)
			{
				result = 5;
			}
			else if (this.B2x && this.B4)
			{
				result = 8;
			}
			else if (this.B1x)
			{
				result = 1;
			}
			else if (this.B2x)
			{
				result = 2;
			}
			else if (this.B3)
			{
				result = 3;
			}
			else if (this.B4)
			{
				result = 6;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000D578 File Offset: 0x0000B778
		private void InvalidateMouse()
		{
			this.Current = this.GetIndex();
			if (this.Current != this.Previous)
			{
				this.Previous = this.Current;
				int previous = this.Previous;
				if (previous != 0)
				{
					switch (previous)
					{
						case 6:
							this.Cursor = Cursors.SizeNS;
							break;
						case 7:
							this.Cursor = Cursors.SizeNESW;
							break;
						case 8:
							this.Cursor = Cursors.SizeNWSE;
							break;
					}
				}
				else
				{
					this.Cursor = Cursors.Default;
				}
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000D610 File Offset: 0x0000B810
		private void InitializeMessages()
		{
			this.Messages[0] = Message.Create(base.Parent.Handle, 161, new IntPtr(2), IntPtr.Zero);
			for (int i = 1; i <= 8; i++)
			{
				this.Messages[i] = Message.Create(base.Parent.Handle, 161, new IntPtr(i + 9), IntPtr.Zero);
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000D698 File Offset: 0x0000B898
		private void CorrectBounds(Rectangle bounds)
		{
			if (base.Parent.Width > bounds.Width)
			{
				base.Parent.Width = bounds.Width;
			}
			if (base.Parent.Height > bounds.Height)
			{
				base.Parent.Height = bounds.Height;
			}
			int num = base.Parent.Location.X;
			int num2 = base.Parent.Location.Y;
			if (num < bounds.X)
			{
				num = bounds.X;
			}
			if (num2 < bounds.Y)
			{
				num2 = bounds.Y;
			}
			int num3 = bounds.X + bounds.Width;
			int num4 = bounds.Y + bounds.Height;
			if (num + base.Parent.Width > num3)
			{
				num = num3 - base.Parent.Width;
			}
			if (num2 + base.Parent.Height > num4)
			{
				num2 = num4 - base.Parent.Height;
			}
			base.Parent.Location = new Point(num, num2);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000D7F4 File Offset: 0x0000B9F4
		protected override void WndProc(ref Message m)
		{
			base.WndProc(ref m);
			if (this.WM_LMBUTTONDOWN && m.Msg == 513)
			{
				this.WM_LMBUTTONDOWN = false;
				this.SetState(MonoFlat_ThemeContainer.MouseState.Over);
				if (this._SmartBounds)
				{
					if (this.IsParentMdi)
					{
						this.CorrectBounds(new Rectangle(Point.Empty, base.Parent.Parent.Size));
					}
					else
					{
						this.CorrectBounds(Screen.FromControl(base.Parent).WorkingArea);
					}
				}
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000D893 File Offset: 0x0000BA93
		protected override void CreateHandle()
		{
			base.CreateHandle();
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000D8A0 File Offset: 0x0000BAA0
		public MonoFlat_ThemeContainer()
		{
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.Opaque | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.BackColor = Color.FromArgb(32, 41, 50);
			base.Padding = new Padding(10, 70, 10, 9);
			this.DoubleBuffered = true;
			this.Dock = DockStyle.Fill;
			this.MoveHeight = 66;
			this.Font = new Font("Segoe UI", 9f);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000D950 File Offset: 0x0000BB50
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			Graphics graphics = e.Graphics;
			graphics.Clear(Color.FromArgb(32, 41, 50));
			graphics.FillRectangle(new SolidBrush(Color.FromArgb(181, 41, 42)), new Rectangle(0, 0, base.Width, 60));
			if (this._RoundCorners)
			{
				graphics.FillRectangle(Brushes.Fuchsia, 0, 0, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 1, 0, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 2, 0, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 3, 0, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 0, 1, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 0, 2, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 0, 3, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 1, 1, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(181, 41, 42)), 1, 3, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(181, 41, 42)), 1, 2, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(181, 41, 42)), 2, 1, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(181, 41, 42)), 3, 1, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, base.Width - 1, 0, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, base.Width - 2, 0, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, base.Width - 3, 0, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, base.Width - 4, 0, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, base.Width - 1, 1, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, base.Width - 1, 2, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, base.Width - 1, 3, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, base.Width - 2, 1, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(181, 41, 42)), base.Width - 2, 3, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(181, 41, 42)), base.Width - 2, 2, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(181, 41, 42)), base.Width - 3, 1, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(181, 41, 42)), base.Width - 4, 1, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 0, base.Height - 1, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 0, base.Height - 2, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 0, base.Height - 3, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 0, base.Height - 4, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 1, base.Height - 1, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 2, base.Height - 1, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 3, base.Height - 1, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 1, base.Height - 1, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, 1, base.Height - 2, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(32, 41, 50)), 1, base.Height - 3, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(32, 41, 50)), 1, base.Height - 4, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(32, 41, 50)), 3, base.Height - 2, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(32, 41, 50)), 2, base.Height - 2, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, base.Width - 1, base.Height, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, base.Width - 2, base.Height, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, base.Width - 3, base.Height, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, base.Width - 4, base.Height, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, base.Width - 1, base.Height - 1, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, base.Width - 1, base.Height - 2, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, base.Width - 1, base.Height - 3, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, base.Width - 2, base.Height - 1, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, base.Width - 3, base.Height - 1, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, base.Width - 4, base.Height - 1, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, base.Width - 1, base.Height - 4, 1, 1);
				graphics.FillRectangle(Brushes.Fuchsia, base.Width - 2, base.Height - 2, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(32, 41, 50)), base.Width - 2, base.Height - 3, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(32, 41, 50)), base.Width - 2, base.Height - 4, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(32, 41, 50)), base.Width - 4, base.Height - 2, 1, 1);
				graphics.FillRectangle(new SolidBrush(Color.FromArgb(32, 41, 50)), base.Width - 3, base.Height - 2, 1, 1);
			}
			graphics.DrawString(this.Text, new Font("Microsoft Sans Serif", 12f, FontStyle.Bold), new SolidBrush(Color.FromArgb(255, 254, 255)), new Rectangle(20, 20, base.Width - 1, base.Height), new StringFormat
			{
				Alignment = StringAlignment.Near,
				LineAlignment = StringAlignment.Near
			});
		}

		// Token: 0x040000BF RID: 191
		private Rectangle HeaderRect;

		// Token: 0x040000C0 RID: 192
		protected MonoFlat_ThemeContainer.MouseState State;

		// Token: 0x040000C1 RID: 193
		private int MoveHeight;

		// Token: 0x040000C2 RID: 194
		private Point MouseP = new Point(0, 0);

		// Token: 0x040000C3 RID: 195
		private bool Cap = false;

		// Token: 0x040000C4 RID: 196
		private bool HasShown;

		// Token: 0x040000C5 RID: 197
		private bool _Sizable = true;

		// Token: 0x040000C6 RID: 198
		private bool _SmartBounds = true;

		// Token: 0x040000C7 RID: 199
		private bool _RoundCorners = true;

		// Token: 0x040000C8 RID: 200
		private bool _IsParentForm;

		// Token: 0x040000C9 RID: 201
		private bool _ControlMode;

		// Token: 0x040000CA RID: 202
		private FormStartPosition _StartPosition;

		// Token: 0x040000CB RID: 203
		private Point GetIndexPoint;

		// Token: 0x040000CC RID: 204
		private bool B1x;

		// Token: 0x040000CD RID: 205
		private bool B2x;

		// Token: 0x040000CE RID: 206
		private bool B3;

		// Token: 0x040000CF RID: 207
		private bool B4;

		// Token: 0x040000D0 RID: 208
		private int Current;

		// Token: 0x040000D1 RID: 209
		private int Previous;

		// Token: 0x040000D2 RID: 210
		private Message[] Messages = new Message[9];

		// Token: 0x040000D3 RID: 211
		private bool WM_LMBUTTONDOWN;

		// Token: 0x02000007 RID: 7
		public enum MouseState
		{
			// Token: 0x040000D5 RID: 213
			None,
			// Token: 0x040000D6 RID: 214
			Over,
			// Token: 0x040000D7 RID: 215
			Down,
			// Token: 0x040000D8 RID: 216
			Block
		}
	}
}
