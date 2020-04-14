using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using center.Properties;
using LogIn_Theme_Dll_By_xVenoxi;
using MonoFlat;
using theme;

namespace center
{
	// Token: 0x02000004 RID: 4
	public partial class Form3 : Form
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00009F15 File Offset: 0x00008115
		public Form3()
		{
			this.InitializeComponent();
			this.heure.Start();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00009F48 File Offset: 0x00008148
		private void logInButton1_Click(object sender, EventArgs e)
		{
			this.Historique.AppendText("\r\nLa demande commence à " + this.time.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://api.c99.nl/skyperesolver?key=" + this.KeyAPI.Text + "&username=" + this.SkypeRR.Text);
			this.textBox2.Text = text;
			this.Historique.AppendText("\r\n----------------------Skype resolver-----------------------");
			this.Historique.AppendText("\r\nSkype Pseudo : " + this.SkypeRR.Text + "\r\n IP : " + this.textBox2.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient2 = new WebClient();
			string text2 = webClient2.DownloadString("https://api.c99.nl/ip2skype?key=" + this.KeyAPI.Text + "&ip=" + this.flatTextBox1.Text);
			this.textBox2.Text = text2;
			this.Historique.AppendText("\r\n----------------------IP VERS SKYPE-----------------------");
			this.Historique.AppendText("\r\nIP VERS SKYPE : " + this.flatTextBox1.Text + "\r\n Skype : " + this.textBox2.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient3 = new WebClient();
			string text3 = webClient3.DownloadString("https://api.c99.nl/email2skype?key=" + this.KeyAPI.Text + "&email=" + this.flatTextBox3.Text);
			this.textBox2.Text = text3;
			this.Historique.AppendText("\r\n----------------------Email vers skype--------------------");
			this.Historique.AppendText("\r\nEmail vers skype : " + this.flatTextBox3.Text + "\r\n Skype : " + this.textBox2.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient4 = new WebClient();
			string text4 = webClient4.DownloadString("https://api.c99.nl/emailvalidator?key=" + this.KeyAPI.Text + "&email=" + this.flatTextBox2.Text);
			this.textBox2.Text = text4;
			this.Historique.AppendText("\r\n---------------Verifier si l'email est bonne--------------");
			this.Historique.AppendText("\r\nVerifier si l'email est bonne : " + this.flatTextBox2.Text + "\r\n Information : " + this.textBox2.Text);
			this.Historique.AppendText("\r\n----------------------------------------------------------");
			WebClient webClient5 = new WebClient();
			string text5 = webClient5.DownloadString("https://api.c99.nl/ipvalidator?key=" + this.KeyAPI.Text + "&ip=" + this.flatTextBox8.Text);
			this.textBox2.Text = text5;
			this.Historique.AppendText("\r\n----------------------Validateur d'IP---------------------");
			this.Historique.AppendText("\r\nValidateur d'ip : " + this.flatTextBox8.Text + "\r\n Test IP : " + this.textBox2.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient6 = new WebClient();
			string text6 = webClient6.DownloadString("https://api.c99.nl/dnsresolver?key=" + this.KeyAPI.Text + "&host=" + this.flatTextBox4.Text);
			this.textBox2.Text = text6;
			this.Historique.AppendText("\r\n----------------------URL vers IP-------------------------");
			this.Historique.AppendText("\r\nURL vers IP : " + this.flatTextBox4.Text + "\r\n IP : " + this.textBox2.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient7 = new WebClient();
			string text7 = webClient7.DownloadString("https://api.c99.nl/geoip?key=" + this.KeyAPI.Text + "&host=" + this.flatTextBox15.Text);
			this.textBox2.Text = text7;
			this.Historique.AppendText("\r\n-------------------------Geo IP---------------------------");
			this.Historique.AppendText("\r\nGeo IP : " + this.flatTextBox15.Text + "\r\n Information : " + this.textBox2.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient8 = new WebClient();
			string text8 = webClient8.DownloadString("https://api.c99.nl/whois?key=" + this.KeyAPI.Text + "&domain=" + this.flatTextBox10.Text);
			this.textBox2.Text = text8;
			this.Historique.AppendText("\r\n---------------------Vérificateur Whois--------------------");
			this.Historique.AppendText("\r\nVérificateur Whois : " + this.flatTextBox10.Text + "\r\n Information : " + this.textBox2.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient9 = new WebClient();
			string text9 = webClient9.DownloadString("https://api.c99.nl/cfresolver?key=" + this.KeyAPI.Text + "&domain=" + this.flatTextBox14.Text);
			this.textBox2.Text = text9;
			this.Historique.AppendText("\r\n-----------------------Cloudfare-------------------------");
			this.Historique.AppendText("\r\nCloudfare : " + this.flatTextBox14.Text + "\r\n Information : " + this.textBox2.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient10 = new WebClient();
			string text10 = webClient10.DownloadString("https://api.c99.nl/proxydetector?key=" + this.KeyAPI.Text + "&ip=" + this.flatTextBox6.Text);
			this.textBox2.Text = text10;
			this.Historique.AppendText("\r\n-------------------Information Proxy----------------------");
			this.Historique.AppendText("\r\nInformation Proxy : " + this.flatTextBox6.Text + "\r\n Information : " + this.textBox2.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient11 = new WebClient();
			string text11 = webClient11.DownloadString("https://api.c99.nl/disposablemailchecker?key=" + this.KeyAPI.Text + "&email=" + this.flatTextBox7.Text);
			this.textBox2.Text = text11;
			this.Historique.AppendText("\r\n----------------------Email Jetable-----------------------");
			this.Historique.AppendText("\r\nemail jetable : " + this.flatTextBox7.Text + "\r\n Information : " + this.textBox2.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient12 = new WebClient();
			string text12 = webClient12.DownloadString("https://api.c99.nl/gethostname?key=" + this.KeyAPI.Text + "&host=" + this.flatTextBox5.Text);
			this.textBox2.Text = text12;
			this.Historique.AppendText("\r\n---------------------IP vers heberger---------------------");
			this.Historique.AppendText("\r\nIP vers heberger : " + this.flatTextBox5.Text + "\r\n Heberger : " + this.textBox2.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient13 = new WebClient();
			string text13 = webClient13.DownloadString("https://api.c99.nl/subdomainfinder?key=" + this.KeyAPI.Text + "&domain=" + this.flatTextBox12.Text);
			this.textBox2.Text = text13;
			this.Historique.AppendText("\r\n---------------Recherche de sous-domaine------------------");
			this.Historique.AppendText("\r\nRecherche de sous-domaine : " + this.flatTextBox12.Text + "\r\n Information : " + this.textBox2.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient14 = new WebClient();
			string text14 = webClient14.DownloadString("https://api.c99.nl/sharedhostfinder?key=" + this.KeyAPI.Text + "&host=" + this.flatTextBox13.Text);
			this.textBox2.Text = text14;
			this.Historique.AppendText("\r\n----------------Recherche d'hôte partagé------------------");
			this.Historique.AppendText("\r\nRecherche d'hôte partagé : " + this.flatTextBox13.Text + "\r\n Information D'hote : " + this.textBox2.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient15 = new WebClient();
			string text15 = webClient15.DownloadString("https://api.c99.nl/domainhistory?key=" + this.KeyAPI.Text + "&domain=" + this.flatTextBox11.Text);
			this.textBox2.Text = text15;
			this.Historique.AppendText("\r\n----------Vérification l'historique du domaine------------");
			this.Historique.AppendText("\r\nVérification l'historique du domaine : " + this.flatTextBox11.Text + "\r\n Information : " + this.textBox2.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient16 = new WebClient();
			string text16 = webClient16.DownloadString("https://api.c99.nl/nmap?key=" + this.KeyAPI.Text + "&host=" + this.flatTextBox9.Text);
			this.textBox2.Text = text16;
			this.Historique.AppendText("\r\n-----------------------Scanner Nmap------------------------");
			this.Historique.AppendText("\r\nScanner Nmap : " + this.flatTextBox9.Text + "\r\n Ouvert : " + this.textBox2.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient17 = new WebClient();
			string text17 = webClient17.DownloadString("https://webresolver.nl/api.php?key=" + this.KeyAPI2.Text + "&action=skype2email&string=" + this.flatTextBox17.Text);
			this.textBox2.Text = text17;
			this.Historique.AppendText("\r\n---------------------Skype vers Email---------------------");
			this.Historique.AppendText("\r\nSkype : " + this.flatTextBox17.Text + "\r\n Email : " + this.textBox2.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient18 = new WebClient();
			string text18 = webClient18.DownloadString("https://webresolver.nl/api.php?key=" + this.KeyAPI2.Text + "&action=header&string=" + this.flatTextBox16.Text);
			this.textBox2.Text = text17;
			this.Historique.AppendText("\r\n-------------------En-têtes de site Web-------------------");
			this.Historique.AppendText("\r\nSite : " + this.flatTextBox16.Text + "\r\n En-têtes du site Web : " + this.textBox2.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			this.Historique.AppendText("\r\n========================================");
			this.Historique.AppendText("\r\nToute les recherches sont terminé. Action fini à " + DateTime.Now.ToLongTimeString());
			this.Historique.AppendText("\r\n========================================");
			this.Historique.AppendText("\r\n========================================");
			this.Historique.AppendText("\r\nBy OldModz95 & ExoTiQueModz - Data Leak Avanacer ! ");
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000AA74 File Offset: 0x00008C74
		private void suppriméeLhistoriqueToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Historique.Clear();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000AA83 File Offset: 0x00008C83
		private void copierToutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Historique.Copy();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000AA92 File Offset: 0x00008C92
		private void toutSelectionnerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Historique.SelectAll();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000AAA1 File Offset: 0x00008CA1
		private void selectionToutCopierToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Historique.SelectAll();
			this.Historique.Copy();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000AABC File Offset: 0x00008CBC
		private void heure_Tick(object sender, EventArgs e)
		{
			this.time.Text = DateTime.Now.ToLongTimeString();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000AAE3 File Offset: 0x00008CE3
		private void flatClose1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000AAE8 File Offset: 0x00008CE8
		private void monoFlat_Button1_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Filter = "Text(*.txt)|*.txt";
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
				}
				string text = this.Historique.Text;
				File.WriteAllText(saveFileDialog.FileName, text);
				MessageBox.Show("Sauvegarde avec succée!\n" + saveFileDialog.FileName, "Data-leak", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000AB74 File Offset: 0x00008D74
		private void logInButton2_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog saveFileDialog = new SaveFileDialog())
			{
				saveFileDialog.Filter = "Text(*.txt)|*.txt";
				if (saveFileDialog.ShowDialog() == DialogResult.OK)
				{
				}
				string text = this.Historique.Text;
				File.WriteAllText(saveFileDialog.FileName, text);
				MessageBox.Show("Sauvegarde avec succée!\n" + saveFileDialog.FileName, "Data-leak", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x04000050 RID: 80
		private WebClient SkypeResolve1 = new WebClient();
	}
}
