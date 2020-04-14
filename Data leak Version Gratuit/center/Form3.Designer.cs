namespace center
{
	// Token: 0x02000004 RID: 4
	public partial class Form3 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000027 RID: 39 RVA: 0x0000AC00 File Offset: 0x00008E00
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000AC38 File Offset: 0x00008E38
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::center.Form3));
			this.logInContextMenu1 = new global::LogIn_Theme_Dll_By_xVenoxi.LogInContextMenu();
			this.suppriméeLhistoriqueToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.selectionToutCopierToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.copierToutToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toutSelectionnerToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.heure = new global::System.Windows.Forms.Timer(this.components);
			this.monoFlat_ThemeContainer1 = new global::MonoFlat.MonoFlat_ThemeContainer();
			this.logInButton2 = new global::LogIn_Theme_Dll_By_xVenoxi.LogInButton();
			this.KeyAPI2 = new global::System.Windows.Forms.TextBox();
			this.KeyAPI = new global::System.Windows.Forms.TextBox();
			this.flatLabel18 = new global::theme.FlatLabel();
			this.flatTextBox16 = new global::theme.FlatTextBox();
			this.flatLabel19 = new global::theme.FlatLabel();
			this.flatTextBox17 = new global::theme.FlatTextBox();
			this.flatLabel17 = new global::theme.FlatLabel();
			this.flatLabel9 = new global::theme.FlatLabel();
			this.flatLabel10 = new global::theme.FlatLabel();
			this.flatLabel11 = new global::theme.FlatLabel();
			this.flatTextBox8 = new global::theme.FlatTextBox();
			this.flatTextBox9 = new global::theme.FlatTextBox();
			this.flatTextBox10 = new global::theme.FlatTextBox();
			this.flatTextBox11 = new global::theme.FlatTextBox();
			this.flatLabel12 = new global::theme.FlatLabel();
			this.flatLabel13 = new global::theme.FlatLabel();
			this.flatLabel14 = new global::theme.FlatLabel();
			this.flatLabel15 = new global::theme.FlatLabel();
			this.flatTextBox12 = new global::theme.FlatTextBox();
			this.flatTextBox13 = new global::theme.FlatTextBox();
			this.flatTextBox14 = new global::theme.FlatTextBox();
			this.flatTextBox15 = new global::theme.FlatTextBox();
			this.flatLabel16 = new global::theme.FlatLabel();
			this.flatLabel5 = new global::theme.FlatLabel();
			this.flatLabel6 = new global::theme.FlatLabel();
			this.flatLabel7 = new global::theme.FlatLabel();
			this.flatTextBox4 = new global::theme.FlatTextBox();
			this.flatTextBox5 = new global::theme.FlatTextBox();
			this.flatTextBox6 = new global::theme.FlatTextBox();
			this.flatTextBox7 = new global::theme.FlatTextBox();
			this.flatLabel8 = new global::theme.FlatLabel();
			this.flatLabel4 = new global::theme.FlatLabel();
			this.flatLabel3 = new global::theme.FlatLabel();
			this.flatLabel1 = new global::theme.FlatLabel();
			this.flatTextBox3 = new global::theme.FlatTextBox();
			this.flatTextBox2 = new global::theme.FlatTextBox();
			this.flatTextBox1 = new global::theme.FlatTextBox();
			this.logInButton1 = new global::LogIn_Theme_Dll_By_xVenoxi.LogInButton();
			this.SkypeRR = new global::theme.FlatTextBox();
			this.flatLabel2 = new global::theme.FlatLabel();
			this.Historique = new global::System.Windows.Forms.TextBox();
			this.flatMini1 = new global::theme.FlatMini();
			this.flatClose1 = new global::theme.FlatClose();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.time = new global::theme.FlatLabel();
			this.logInContextMenu1.SuspendLayout();
			this.monoFlat_ThemeContainer1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.logInContextMenu1.FontColour = global::System.Drawing.Color.FromArgb(55, 255, 255);
			this.logInContextMenu1.ForeColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			this.logInContextMenu1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.suppriméeLhistoriqueToolStripMenuItem,
				this.selectionToutCopierToolStripMenuItem,
				this.copierToutToolStripMenuItem,
				this.toutSelectionnerToolStripMenuItem
			});
			this.logInContextMenu1.Name = "logInContextMenu1";
			this.logInContextMenu1.ShowImageMargin = false;
			this.logInContextMenu1.Size = new global::System.Drawing.Size(173, 92);
			this.suppriméeLhistoriqueToolStripMenuItem.Name = "suppriméeLhistoriqueToolStripMenuItem";
			this.suppriméeLhistoriqueToolStripMenuItem.Size = new global::System.Drawing.Size(172, 22);
			this.suppriméeLhistoriqueToolStripMenuItem.Text = "Supprimée l'historique";
			this.suppriméeLhistoriqueToolStripMenuItem.Click += new global::System.EventHandler(this.suppriméeLhistoriqueToolStripMenuItem_Click);
			this.selectionToutCopierToolStripMenuItem.Name = "selectionToutCopierToolStripMenuItem";
			this.selectionToutCopierToolStripMenuItem.Size = new global::System.Drawing.Size(172, 22);
			this.selectionToutCopierToolStripMenuItem.Text = "Selection Tout + Copier";
			this.selectionToutCopierToolStripMenuItem.Click += new global::System.EventHandler(this.selectionToutCopierToolStripMenuItem_Click);
			this.copierToutToolStripMenuItem.Name = "copierToutToolStripMenuItem";
			this.copierToutToolStripMenuItem.Size = new global::System.Drawing.Size(172, 22);
			this.copierToutToolStripMenuItem.Text = "Copier";
			this.copierToutToolStripMenuItem.Click += new global::System.EventHandler(this.copierToutToolStripMenuItem_Click);
			this.toutSelectionnerToolStripMenuItem.Name = "toutSelectionnerToolStripMenuItem";
			this.toutSelectionnerToolStripMenuItem.Size = new global::System.Drawing.Size(172, 22);
			this.toutSelectionnerToolStripMenuItem.Text = "Tout Selectionner";
			this.toutSelectionnerToolStripMenuItem.Click += new global::System.EventHandler(this.toutSelectionnerToolStripMenuItem_Click);
			this.heure.Tick += new global::System.EventHandler(this.heure_Tick);
			this.monoFlat_ThemeContainer1.BackColor = global::System.Drawing.Color.FromArgb(32, 41, 50);
			this.monoFlat_ThemeContainer1.Controls.Add(this.logInButton2);
			this.monoFlat_ThemeContainer1.Controls.Add(this.KeyAPI2);
			this.monoFlat_ThemeContainer1.Controls.Add(this.KeyAPI);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatLabel18);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatTextBox16);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatLabel19);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatTextBox17);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatLabel17);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatLabel9);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatLabel10);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatLabel11);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatTextBox8);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatTextBox9);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatTextBox10);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatTextBox11);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatLabel12);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatLabel13);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatLabel14);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatLabel15);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatTextBox12);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatTextBox13);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatTextBox14);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatTextBox15);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatLabel16);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatLabel5);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatLabel6);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatLabel7);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatTextBox4);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatTextBox5);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatTextBox6);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatTextBox7);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatLabel8);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatLabel4);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatLabel3);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatLabel1);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatTextBox3);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatTextBox2);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatTextBox1);
			this.monoFlat_ThemeContainer1.Controls.Add(this.logInButton1);
			this.monoFlat_ThemeContainer1.Controls.Add(this.SkypeRR);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatLabel2);
			this.monoFlat_ThemeContainer1.Controls.Add(this.Historique);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatMini1);
			this.monoFlat_ThemeContainer1.Controls.Add(this.flatClose1);
			this.monoFlat_ThemeContainer1.Controls.Add(this.pictureBox1);
			this.monoFlat_ThemeContainer1.Controls.Add(this.textBox2);
			this.monoFlat_ThemeContainer1.Controls.Add(this.time);
			this.monoFlat_ThemeContainer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.monoFlat_ThemeContainer1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.monoFlat_ThemeContainer1.Location = new global::System.Drawing.Point(0, 0);
			this.monoFlat_ThemeContainer1.Name = "monoFlat_ThemeContainer1";
			this.monoFlat_ThemeContainer1.Padding = new global::System.Windows.Forms.Padding(10, 70, 10, 9);
			this.monoFlat_ThemeContainer1.RoundCorners = true;
			this.monoFlat_ThemeContainer1.Sizable = true;
			this.monoFlat_ThemeContainer1.Size = new global::System.Drawing.Size(893, 591);
			this.monoFlat_ThemeContainer1.SmartBounds = true;
			this.monoFlat_ThemeContainer1.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.monoFlat_ThemeContainer1.TabIndex = 0;
			this.monoFlat_ThemeContainer1.Text = "                                                                  Data Leak Recherche avencer";
			this.logInButton2.BackColor = global::System.Drawing.Color.Transparent;
			this.logInButton2.BaseColour = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.logInButton2.BorderColour = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.logInButton2.FontColour = global::System.Drawing.Color.FromArgb(255, 255, 255);
			this.logInButton2.HoverColour = global::System.Drawing.Color.FromArgb(52, 52, 52);
			this.logInButton2.Location = new global::System.Drawing.Point(12, 546);
			this.logInButton2.Name = "logInButton2";
			this.logInButton2.PressedColour = global::System.Drawing.Color.FromArgb(47, 47, 47);
			this.logInButton2.ProgressColour = global::System.Drawing.Color.FromArgb(0, 191, 255);
			this.logInButton2.Size = new global::System.Drawing.Size(508, 29);
			this.logInButton2.TabIndex = 60;
			this.logInButton2.Text = "Saugarde L'historique";
			this.logInButton2.Click += new global::System.EventHandler(this.logInButton2_Click);
			this.KeyAPI2.Location = new global::System.Drawing.Point(1405, 282);
			this.KeyAPI2.Name = "KeyAPI2";
			this.KeyAPI2.Size = new global::System.Drawing.Size(11, 23);
			this.KeyAPI2.TabIndex = 58;
			this.KeyAPI2.Text = "EWY8P-OVY9T-FX9KW-1OOVS";
			this.KeyAPI2.Visible = false;
			this.KeyAPI.Location = new global::System.Drawing.Point(1326, 215);
			this.KeyAPI.Name = "KeyAPI";
			this.KeyAPI.Size = new global::System.Drawing.Size(10, 23);
			this.KeyAPI.TabIndex = 57;
			this.KeyAPI.Text = "EWY8P-OVY9T-FX9KW-1OOVS";
			this.KeyAPI.Visible = false;
			this.flatLabel18.AutoSize = true;
			this.flatLabel18.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel18.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel18.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel18.Location = new global::System.Drawing.Point(311, 460);
			this.flatLabel18.Name = "flatLabel18";
			this.flatLabel18.Size = new global::System.Drawing.Size(119, 13);
			this.flatLabel18.TabIndex = 55;
			this.flatLabel18.Text = "En-têtes de site Web :";
			this.flatTextBox16.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBox16.Location = new global::System.Drawing.Point(313, 476);
			this.flatTextBox16.MaxLength = 32767;
			this.flatTextBox16.Multiline = false;
			this.flatTextBox16.Name = "flatTextBox16";
			this.flatTextBox16.ReadOnly = false;
			this.flatTextBox16.Size = new global::System.Drawing.Size(207, 29);
			this.flatTextBox16.TabIndex = 54;
			this.flatTextBox16.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.flatTextBox16.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBox16.UseSystemPasswordChar = false;
			this.flatLabel19.AutoSize = true;
			this.flatLabel19.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel19.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel19.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel19.Location = new global::System.Drawing.Point(10, 460);
			this.flatLabel19.Name = "flatLabel19";
			this.flatLabel19.Size = new global::System.Drawing.Size(96, 13);
			this.flatLabel19.TabIndex = 53;
			this.flatLabel19.Text = "Skype vers email :";
			this.flatTextBox17.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBox17.Location = new global::System.Drawing.Point(12, 476);
			this.flatTextBox17.MaxLength = 32767;
			this.flatTextBox17.Multiline = false;
			this.flatTextBox17.Name = "flatTextBox17";
			this.flatTextBox17.ReadOnly = false;
			this.flatTextBox17.Size = new global::System.Drawing.Size(207, 29);
			this.flatTextBox17.TabIndex = 52;
			this.flatTextBox17.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.flatTextBox17.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBox17.UseSystemPasswordChar = false;
			this.flatLabel17.AutoSize = true;
			this.flatLabel17.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel17.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel17.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel17.Location = new global::System.Drawing.Point(164, 578);
			this.flatLabel17.Name = "flatLabel17";
			this.flatLabel17.Size = new global::System.Drawing.Size(189, 13);
			this.flatLabel17.TabIndex = 51;
			this.flatLabel17.Text = "Dev : ExoTiQueMoDz et OldModz95";
			this.flatLabel9.AutoSize = true;
			this.flatLabel9.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel9.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel9.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel9.Location = new global::System.Drawing.Point(311, 411);
			this.flatLabel9.Name = "flatLabel9";
			this.flatLabel9.Size = new global::System.Drawing.Size(105, 13);
			this.flatLabel9.TabIndex = 49;
			this.flatLabel9.Text = "Scanner Nmap (IP) :";
			this.flatLabel10.AutoSize = true;
			this.flatLabel10.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel10.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel10.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel10.Location = new global::System.Drawing.Point(310, 363);
			this.flatLabel10.Name = "flatLabel10";
			this.flatLabel10.Size = new global::System.Drawing.Size(77, 13);
			this.flatLabel10.TabIndex = 48;
			this.flatLabel10.Text = "Validateur IP :";
			this.flatLabel11.AutoSize = true;
			this.flatLabel11.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel11.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel11.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel11.Location = new global::System.Drawing.Point(311, 315);
			this.flatLabel11.Name = "flatLabel11";
			this.flatLabel11.Size = new global::System.Drawing.Size(136, 13);
			this.flatLabel11.TabIndex = 47;
			this.flatLabel11.Text = "Vérificateur Whois (URL) :";
			this.flatTextBox8.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBox8.Location = new global::System.Drawing.Point(313, 379);
			this.flatTextBox8.MaxLength = 32767;
			this.flatTextBox8.Multiline = false;
			this.flatTextBox8.Name = "flatTextBox8";
			this.flatTextBox8.ReadOnly = false;
			this.flatTextBox8.Size = new global::System.Drawing.Size(207, 29);
			this.flatTextBox8.TabIndex = 46;
			this.flatTextBox8.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.flatTextBox8.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBox8.UseSystemPasswordChar = false;
			this.flatTextBox9.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBox9.Location = new global::System.Drawing.Point(313, 427);
			this.flatTextBox9.MaxLength = 32767;
			this.flatTextBox9.Multiline = false;
			this.flatTextBox9.Name = "flatTextBox9";
			this.flatTextBox9.ReadOnly = false;
			this.flatTextBox9.Size = new global::System.Drawing.Size(207, 29);
			this.flatTextBox9.TabIndex = 45;
			this.flatTextBox9.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.flatTextBox9.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBox9.UseSystemPasswordChar = false;
			this.flatTextBox10.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBox10.Location = new global::System.Drawing.Point(313, 331);
			this.flatTextBox10.MaxLength = 32767;
			this.flatTextBox10.Multiline = false;
			this.flatTextBox10.Name = "flatTextBox10";
			this.flatTextBox10.ReadOnly = false;
			this.flatTextBox10.Size = new global::System.Drawing.Size(207, 29);
			this.flatTextBox10.TabIndex = 44;
			this.flatTextBox10.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.flatTextBox10.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBox10.UseSystemPasswordChar = false;
			this.flatTextBox11.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBox11.Location = new global::System.Drawing.Point(313, 282);
			this.flatTextBox11.MaxLength = 32767;
			this.flatTextBox11.Multiline = false;
			this.flatTextBox11.Name = "flatTextBox11";
			this.flatTextBox11.ReadOnly = false;
			this.flatTextBox11.Size = new global::System.Drawing.Size(207, 29);
			this.flatTextBox11.TabIndex = 43;
			this.flatTextBox11.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.flatTextBox11.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBox11.UseSystemPasswordChar = false;
			this.flatLabel12.AutoSize = true;
			this.flatLabel12.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel12.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel12.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel12.Location = new global::System.Drawing.Point(310, 266);
			this.flatLabel12.Name = "flatLabel12";
			this.flatLabel12.Size = new global::System.Drawing.Size(198, 13);
			this.flatLabel12.TabIndex = 42;
			this.flatLabel12.Text = "Vérification l'historique du domaine :";
			this.flatLabel13.AutoSize = true;
			this.flatLabel13.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel13.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel13.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel13.Location = new global::System.Drawing.Point(311, 215);
			this.flatLabel13.Name = "flatLabel13";
			this.flatLabel13.Size = new global::System.Drawing.Size(190, 13);
			this.flatLabel13.TabIndex = 41;
			this.flatLabel13.Text = "Recherche d'hôte partagé (IP WEB) :";
			this.flatLabel14.AutoSize = true;
			this.flatLabel14.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel14.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel14.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel14.Location = new global::System.Drawing.Point(310, 167);
			this.flatLabel14.Name = "flatLabel14";
			this.flatLabel14.Size = new global::System.Drawing.Size(187, 13);
			this.flatLabel14.TabIndex = 40;
			this.flatLabel14.Text = "Recherche de sous-domaine (URL) :";
			this.flatLabel15.AutoSize = true;
			this.flatLabel15.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel15.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel15.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel15.Location = new global::System.Drawing.Point(311, 118);
			this.flatLabel15.Name = "flatLabel15";
			this.flatLabel15.Size = new global::System.Drawing.Size(154, 13);
			this.flatLabel15.TabIndex = 39;
			this.flatLabel15.Text = "Résolveur CloudFlare (URL) : ";
			this.flatTextBox12.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBox12.Location = new global::System.Drawing.Point(313, 183);
			this.flatTextBox12.MaxLength = 32767;
			this.flatTextBox12.Multiline = false;
			this.flatTextBox12.Name = "flatTextBox12";
			this.flatTextBox12.ReadOnly = false;
			this.flatTextBox12.Size = new global::System.Drawing.Size(207, 29);
			this.flatTextBox12.TabIndex = 38;
			this.flatTextBox12.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.flatTextBox12.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBox12.UseSystemPasswordChar = false;
			this.flatTextBox13.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBox13.Location = new global::System.Drawing.Point(313, 231);
			this.flatTextBox13.MaxLength = 32767;
			this.flatTextBox13.Multiline = false;
			this.flatTextBox13.Name = "flatTextBox13";
			this.flatTextBox13.ReadOnly = false;
			this.flatTextBox13.Size = new global::System.Drawing.Size(207, 29);
			this.flatTextBox13.TabIndex = 37;
			this.flatTextBox13.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.flatTextBox13.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBox13.UseSystemPasswordChar = false;
			this.flatTextBox14.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBox14.Location = new global::System.Drawing.Point(313, 135);
			this.flatTextBox14.MaxLength = 32767;
			this.flatTextBox14.Multiline = false;
			this.flatTextBox14.Name = "flatTextBox14";
			this.flatTextBox14.ReadOnly = false;
			this.flatTextBox14.Size = new global::System.Drawing.Size(207, 29);
			this.flatTextBox14.TabIndex = 36;
			this.flatTextBox14.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.flatTextBox14.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBox14.UseSystemPasswordChar = false;
			this.flatTextBox15.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBox15.Location = new global::System.Drawing.Point(313, 86);
			this.flatTextBox15.MaxLength = 32767;
			this.flatTextBox15.Multiline = false;
			this.flatTextBox15.Name = "flatTextBox15";
			this.flatTextBox15.ReadOnly = false;
			this.flatTextBox15.Size = new global::System.Drawing.Size(207, 29);
			this.flatTextBox15.TabIndex = 35;
			this.flatTextBox15.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.flatTextBox15.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBox15.UseSystemPasswordChar = false;
			this.flatLabel16.AutoSize = true;
			this.flatLabel16.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel16.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel16.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel16.Location = new global::System.Drawing.Point(310, 70);
			this.flatLabel16.Name = "flatLabel16";
			this.flatLabel16.Size = new global::System.Drawing.Size(43, 13);
			this.flatLabel16.TabIndex = 34;
			this.flatLabel16.Text = "GeoIP :";
			this.flatLabel5.AutoSize = true;
			this.flatLabel5.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel5.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel5.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel5.Location = new global::System.Drawing.Point(10, 411);
			this.flatLabel5.Name = "flatLabel5";
			this.flatLabel5.Size = new global::System.Drawing.Size(95, 13);
			this.flatLabel5.TabIndex = 33;
			this.flatLabel5.Text = "IP vers héberger :";
			this.flatLabel6.AutoSize = true;
			this.flatLabel6.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel6.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel6.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel6.Location = new global::System.Drawing.Point(9, 363);
			this.flatLabel6.Name = "flatLabel6";
			this.flatLabel6.Size = new global::System.Drawing.Size(116, 13);
			this.flatLabel6.TabIndex = 32;
			this.flatLabel6.Text = "URL d'un site vers IP :";
			this.flatLabel7.AutoSize = true;
			this.flatLabel7.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel7.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel7.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel7.Location = new global::System.Drawing.Point(10, 315);
			this.flatLabel7.Name = "flatLabel7";
			this.flatLabel7.Size = new global::System.Drawing.Size(165, 13);
			this.flatLabel7.TabIndex = 31;
			this.flatLabel7.Text = "Détecteur de proxy et VPN (IP) :";
			this.flatTextBox4.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBox4.Location = new global::System.Drawing.Point(12, 379);
			this.flatTextBox4.MaxLength = 32767;
			this.flatTextBox4.Multiline = false;
			this.flatTextBox4.Name = "flatTextBox4";
			this.flatTextBox4.ReadOnly = false;
			this.flatTextBox4.Size = new global::System.Drawing.Size(207, 29);
			this.flatTextBox4.TabIndex = 30;
			this.flatTextBox4.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.flatTextBox4.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBox4.UseSystemPasswordChar = false;
			this.flatTextBox5.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBox5.Location = new global::System.Drawing.Point(12, 427);
			this.flatTextBox5.MaxLength = 32767;
			this.flatTextBox5.Multiline = false;
			this.flatTextBox5.Name = "flatTextBox5";
			this.flatTextBox5.ReadOnly = false;
			this.flatTextBox5.Size = new global::System.Drawing.Size(207, 29);
			this.flatTextBox5.TabIndex = 29;
			this.flatTextBox5.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.flatTextBox5.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBox5.UseSystemPasswordChar = false;
			this.flatTextBox6.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBox6.Location = new global::System.Drawing.Point(12, 331);
			this.flatTextBox6.MaxLength = 32767;
			this.flatTextBox6.Multiline = false;
			this.flatTextBox6.Name = "flatTextBox6";
			this.flatTextBox6.ReadOnly = false;
			this.flatTextBox6.Size = new global::System.Drawing.Size(207, 29);
			this.flatTextBox6.TabIndex = 28;
			this.flatTextBox6.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.flatTextBox6.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBox6.UseSystemPasswordChar = false;
			this.flatTextBox7.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBox7.Location = new global::System.Drawing.Point(12, 282);
			this.flatTextBox7.MaxLength = 32767;
			this.flatTextBox7.Multiline = false;
			this.flatTextBox7.Name = "flatTextBox7";
			this.flatTextBox7.ReadOnly = false;
			this.flatTextBox7.Size = new global::System.Drawing.Size(207, 29);
			this.flatTextBox7.TabIndex = 27;
			this.flatTextBox7.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.flatTextBox7.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBox7.UseSystemPasswordChar = false;
			this.flatLabel8.AutoSize = true;
			this.flatLabel8.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel8.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel8.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel8.Location = new global::System.Drawing.Point(9, 266);
			this.flatLabel8.Name = "flatLabel8";
			this.flatLabel8.Size = new global::System.Drawing.Size(155, 13);
			this.flatLabel8.TabIndex = 26;
			this.flatLabel8.Text = "Vérifier si l'email est  jetable :";
			this.flatLabel4.AutoSize = true;
			this.flatLabel4.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel4.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel4.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel4.Location = new global::System.Drawing.Point(10, 215);
			this.flatLabel4.Name = "flatLabel4";
			this.flatLabel4.Size = new global::System.Drawing.Size(128, 13);
			this.flatLabel4.TabIndex = 25;
			this.flatLabel4.Text = "Vérifier si l'email existe :";
			this.flatLabel3.AutoSize = true;
			this.flatLabel3.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel3.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel3.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel3.Location = new global::System.Drawing.Point(9, 167);
			this.flatLabel3.Name = "flatLabel3";
			this.flatLabel3.Size = new global::System.Drawing.Size(96, 13);
			this.flatLabel3.TabIndex = 24;
			this.flatLabel3.Text = "Email vers Skype :";
			this.flatLabel1.AutoSize = true;
			this.flatLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel1.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel1.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel1.Location = new global::System.Drawing.Point(10, 119);
			this.flatLabel1.Name = "flatLabel1";
			this.flatLabel1.Size = new global::System.Drawing.Size(78, 13);
			this.flatLabel1.TabIndex = 23;
			this.flatLabel1.Text = "IP vers Skype :";
			this.flatTextBox3.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBox3.Location = new global::System.Drawing.Point(12, 183);
			this.flatTextBox3.MaxLength = 32767;
			this.flatTextBox3.Multiline = false;
			this.flatTextBox3.Name = "flatTextBox3";
			this.flatTextBox3.ReadOnly = false;
			this.flatTextBox3.Size = new global::System.Drawing.Size(207, 29);
			this.flatTextBox3.TabIndex = 22;
			this.flatTextBox3.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.flatTextBox3.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBox3.UseSystemPasswordChar = false;
			this.flatTextBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBox2.Location = new global::System.Drawing.Point(12, 231);
			this.flatTextBox2.MaxLength = 32767;
			this.flatTextBox2.Multiline = false;
			this.flatTextBox2.Name = "flatTextBox2";
			this.flatTextBox2.ReadOnly = false;
			this.flatTextBox2.Size = new global::System.Drawing.Size(207, 29);
			this.flatTextBox2.TabIndex = 21;
			this.flatTextBox2.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.flatTextBox2.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBox2.UseSystemPasswordChar = false;
			this.flatTextBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.flatTextBox1.Location = new global::System.Drawing.Point(12, 135);
			this.flatTextBox1.MaxLength = 32767;
			this.flatTextBox1.Multiline = false;
			this.flatTextBox1.Name = "flatTextBox1";
			this.flatTextBox1.ReadOnly = false;
			this.flatTextBox1.Size = new global::System.Drawing.Size(207, 29);
			this.flatTextBox1.TabIndex = 20;
			this.flatTextBox1.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.flatTextBox1.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.flatTextBox1.UseSystemPasswordChar = false;
			this.logInButton1.BackColor = global::System.Drawing.Color.Transparent;
			this.logInButton1.BaseColour = global::System.Drawing.Color.FromArgb(42, 42, 42);
			this.logInButton1.BorderColour = global::System.Drawing.Color.FromArgb(25, 25, 25);
			this.logInButton1.FontColour = global::System.Drawing.Color.FromArgb(255, 255, 255);
			this.logInButton1.HoverColour = global::System.Drawing.Color.FromArgb(52, 52, 52);
			this.logInButton1.Location = new global::System.Drawing.Point(13, 511);
			this.logInButton1.Name = "logInButton1";
			this.logInButton1.PressedColour = global::System.Drawing.Color.FromArgb(47, 47, 47);
			this.logInButton1.ProgressColour = global::System.Drawing.Color.FromArgb(0, 191, 255);
			this.logInButton1.Size = new global::System.Drawing.Size(507, 29);
			this.logInButton1.TabIndex = 19;
			this.logInButton1.Text = "Start";
			this.logInButton1.Click += new global::System.EventHandler(this.logInButton1_Click);
			this.SkypeRR.BackColor = global::System.Drawing.Color.Transparent;
			this.SkypeRR.Location = new global::System.Drawing.Point(12, 86);
			this.SkypeRR.MaxLength = 32767;
			this.SkypeRR.Multiline = false;
			this.SkypeRR.Name = "SkypeRR";
			this.SkypeRR.ReadOnly = false;
			this.SkypeRR.Size = new global::System.Drawing.Size(207, 29);
			this.SkypeRR.TabIndex = 18;
			this.SkypeRR.TextAlign = global::System.Windows.Forms.HorizontalAlignment.Center;
			this.SkypeRR.TextColor = global::System.Drawing.Color.FromArgb(192, 192, 192);
			this.SkypeRR.UseSystemPasswordChar = false;
			this.flatLabel2.AutoSize = true;
			this.flatLabel2.BackColor = global::System.Drawing.Color.Transparent;
			this.flatLabel2.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.flatLabel2.ForeColor = global::System.Drawing.Color.White;
			this.flatLabel2.Location = new global::System.Drawing.Point(9, 70);
			this.flatLabel2.Name = "flatLabel2";
			this.flatLabel2.Size = new global::System.Drawing.Size(92, 13);
			this.flatLabel2.TabIndex = 17;
			this.flatLabel2.Text = "Skype Resolver : ";
			this.Historique.BackColor = global::System.Drawing.Color.FromArgb(32, 41, 50);
			this.Historique.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.Historique.ContextMenuStrip = this.logInContextMenu1;
			this.Historique.ForeColor = global::System.Drawing.Color.White;
			this.Historique.Location = new global::System.Drawing.Point(526, 73);
			this.Historique.Multiline = true;
			this.Historique.Name = "Historique";
			this.Historique.ReadOnly = true;
			this.Historique.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.Historique.Size = new global::System.Drawing.Size(354, 510);
			this.Historique.TabIndex = 3;
			this.flatMini1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatMini1.BackColor = global::System.Drawing.Color.White;
			this.flatMini1.BaseColor = global::System.Drawing.Color.FromArgb(45, 47, 49);
			this.flatMini1.Font = new global::System.Drawing.Font("Marlett", 12f);
			this.flatMini1.Location = new global::System.Drawing.Point(839, 11);
			this.flatMini1.Name = "flatMini1";
			this.flatMini1.Size = new global::System.Drawing.Size(18, 18);
			this.flatMini1.TabIndex = 2;
			this.flatMini1.Text = "flatMini1";
			this.flatMini1.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatClose1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.flatClose1.BackColor = global::System.Drawing.Color.White;
			this.flatClose1.BaseColor = global::System.Drawing.Color.FromArgb(168, 35, 35);
			this.flatClose1.Font = new global::System.Drawing.Font("Marlett", 10f);
			this.flatClose1.Location = new global::System.Drawing.Point(863, 12);
			this.flatClose1.Name = "flatClose1";
			this.flatClose1.Size = new global::System.Drawing.Size(18, 18);
			this.flatClose1.TabIndex = 1;
			this.flatClose1.Text = "flatClose1";
			this.flatClose1.TextColor = global::System.Drawing.Color.FromArgb(243, 243, 243);
			this.flatClose1.Click += new global::System.EventHandler(this.flatClose1_Click);
			this.pictureBox1.BackgroundImage = global::center.Properties.Resources.Screenshot_1;
			this.pictureBox1.Image = global::center.Properties.Resources.server__datacenter__database__storage_512;
			this.pictureBox1.Location = new global::System.Drawing.Point(5, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(60, 49);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.textBox2.Location = new global::System.Drawing.Point(646, 436);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new global::System.Drawing.Size(22, 20);
			this.textBox2.TabIndex = 50;
			this.textBox2.Visible = false;
			this.time.AutoSize = true;
			this.time.BackColor = global::System.Drawing.Color.Transparent;
			this.time.Font = new global::System.Drawing.Font("Segoe UI", 8f);
			this.time.ForeColor = global::System.Drawing.Color.White;
			this.time.Location = new global::System.Drawing.Point(631, 527);
			this.time.Name = "time";
			this.time.Size = new global::System.Drawing.Size(37, 13);
			this.time.TabIndex = 56;
			this.time.Text = "heure";
			this.time.Visible = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(893, 591);
			base.Controls.Add(this.monoFlat_ThemeContainer1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form3";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Data Leak Recherche Avancer";
			base.TransparencyKey = global::System.Drawing.Color.Fuchsia;
			this.logInContextMenu1.ResumeLayout(false);
			this.monoFlat_ThemeContainer1.ResumeLayout(false);
			this.monoFlat_ThemeContainer1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000051 RID: 81
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000052 RID: 82
		private global::MonoFlat.MonoFlat_ThemeContainer monoFlat_ThemeContainer1;

		// Token: 0x04000053 RID: 83
		private global::theme.FlatMini flatMini1;

		// Token: 0x04000054 RID: 84
		private global::theme.FlatClose flatClose1;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.TextBox Historique;

		// Token: 0x04000057 RID: 87
		private global::LogIn_Theme_Dll_By_xVenoxi.LogInButton logInButton1;

		// Token: 0x04000058 RID: 88
		private global::theme.FlatTextBox SkypeRR;

		// Token: 0x04000059 RID: 89
		private global::theme.FlatLabel flatLabel2;

		// Token: 0x0400005A RID: 90
		private global::theme.FlatLabel flatLabel4;

		// Token: 0x0400005B RID: 91
		private global::theme.FlatLabel flatLabel3;

		// Token: 0x0400005C RID: 92
		private global::theme.FlatLabel flatLabel1;

		// Token: 0x0400005D RID: 93
		private global::theme.FlatTextBox flatTextBox3;

		// Token: 0x0400005E RID: 94
		private global::theme.FlatTextBox flatTextBox2;

		// Token: 0x0400005F RID: 95
		private global::theme.FlatTextBox flatTextBox1;

		// Token: 0x04000060 RID: 96
		private global::theme.FlatLabel flatLabel5;

		// Token: 0x04000061 RID: 97
		private global::theme.FlatLabel flatLabel6;

		// Token: 0x04000062 RID: 98
		private global::theme.FlatLabel flatLabel7;

		// Token: 0x04000063 RID: 99
		private global::theme.FlatTextBox flatTextBox4;

		// Token: 0x04000064 RID: 100
		private global::theme.FlatTextBox flatTextBox5;

		// Token: 0x04000065 RID: 101
		private global::theme.FlatTextBox flatTextBox6;

		// Token: 0x04000066 RID: 102
		private global::theme.FlatTextBox flatTextBox7;

		// Token: 0x04000067 RID: 103
		private global::theme.FlatLabel flatLabel8;

		// Token: 0x04000068 RID: 104
		private global::theme.FlatLabel flatLabel9;

		// Token: 0x04000069 RID: 105
		private global::theme.FlatLabel flatLabel10;

		// Token: 0x0400006A RID: 106
		private global::theme.FlatLabel flatLabel11;

		// Token: 0x0400006B RID: 107
		private global::theme.FlatTextBox flatTextBox8;

		// Token: 0x0400006C RID: 108
		private global::theme.FlatTextBox flatTextBox9;

		// Token: 0x0400006D RID: 109
		private global::theme.FlatTextBox flatTextBox10;

		// Token: 0x0400006E RID: 110
		private global::theme.FlatTextBox flatTextBox11;

		// Token: 0x0400006F RID: 111
		private global::theme.FlatLabel flatLabel12;

		// Token: 0x04000070 RID: 112
		private global::theme.FlatLabel flatLabel13;

		// Token: 0x04000071 RID: 113
		private global::theme.FlatLabel flatLabel14;

		// Token: 0x04000072 RID: 114
		private global::theme.FlatLabel flatLabel15;

		// Token: 0x04000073 RID: 115
		private global::theme.FlatTextBox flatTextBox12;

		// Token: 0x04000074 RID: 116
		private global::theme.FlatTextBox flatTextBox13;

		// Token: 0x04000075 RID: 117
		private global::theme.FlatTextBox flatTextBox14;

		// Token: 0x04000076 RID: 118
		private global::theme.FlatTextBox flatTextBox15;

		// Token: 0x04000077 RID: 119
		private global::theme.FlatLabel flatLabel16;

		// Token: 0x04000078 RID: 120
		private global::System.Windows.Forms.TextBox textBox2;

		// Token: 0x04000079 RID: 121
		private global::LogIn_Theme_Dll_By_xVenoxi.LogInContextMenu logInContextMenu1;

		// Token: 0x0400007A RID: 122
		private global::System.Windows.Forms.ToolStripMenuItem suppriméeLhistoriqueToolStripMenuItem;

		// Token: 0x0400007B RID: 123
		private global::theme.FlatLabel flatLabel17;

		// Token: 0x0400007C RID: 124
		private global::theme.FlatLabel flatLabel18;

		// Token: 0x0400007D RID: 125
		private global::theme.FlatTextBox flatTextBox16;

		// Token: 0x0400007E RID: 126
		private global::theme.FlatLabel flatLabel19;

		// Token: 0x0400007F RID: 127
		private global::theme.FlatTextBox flatTextBox17;

		// Token: 0x04000080 RID: 128
		private global::System.Windows.Forms.ToolStripMenuItem copierToutToolStripMenuItem;

		// Token: 0x04000081 RID: 129
		private global::System.Windows.Forms.ToolStripMenuItem toutSelectionnerToolStripMenuItem;

		// Token: 0x04000082 RID: 130
		private global::System.Windows.Forms.ToolStripMenuItem selectionToutCopierToolStripMenuItem;

		// Token: 0x04000083 RID: 131
		private global::theme.FlatLabel time;

		// Token: 0x04000084 RID: 132
		private global::System.Windows.Forms.Timer heure;

		// Token: 0x04000085 RID: 133
		private global::System.Windows.Forms.TextBox KeyAPI2;

		// Token: 0x04000086 RID: 134
		private global::System.Windows.Forms.TextBox KeyAPI;

		// Token: 0x04000087 RID: 135
		private global::LogIn_Theme_Dll_By_xVenoxi.LogInButton logInButton2;
	}
}
