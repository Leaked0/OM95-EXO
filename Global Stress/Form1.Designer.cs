namespace Global_Stress
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002384 File Offset: 0x00000584
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000023BC File Offset: 0x000005BC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Global_Stress.Form1));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.flatMini1 = new global::theme.FlatMini();
			this.flatClose1 = new global::theme.FlatClose();
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuDragControl2 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuDragControl3 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.localisation = new global::System.Windows.Forms.Button();
			this.api = new global::theme.FlatTextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.key = new global::theme.FlatTextBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.host = new global::theme.FlatTextBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.port = new global::theme.FlatTextBox();
			this.label6 = new global::System.Windows.Forms.Label();
			this.time = new global::theme.FlatTextBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.method = new global::theme.FlatTextBox();
			this.label8 = new global::System.Windows.Forms.Label();
			this.Historique = new global::System.Windows.Forms.TextBox();
			this.logs = new global::System.Windows.Forms.TextBox();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.contact = new global::theme.FlatComboBox();
			this.oldmodz95 = new global::System.Windows.Forms.Button();
			this.jojo = new global::System.Windows.Forms.Button();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label12 = new global::System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(54, 57, 68);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.flatMini1);
			this.panel1.Controls.Add(this.flatClose1);
			this.panel1.Location = new global::System.Drawing.Point(-5, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(842, 67);
			this.panel1.TabIndex = 0;
			this.pictureBox1.Location = new global::System.Drawing.Point(11, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(72, 57);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Impact", 26.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new global::System.Drawing.Point(313, 10);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(208, 43);
			this.label1.TabIndex = 1;
			this.label1.Text = "Global Stress";
			this.flatMini1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatMini1.BackColor = global::System.Drawing.Color.White;
			this.flatMini1.BaseColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.flatMini1.Font = new global::System.Drawing.Font("Marlett", 12f);
			this.flatMini1.Location = new global::System.Drawing.Point(787, 6);
			this.flatMini1.Name = "flatMini1";
			this.flatMini1.Size = new global::System.Drawing.Size(18, 18);
			this.flatMini1.TabIndex = 1;
			this.flatMini1.Text = "flatMini1";
			this.flatMini1.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatClose1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatClose1.BackColor = global::System.Drawing.Color.White;
			this.flatClose1.BaseColor = global::System.Drawing.Color.FromArgb(168, 35, 35);
			this.flatClose1.Font = new global::System.Drawing.Font("Marlett", 10f);
			this.flatClose1.Location = new global::System.Drawing.Point(811, 6);
			this.flatClose1.Name = "flatClose1";
			this.flatClose1.Size = new global::System.Drawing.Size(18, 18);
			this.flatClose1.TabIndex = 0;
			this.flatClose1.Text = "flatClose1";
			this.flatClose1.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this.panel1;
			this.bunifuDragControl1.Vertical = true;
			this.bunifuDragControl2.Fixed = true;
			this.bunifuDragControl2.Horizontal = true;
			this.bunifuDragControl2.TargetControl = this.pictureBox1;
			this.bunifuDragControl2.Vertical = true;
			this.bunifuDragControl3.Fixed = true;
			this.bunifuDragControl3.Horizontal = true;
			this.bunifuDragControl3.TargetControl = this.label1;
			this.bunifuDragControl3.Vertical = true;
			this.localisation.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.localisation.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.localisation.Font = new global::System.Drawing.Font("Segoe UI Black", 9f);
			this.localisation.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.localisation.Location = new global::System.Drawing.Point(170, 327);
			this.localisation.Name = "localisation";
			this.localisation.Size = new global::System.Drawing.Size(149, 29);
			this.localisation.TabIndex = 84;
			this.localisation.Text = "Start";
			this.localisation.UseVisualStyleBackColor = true;
			this.localisation.Click += new global::System.EventHandler(this.localisation_Click);
			this.api.BackColor = global::System.Drawing.Color.Transparent;
			this.api.Location = new global::System.Drawing.Point(32, 193);
			this.api.MaxLength = 32767;
			this.api.Multiline = false;
			this.api.Name = "api";
			this.api.ReadOnly = false;
			this.api.Size = new global::System.Drawing.Size(121, 29);
			this.api.TabIndex = 85;
			this.api.Text = "00";
			this.api.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.api.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.api.UseSystemPasswordChar = false;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new global::System.Drawing.Point(35, 171);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(97, 18);
			this.label2.TabIndex = 86;
			this.label2.Text = "Number API";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new global::System.Drawing.Point(188, 171);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(36, 18);
			this.label3.TabIndex = 88;
			this.label3.Text = "Key";
			this.key.BackColor = global::System.Drawing.Color.Transparent;
			this.key.Location = new global::System.Drawing.Point(185, 193);
			this.key.MaxLength = 32767;
			this.key.Multiline = false;
			this.key.Name = "key";
			this.key.ReadOnly = false;
			this.key.Size = new global::System.Drawing.Size(121, 29);
			this.key.TabIndex = 87;
			this.key.Text = "user name";
			this.key.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.key.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.key.UseSystemPasswordChar = false;
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label4.Location = new global::System.Drawing.Point(35, 252);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(44, 18);
			this.label4.TabIndex = 90;
			this.label4.Text = "Host";
			this.host.BackColor = global::System.Drawing.Color.Transparent;
			this.host.Location = new global::System.Drawing.Point(32, 274);
			this.host.MaxLength = 32767;
			this.host.Multiline = false;
			this.host.Name = "host";
			this.host.ReadOnly = false;
			this.host.Size = new global::System.Drawing.Size(121, 29);
			this.host.TabIndex = 89;
			this.host.Text = "IP or URL";
			this.host.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.host.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.host.UseSystemPasswordChar = false;
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new global::System.Drawing.Point(335, 171);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(40, 18);
			this.label5.TabIndex = 92;
			this.label5.Text = "Port";
			this.port.BackColor = global::System.Drawing.Color.Transparent;
			this.port.Location = new global::System.Drawing.Point(332, 193);
			this.port.MaxLength = 32767;
			this.port.Multiline = false;
			this.port.Name = "port";
			this.port.ReadOnly = false;
			this.port.Size = new global::System.Drawing.Size(121, 29);
			this.port.TabIndex = 91;
			this.port.Text = "80";
			this.port.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.port.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.port.UseSystemPasswordChar = false;
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label6.Location = new global::System.Drawing.Point(188, 252);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(45, 18);
			this.label6.TabIndex = 94;
			this.label6.Text = "Time";
			this.time.BackColor = global::System.Drawing.Color.Transparent;
			this.time.Location = new global::System.Drawing.Point(185, 274);
			this.time.MaxLength = 32767;
			this.time.Multiline = false;
			this.time.Name = "time";
			this.time.ReadOnly = false;
			this.time.Size = new global::System.Drawing.Size(121, 29);
			this.time.TabIndex = 93;
			this.time.Text = "00";
			this.time.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.time.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.time.UseSystemPasswordChar = false;
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			this.label7.Location = new global::System.Drawing.Point(335, 252);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(64, 18);
			this.label7.TabIndex = 96;
			this.label7.Text = "Method";
			this.method.BackColor = global::System.Drawing.Color.Transparent;
			this.method.Location = new global::System.Drawing.Point(332, 274);
			this.method.MaxLength = 32767;
			this.method.Multiline = false;
			this.method.Name = "method";
			this.method.ReadOnly = false;
			this.method.Size = new global::System.Drawing.Size(121, 29);
			this.method.TabIndex = 95;
			this.method.Text = "UDP";
			this.method.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.method.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.method.UseSystemPasswordChar = false;
			this.label8.AutoSize = true;
			this.label8.Font = new global::System.Drawing.Font("Impact", 26.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.label8.Location = new global::System.Drawing.Point(147, 87);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(197, 43);
			this.label8.TabIndex = 2;
			this.label8.Text = "Attack Panel";
			this.Historique.BackColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.Historique.ForeColor = global::System.Drawing.SystemColors.Menu;
			this.Historique.Location = new global::System.Drawing.Point(489, 73);
			this.Historique.Multiline = true;
			this.Historique.Name = "Historique";
			this.Historique.Size = new global::System.Drawing.Size(335, 230);
			this.Historique.TabIndex = 97;
			this.Historique.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.logs.BackColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.logs.ForeColor = global::System.Drawing.SystemColors.Menu;
			this.logs.Location = new global::System.Drawing.Point(489, 309);
			this.logs.Multiline = true;
			this.logs.Name = "logs";
			this.logs.Size = new global::System.Drawing.Size(335, 195);
			this.logs.TabIndex = 98;
			this.logs.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.panel2.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.contact);
			this.panel2.Controls.Add(this.oldmodz95);
			this.panel2.Location = new global::System.Drawing.Point(12, 396);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(265, 108);
			this.panel2.TabIndex = 99;
			this.label9.AutoSize = true;
			this.label9.Location = new global::System.Drawing.Point(60, 87);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(137, 13);
			this.label9.TabIndex = 0;
			this.label9.Text = "Developped By OldModz95";
			this.label10.AutoSize = true;
			this.label10.Location = new global::System.Drawing.Point(45, 89);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(114, 13);
			this.label10.TabIndex = 1;
			this.label10.Text = "Proposed By Jojo_Dos";
			this.contact.BackColor = global::System.Drawing.Color.FromArgb(45, 45, 48);
			this.contact.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.contact.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.contact.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.contact.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.contact.ForeColor = global::System.Drawing.Color.White;
			this.contact.FormattingEnabled = true;
			this.contact.HoverColor = global::System.Drawing.Color.FromArgb(35, 168, 109);
			this.contact.ItemHeight = 18;
			this.contact.Items.AddRange(new object[]
			{
				"Discord Server",
				"Web Site",
				"Status Web Site",
				"YouTube",
				"Twitter",
				"Give Its Opinion"
			});
			this.contact.Location = new global::System.Drawing.Point(6, 45);
			this.contact.Name = "contact";
			this.contact.Size = new global::System.Drawing.Size(139, 24);
			this.contact.TabIndex = 3;
			this.oldmodz95.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.oldmodz95.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.oldmodz95.Font = new global::System.Drawing.Font("Segoe UI Black", 9f);
			this.oldmodz95.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.oldmodz95.Location = new global::System.Drawing.Point(151, 45);
			this.oldmodz95.Name = "oldmodz95";
			this.oldmodz95.Size = new global::System.Drawing.Size(74, 24);
			this.oldmodz95.TabIndex = 100;
			this.oldmodz95.Text = "Start";
			this.oldmodz95.UseVisualStyleBackColor = true;
			this.oldmodz95.Click += new global::System.EventHandler(this.oldmodz95_Click);
			this.jojo.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.jojo.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.jojo.Font = new global::System.Drawing.Font("Segoe UI Black", 9f);
			this.jojo.ForeColor = global::System.Drawing.SystemColors.ControlText;
			this.jojo.Location = new global::System.Drawing.Point(58, 45);
			this.jojo.Name = "jojo";
			this.jojo.Size = new global::System.Drawing.Size(85, 24);
			this.jojo.TabIndex = 101;
			this.jojo.Text = "Start";
			this.jojo.UseVisualStyleBackColor = true;
			this.jojo.Click += new global::System.EventHandler(this.jojo_Click);
			this.panel3.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.label11);
			this.panel3.Controls.Add(this.label10);
			this.panel3.Controls.Add(this.jojo);
			this.panel3.Location = new global::System.Drawing.Point(276, 396);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(207, 108);
			this.panel3.TabIndex = 102;
			this.label11.AutoSize = true;
			this.label11.Font = new global::System.Drawing.Font("Impact", 18f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label11.Location = new global::System.Drawing.Point(38, 6);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(128, 29);
			this.label11.TabIndex = 102;
			this.label11.Text = "Add Discord";
			this.label12.AutoSize = true;
			this.label12.Font = new global::System.Drawing.Font("Impact", 18f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label12.Location = new global::System.Drawing.Point(90, 6);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(89, 29);
			this.label12.TabIndex = 103;
			this.label12.Text = "Contact";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(50, 53, 59);
			base.ClientSize = new global::System.Drawing.Size(830, 512);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.logs);
			base.Controls.Add(this.Historique);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.method);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.time);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.port);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.host);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.key);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.api);
			base.Controls.Add(this.localisation);
			base.Controls.Add(this.panel1);
			this.ForeColor = global::System.Drawing.SystemColors.ButtonHighlight;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Form1";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Global Stress";
			base.TransparencyKey = global::System.Drawing.Color.Fuchsia;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000002 RID: 2
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000004 RID: 4
		private global::theme.FlatMini flatMini1;

		// Token: 0x04000005 RID: 5
		private global::theme.FlatClose flatClose1;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000008 RID: 8
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000009 RID: 9
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;

		// Token: 0x0400000A RID: 10
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.Button localisation;

		// Token: 0x0400000C RID: 12
		private global::theme.FlatTextBox api;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400000F RID: 15
		private global::theme.FlatTextBox key;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000011 RID: 17
		private global::theme.FlatTextBox host;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000013 RID: 19
		private global::theme.FlatTextBox port;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000015 RID: 21
		private global::theme.FlatTextBox time;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000017 RID: 23
		private global::theme.FlatTextBox method;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.TextBox Historique;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.TextBox logs;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Label label12;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.Label label9;

		// Token: 0x0400001E RID: 30
		private global::theme.FlatComboBox contact;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Button oldmodz95;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Button jojo;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Label label11;
	}
}
