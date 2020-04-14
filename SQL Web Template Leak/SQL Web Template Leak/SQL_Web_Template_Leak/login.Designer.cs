namespace SQL_Web_Template_Leak
{
	// Token: 0x02000004 RID: 4
	public partial class login : global::System.Windows.Forms.Form
	{
		// Token: 0x06000050 RID: 80 RVA: 0x0000C158 File Offset: 0x0000A358
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000C190 File Offset: 0x0000A390
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::SQL_Web_Template_Leak.login));
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.flatMini1 = new global::theme.FlatMini();
			this.flatClose1 = new global::theme.FlatClose();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.monoFlat_Label1 = new global::MonoFlat.MonoFlat_Label();
			this.monoFlat_ThemeContainer1 = new global::MonoFlat.MonoFlat_ThemeContainer();
			this.label5 = new global::System.Windows.Forms.Label();
			this.licencetext = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.flatTextBox1 = new global::theme.FlatTextBox();
			this.button19 = new global::System.Windows.Forms.Button();
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuDragControl3 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.monoFlat_ThemeContainer1.SuspendLayout();
			base.SuspendLayout();
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.panel1;
			this.bunifuDragControl1.Vertical = true;
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(41, 51, 68);
			this.panel1.Controls.Add(this.flatMini1);
			this.panel1.Controls.Add(this.flatClose1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.monoFlat_Label1);
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(470, 60);
			this.panel1.TabIndex = 18;
			this.flatMini1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatMini1.BackColor = global::System.Drawing.Color.White;
			this.flatMini1.BaseColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.flatMini1.Font = new global::System.Drawing.Font("Marlett", 12f);
			this.flatMini1.Location = new global::System.Drawing.Point(424, 8);
			this.flatMini1.Name = "flatMini1";
			this.flatMini1.Size = new global::System.Drawing.Size(18, 18);
			this.flatMini1.TabIndex = 2;
			this.flatMini1.Text = "flatMini1";
			this.flatMini1.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatClose1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatClose1.BackColor = global::System.Drawing.Color.White;
			this.flatClose1.BaseColor = global::System.Drawing.Color.FromArgb(168, 35, 35);
			this.flatClose1.Font = new global::System.Drawing.Font("Marlett", 10f);
			this.flatClose1.Location = new global::System.Drawing.Point(445, 8);
			this.flatClose1.Name = "flatClose1";
			this.flatClose1.Size = new global::System.Drawing.Size(18, 18);
			this.flatClose1.TabIndex = 17;
			this.flatClose1.Text = "flatClose1";
			this.flatClose1.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.pictureBox1.Location = new global::System.Drawing.Point(8, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(60, 50);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 19;
			this.pictureBox1.TabStop = false;
			this.monoFlat_Label1.AutoSize = true;
			this.monoFlat_Label1.BackColor = global::System.Drawing.Color.Transparent;
			this.monoFlat_Label1.Font = new global::System.Drawing.Font("Segoe UI", 15.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.monoFlat_Label1.ForeColor = global::System.Drawing.Color.White;
			this.monoFlat_Label1.Location = new global::System.Drawing.Point(156, 11);
			this.monoFlat_Label1.Name = "monoFlat_Label1";
			this.monoFlat_Label1.Size = new global::System.Drawing.Size(153, 30);
			this.monoFlat_Label1.TabIndex = 19;
			this.monoFlat_Label1.Text = "SQL Web Leak";
			this.monoFlat_ThemeContainer1.BackColor = global::System.Drawing.Color.FromArgb(32, 41, 50);
			this.monoFlat_ThemeContainer1.Controls.Add(this.label5);
			this.monoFlat_ThemeContainer1.Controls.Add(this.licencetext);
			this.monoFlat_ThemeContainer1.Controls.Add(this.label4);
			this.monoFlat_ThemeContainer1.Controls.Add(this.label3);
			this.monoFlat_ThemeContainer1.Controls.Add(this.label2);
			this.monoFlat_ThemeContainer1.Controls.Add(this.label1);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatTextBox1);
			this.monoFlat_ThemeContainer1.Controls.Add(this.button19);
			this.monoFlat_ThemeContainer1.Controls.Add(this.panel1);
			this.monoFlat_ThemeContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.monoFlat_ThemeContainer1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.monoFlat_ThemeContainer1.Location = new global::System.Drawing.Point(0, 0);
			this.monoFlat_ThemeContainer1.Name = "monoFlat_ThemeContainer1";
			this.monoFlat_ThemeContainer1.Padding = new global::System.Windows.Forms.Padding(10, 70, 10, 9);
			this.monoFlat_ThemeContainer1.RoundCorners = true;
			this.monoFlat_ThemeContainer1.Sizable = true;
			this.monoFlat_ThemeContainer1.Size = new global::System.Drawing.Size(468, 302);
			this.monoFlat_ThemeContainer1.SmartBounds = true;
			this.monoFlat_ThemeContainer1.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.monoFlat_ThemeContainer1.TabIndex = 0;
			this.monoFlat_ThemeContainer1.Text = "monoFlat_ThemeContainer1";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(537, 237);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(100, 15);
			this.label5.TabIndex = 122;
			this.label5.Text = "oldmodz95admin";
			this.licencetext.AutoSize = true;
			this.licencetext.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.licencetext.ForeColor = global::System.Drawing.Color.White;
			this.licencetext.Location = new global::System.Drawing.Point(0, 284);
			this.licencetext.Name = "licencetext";
			this.licencetext.Size = new global::System.Drawing.Size(106, 15);
			this.licencetext.TabIndex = 121;
			this.licencetext.Text = "Vidéo Présentation";
			this.licencetext.Click += new global::System.EventHandler(this.licencetext_Click);
			this.label4.AutoSize = true;
			this.label4.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(327, 284);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(141, 15);
			this.label4.TabIndex = 120;
			this.label4.Text = "Avoir Un Licence Gratuite";
			this.label4.Click += new global::System.EventHandler(this.label4_Click);
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(516, 147);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(224, 15);
			this.label3.TabIndex = 119;
			this.label3.Text = "24141545134OldModz95415416124534130";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(546, 188);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(157, 15);
			this.label2.TabIndex = 118;
			this.label2.Text = "5646464968414156441941451";
			this.label1.AutoSize = true;
			this.label1.Cursor = global::System.Windows.Forms.Cursors.Help;
			this.label1.ForeColor = global::System.Drawing.Color.Red;
			this.label1.Location = new global::System.Drawing.Point(172, 214);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(115, 15);
			this.label1.TabIndex = 117;
			this.label1.Text = "Licence incorrecte !!!";
			this.label1.Visible = false;
			this.label1.Click += new global::System.EventHandler(this.label1_Click);
			this.flatTextBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBox1.Location = new global::System.Drawing.Point(124, 128);
			this.flatTextBox1.MaxLength = 32767;
			this.flatTextBox1.Multiline = false;
			this.flatTextBox1.Name = "flatTextBox1";
			this.flatTextBox1.ReadOnly = false;
			this.flatTextBox1.Size = new global::System.Drawing.Size(214, 29);
			this.flatTextBox1.TabIndex = 116;
			this.flatTextBox1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.flatTextBox1.TextColor = global::System.Drawing.Color.Black;
			this.flatTextBox1.UseSystemPasswordChar = false;
			this.button19.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.button19.Font = new global::System.Drawing.Font("Segoe UI Black", 9f);
			this.button19.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.button19.Location = new global::System.Drawing.Point(124, 172);
			this.button19.Name = "button19";
			this.button19.Size = new global::System.Drawing.Size(214, 37);
			this.button19.TabIndex = 114;
			this.button19.Text = "Login/Connexion";
			this.button19.UseVisualStyleBackColor = true;
			this.button19.Click += new global::System.EventHandler(this.button19_Click);
			this.bunifuDragControl2.Fixed = true;
			this.bunifuDragControl2.Horizontal = true;
			this.bunifuDragControl2.TargetControl = this.pictureBox1;
			this.bunifuDragControl2.Vertical = true;
			this.bunifuDragControl3.Fixed = true;
			this.bunifuDragControl3.Horizontal = true;
			this.bunifuDragControl3.TargetControl = this.monoFlat_Label1;
			this.bunifuDragControl3.Vertical = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(468, 302);
			base.Controls.Add(this.monoFlat_ThemeContainer1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "login";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "monoFlat_ThemeContainer1";
			base.TransparencyKey = global::System.Drawing.Color.Fuchsia;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.monoFlat_ThemeContainer1.ResumeLayout(false);
			this.monoFlat_ThemeContainer1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040000AD RID: 173
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000AE RID: 174
		private global::MonoFlat.MonoFlat_ThemeContainer monoFlat_ThemeContainer1;

		// Token: 0x040000AF RID: 175
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040000B0 RID: 176
		private global::theme.FlatMini flatMini1;

		// Token: 0x040000B1 RID: 177
		private global::theme.FlatClose flatClose1;

		// Token: 0x040000B2 RID: 178
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040000B3 RID: 179
		private global::MonoFlat.MonoFlat_Label monoFlat_Label1;

		// Token: 0x040000B4 RID: 180
		private global::System.Windows.Forms.Button button19;

		// Token: 0x040000B5 RID: 181
		private global::theme.FlatTextBox flatTextBox1;

		// Token: 0x040000B6 RID: 182
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040000B7 RID: 183
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000B8 RID: 184
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000B9 RID: 185
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040000BA RID: 186
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x040000BB RID: 187
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x040000BC RID: 188
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;

		// Token: 0x040000BD RID: 189
		private global::System.Windows.Forms.Label licencetext;

		// Token: 0x040000BE RID: 190
		private global::System.Windows.Forms.Label label5;
	}
}
