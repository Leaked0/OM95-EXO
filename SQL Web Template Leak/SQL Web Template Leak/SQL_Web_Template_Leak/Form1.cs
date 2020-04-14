using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MonoFlat;
using SQL_Web_Template_Leak.Properties;
using theme;

namespace SQL_Web_Template_Leak
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Form1()
		{
			this.InitializeComponent();
			this.panelautre.Visible = false;
			this.monoFlat_Panel2.Visible = false;
			this.monoFlat_Panel4.Visible = false;
			this.monoFlat_Panel5.Visible = false;
			this.monoFlat_Panel6.Visible = false;
			this.monoFlat_Panel7.Visible = false;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020D0 File Offset: 0x000002D0
		public void download(string link, string name)
		{
			using (WebClient webClient = new WebClient())
			{
				webClient.DownloadFile(link, name);
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002114 File Offset: 0x00000314
		private void flatButton1_Click(object sender, EventArgs e)
		{
			this.monoFlat_Panel1.Visible = true;
			this.monoFlat_Panel2.Visible = false;
			this.monoFlat_Panel4.Visible = false;
			this.monoFlat_Panel5.Visible = false;
			this.monoFlat_Panel6.Visible = false;
			this.monoFlat_Panel7.Visible = false;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002170 File Offset: 0x00000370
		private void flatButton2_Click(object sender, EventArgs e)
		{
			this.monoFlat_Panel2.Visible = true;
			this.monoFlat_Panel1.Visible = false;
			this.monoFlat_Panel4.Visible = false;
			this.monoFlat_Panel5.Visible = false;
			this.monoFlat_Panel6.Visible = false;
			this.monoFlat_Panel7.Visible = false;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021CC File Offset: 0x000003CC
		private void flatButton4_Click(object sender, EventArgs e)
		{
			this.monoFlat_Panel4.Visible = true;
			this.monoFlat_Panel2.Visible = false;
			this.monoFlat_Panel1.Visible = false;
			this.monoFlat_Panel5.Visible = false;
			this.monoFlat_Panel6.Visible = false;
			this.monoFlat_Panel7.Visible = false;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002228 File Offset: 0x00000428
		private void flatButton3_Click(object sender, EventArgs e)
		{
			this.monoFlat_Panel5.Visible = true;
			this.monoFlat_Panel4.Visible = false;
			this.monoFlat_Panel2.Visible = false;
			this.monoFlat_Panel1.Visible = false;
			this.monoFlat_Panel6.Visible = false;
			this.monoFlat_Panel7.Visible = false;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002284 File Offset: 0x00000484
		private void pictureBox4_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/3t2568W");
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002292 File Offset: 0x00000492
		private void pictureBox9_Click(object sender, EventArgs e)
		{
			Process.Start("https://discordapp.com/oauth2/authorize?client_id=624463058642796557&scope=bot&permissions=8");
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000022A0 File Offset: 0x000004A0
		private void pictureBox7_Click(object sender, EventArgs e)
		{
			Process.Start("https://youtube.com/oldmodz95");
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000022AE File Offset: 0x000004AE
		private void pictureBox8_Click(object sender, EventArgs e)
		{
			MessageBox.Show("SNAP: oldmodz95");
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000022BC File Offset: 0x000004BC
		private void pictureBox6_Click(object sender, EventArgs e)
		{
			Process.Start("https://twitter.com/oldytb");
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000022CA File Offset: 0x000004CA
		private void pictureBox10_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.facebook.com/OldModz95Ytb");
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000022D8 File Offset: 0x000004D8
		private void pictureBox11_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/47ezY9m");
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000022E6 File Offset: 0x000004E6
		private void pictureBox12_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/channel/UCHvV7Nhr8fl3Jv6IniDMMiA");
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000022F4 File Offset: 0x000004F4
		private void pictureBox13_Click(object sender, EventArgs e)
		{
			Process.Start("https://twitter.com/DevExotique");
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002302 File Offset: 0x00000502
		private void pictureBox14_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.facebook.com/ExoTiQueMoDz/");
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002310 File Offset: 0x00000510
		private void button17_Click(object sender, EventArgs e)
		{
			Process.Start("http://www.westvillage.fr");
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000231E File Offset: 0x0000051E
		private void button15_Click(object sender, EventArgs e)
		{
			Process.Start("http://www.ttcp.fr/");
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000232C File Offset: 0x0000052C
		private void button13_Click(object sender, EventArgs e)
		{
			Process.Start("http://www.subletdas.fr/");
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000233A File Offset: 0x0000053A
		private void button11_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.lri.fr/");
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002348 File Offset: 0x00000548
		private void button9_Click(object sender, EventArgs e)
		{
			Process.Start("http://www.gr-univers.fr/");
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002356 File Offset: 0x00000556
		private void button7_Click(object sender, EventArgs e)
		{
			Process.Start("http://www.citimages.fr/");
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002364 File Offset: 0x00000564
		private void button5_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.cave-vcr.fr/");
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002372 File Offset: 0x00000572
		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start("http://www.agrimax.fr/");
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002380 File Offset: 0x00000580
		private void button2_Click(object sender, EventArgs e)
		{
			Process.Start("http://www.bastien-lucas.fr/bl/");
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002390 File Offset: 0x00000590
		private void button3_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(this.textsourcedownload.Text);
					}
				}
			}
			MessageBox.Show("La Source SQL Bastien-lucas viens d'etre télécharger.\nOuvrez le avec NotPad++ ou SublimText.");
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000242C File Offset: 0x0000062C
		private void button4_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(this.textsourcedownload.Text);
					}
				}
			}
			MessageBox.Show("La Source SQL Bastien-lucas viens d'etre télécharger.\nOuvrez le avec NotPad++ ou SublimText.");
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000024C8 File Offset: 0x000006C8
		private void button6_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(this.textsourcedownload.Text);
					}
				}
			}
			MessageBox.Show("La Source SQL Bastien-lucas viens d'etre télécharger.\nOuvrez le avec NotPad++ ou SublimText.");
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002564 File Offset: 0x00000764
		private void button8_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(this.textsourcedownload.Text);
					}
				}
			}
			MessageBox.Show("La Source SQL Bastien-lucas viens d'etre télécharger.\nOuvrez le avec NotPad++ ou SublimText.");
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002600 File Offset: 0x00000800
		private void button10_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(this.textsourcedownload.Text);
					}
				}
			}
			MessageBox.Show("La Source SQL Bastien-lucas viens d'etre télécharger.\nOuvrez le avec NotPad++ ou SublimText.");
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000269C File Offset: 0x0000089C
		private void button12_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(this.textsourcedownload.Text);
					}
				}
			}
			MessageBox.Show("La Source SQL Bastien-lucas viens d'etre télécharger.\nOuvrez le avec NotPad++ ou SublimText.");
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002738 File Offset: 0x00000938
		private void button14_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(this.textsourcedownload.Text);
					}
				}
			}
			MessageBox.Show("La Source SQL Bastien-lucas viens d'etre télécharger.\nOuvrez le avec NotPad++ ou SublimText.");
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000027D4 File Offset: 0x000009D4
		private void button16_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(this.textsourcedownload.Text);
					}
				}
			}
			MessageBox.Show("La Source SQL Bastien-lucas viens d'etre télécharger.\nOuvrez le avec NotPad++ ou SublimText.");
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002870 File Offset: 0x00000A70
		private void button18_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(this.textsourcedownload.Text);
					}
				}
			}
			MessageBox.Show("La Source SQL Bastien-lucas viens d'etre télécharger.\nOuvrez le avec NotPad++ ou SublimText.");
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000290C File Offset: 0x00000B0C
		private void button19_Click(object sender, EventArgs e)
		{
			this.textsourcedownload.Text = this.WebClient.DownloadString("https://oldmodz95.000webhostapp.com/program/DidzWWII-SQL-Web-Template-Leak/folder/bastien-lucas.fr.txt");
			MessageBox.Show("La Source SQL Bastien viens d'etre charger.\nCliquez sur le bouton Download/Télécharger.");
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002938 File Offset: 0x00000B38
		private void flatButton5_Click(object sender, EventArgs e)
		{
			this.monoFlat_Panel6.Visible = true;
			this.monoFlat_Panel1.Visible = false;
			this.monoFlat_Panel2.Visible = false;
			this.monoFlat_Panel4.Visible = false;
			this.monoFlat_Panel5.Visible = false;
			this.monoFlat_Panel7.Visible = false;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002994 File Offset: 0x00000B94
		private void autre_Click(object sender, EventArgs e)
		{
			if (!this.panelautre.Visible)
			{
				this.panelautre.Visible = true;
			}
			else
			{
				this.panelautre.Visible = false;
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000029D0 File Offset: 0x00000BD0
		private void question_Click(object sender, EventArgs e)
		{
			this.monoFlat_Panel7.Visible = true;
			this.monoFlat_Panel1.Visible = false;
			this.monoFlat_Panel6.Visible = false;
			this.monoFlat_Panel2.Visible = false;
			this.monoFlat_Panel4.Visible = false;
			this.monoFlat_Panel5.Visible = false;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002A2C File Offset: 0x00000C2C
		private void button20_Click(object sender, EventArgs e)
		{
			this.textsourcedownload.Text = this.WebClient.DownloadString("https://oldmodz95.000webhostapp.com/program/DidzWWII-SQL-Web-Template-Leak/folder/agrimax.fr.txt");
			MessageBox.Show("La Source SQL agrimax viens d'etre charger.\nCliquez sur le bouton Download/Télécharger.");
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002A56 File Offset: 0x00000C56
		private void button21_Click(object sender, EventArgs e)
		{
			this.textsourcedownload.Text = this.WebClient.DownloadString("https://oldmodz95.000webhostapp.com/program/DidzWWII-SQL-Web-Template-Leak/folder/cave-vcr.fr.txt");
			MessageBox.Show("La Source SQL cave-vcr viens d'etre charger.\nCliquez sur le bouton Download/Télécharger.");
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002A80 File Offset: 0x00000C80
		private void button22_Click(object sender, EventArgs e)
		{
			this.textsourcedownload.Text = this.WebClient.DownloadString("https://oldmodz95.000webhostapp.com/program/DidzWWII-SQL-Web-Template-Leak/folder/citimages.fr.txt");
			MessageBox.Show("La Source SQL Citimages viens d'etre charger.\nCliquez sur le bouton Download/Télécharger.");
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002AAA File Offset: 0x00000CAA
		private void button23_Click(object sender, EventArgs e)
		{
			this.textsourcedownload.Text = this.WebClient.DownloadString("https://oldmodz95.000webhostapp.com/program/DidzWWII-SQL-Web-Template-Leak/folder/gr-univers.fr.txt");
			MessageBox.Show("La Source SQL Gr-univers viens d'etre charger.\nCliquez sur le bouton Download/Télécharger.");
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002AD4 File Offset: 0x00000CD4
		private void button24_Click(object sender, EventArgs e)
		{
			this.textsourcedownload.Text = this.WebClient.DownloadString("https://oldmodz95.000webhostapp.com/program/DidzWWII-SQL-Web-Template-Leak/folder/lri.fr.txt");
			MessageBox.Show("La Source SQL Lri viens d'etre charger.\nCliquez sur le bouton Download/Télécharger.");
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002AFE File Offset: 0x00000CFE
		private void button25_Click(object sender, EventArgs e)
		{
			this.textsourcedownload.Text = this.WebClient.DownloadString("https://oldmodz95.000webhostapp.com/program/DidzWWII-SQL-Web-Template-Leak/folder/subletdas.fr.txt");
			MessageBox.Show("La Source SQL subletdas viens d'etre charger.\nCliquez sur le bouton Download/Télécharger.");
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002B28 File Offset: 0x00000D28
		private void button26_Click(object sender, EventArgs e)
		{
			this.textsourcedownload.Text = this.WebClient.DownloadString("https://oldmodz95.000webhostapp.com/program/DidzWWII-SQL-Web-Template-Leak/folder/ttcp.fr.txt");
			MessageBox.Show("La Source SQL ttcp viens d'etre charger.\nCliquez sur le bouton Download/Télécharger.");
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002B52 File Offset: 0x00000D52
		private void button27_Click(object sender, EventArgs e)
		{
			this.textsourcedownload.Text = this.WebClient.DownloadString("https://oldmodz95.000webhostapp.com/program/DidzWWII-SQL-Web-Template-Leak/folder/westvillage.fr.txt");
			MessageBox.Show("La Source SQL westvillage viens d'etre charger.\nCliquez sur le bouton Download/Télécharger.");
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002B7C File Offset: 0x00000D7C
		private void button28_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002B7F File Offset: 0x00000D7F
		private void flatButton6_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/watch?v=vqEl36DIQmE");
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002B8D File Offset: 0x00000D8D
		private void button28_Click_1(object sender, EventArgs e)
		{
			this.textsourcedownload.Text = this.WebClient.DownloadString("https://oldmodz95.000webhostapp.com/program/DidzWWII-SQL-Web-Template-Leak/folder/amarillis.fr.txt");
			MessageBox.Show("La Source SQL amarillis viens d'etre charger.\nCliquez sur le bouton Download/Télécharger.");
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002BB7 File Offset: 0x00000DB7
		private void button31_Click(object sender, EventArgs e)
		{
			this.textsourcedownload.Text = this.WebClient.DownloadString("https://oldmodz95.000webhostapp.com/program/DidzWWII-SQL-Web-Template-Leak/folder/amico-asso.fr.txt");
			MessageBox.Show("La Source SQL amico-asso viens d'etre charger.\nCliquez sur le bouton Download/Télécharger.");
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002BE1 File Offset: 0x00000DE1
		private void button34_Click(object sender, EventArgs e)
		{
			this.textsourcedownload.Text = this.WebClient.DownloadString("https://oldmodz95.000webhostapp.com/program/DidzWWII-SQL-Web-Template-Leak/folder/gfgsystems.fr.txt");
			MessageBox.Show("La Source SQL gfgsystems viens d'etre charger.\nCliquez sur le bouton Download/Télécharger.");
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002C0B File Offset: 0x00000E0B
		private void button37_Click(object sender, EventArgs e)
		{
			this.textsourcedownload.Text = this.WebClient.DownloadString("https://oldmodz95.000webhostapp.com/program/DidzWWII-SQL-Web-Template-Leak/folder/jobs.fr.txt");
			MessageBox.Show("La Source SQL Jobs viens d'etre charger.\nCliquez sur le bouton Download/Télécharger.");
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002C35 File Offset: 0x00000E35
		private void button40_Click(object sender, EventArgs e)
		{
			this.textsourcedownload.Text = this.WebClient.DownloadString("https://oldmodz95.000webhostapp.com/program/DidzWWII-SQL-Web-Template-Leak/folder/optimum-motos.fr.txt");
			MessageBox.Show("La Source SQL Optimum-moto viens d'etre charger.\nCliquez sur le bouton Download/Télécharger.");
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002C5F File Offset: 0x00000E5F
		private void button43_Click(object sender, EventArgs e)
		{
			this.textsourcedownload.Text = this.WebClient.DownloadString("https://oldmodz95.000webhostapp.com/program/DidzWWII-SQL-Web-Template-Leak/folder/pignan.fr.txt");
			MessageBox.Show("La Source SQL Pignan viens d'etre charger.\nCliquez sur le bouton Download/Télécharger.");
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002C89 File Offset: 0x00000E89
		private void button46_Click(object sender, EventArgs e)
		{
			this.textsourcedownload.Text = this.WebClient.DownloadString("https://oldmodz95.000webhostapp.com/program/DidzWWII-SQL-Web-Template-Leak/folder/pro5.fr.txt");
			MessageBox.Show("La Source SQL Por5 viens d'etre charger.\nCliquez sur le bouton Download/Télécharger.");
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002CB3 File Offset: 0x00000EB3
		private void button29_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.amarillis.fr/");
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002CC1 File Offset: 0x00000EC1
		private void button32_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.amico-asso.fr/");
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002CCF File Offset: 0x00000ECF
		private void button35_Click(object sender, EventArgs e)
		{
			Process.Start("http://gfgsystems.fr/");
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002CDD File Offset: 0x00000EDD
		private void button38_Click(object sender, EventArgs e)
		{
			Process.Start("http://www.jobs.fr/jobs/affiche_annonce.php?id_annonce=7653");
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002CEB File Offset: 0x00000EEB
		private void button41_Click(object sender, EventArgs e)
		{
			Process.Start("http://optimum-motos.fr/");
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002CF9 File Offset: 0x00000EF9
		private void button44_Click(object sender, EventArgs e)
		{
			Process.Start("http://www.pignan.fr/");
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002D07 File Offset: 0x00000F07
		private void button47_Click(object sender, EventArgs e)
		{
			Process.Start("http://pro5.fr/");
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002D18 File Offset: 0x00000F18
		private void button30_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(this.textsourcedownload.Text);
					}
				}
			}
			MessageBox.Show("La Source SQL Amarillis viens d'etre télécharger.\nOuvrez le avec NotPad++ ou SublimText.");
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002DB4 File Offset: 0x00000FB4
		private void button33_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(this.textsourcedownload.Text);
					}
				}
			}
			MessageBox.Show("La Source SQL Amico-Asso viens d'etre télécharger.\nOuvrez le avec NotPad++ ou SublimText.");
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002E50 File Offset: 0x00001050
		private void button36_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(this.textsourcedownload.Text);
					}
				}
			}
			MessageBox.Show("La Source SQL gfgsystems viens d'etre télécharger.\nOuvrez le avec NotPad++ ou SublimText.");
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002EEC File Offset: 0x000010EC
		private void button39_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(this.textsourcedownload.Text);
					}
				}
			}
			MessageBox.Show("La Source SQL Jobs viens d'etre télécharger.\nOuvrez le avec NotPad++ ou SublimText.");
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002F88 File Offset: 0x00001188
		private void button42_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(this.textsourcedownload.Text);
					}
				}
			}
			MessageBox.Show("La Source SQL optimum-motos viens d'etre télécharger.\nOuvrez le avec NotPad++ ou SublimText.");
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003024 File Offset: 0x00001224
		private void button45_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(this.textsourcedownload.Text);
					}
				}
			}
			MessageBox.Show("La Source SQL Pignan viens d'etre télécharger.\nOuvrez le avec NotPad++ ou SublimText.");
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000030C0 File Offset: 0x000012C0
		private void button48_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
				{
					using (StreamWriter streamWriter = new StreamWriter(stream))
					{
						streamWriter.Write(this.textsourcedownload.Text);
					}
				}
			}
			MessageBox.Show("La Source SQL Pro5 viens d'etre télécharger.\nOuvrez le avec NotPad++ ou SublimText.");
		}

		// Token: 0x04000001 RID: 1
		private WebClient WebClient = new WebClient();
	}
}
