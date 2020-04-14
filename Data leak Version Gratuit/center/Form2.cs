using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using center.Properties;
using LogIn_Theme_Dll_By_xVenoxi;
using MonoFlat;
using theme;

namespace center
{
	// Token: 0x02000003 RID: 3
	public partial class Form2 : Form
	{
		// Token: 0x06000008 RID: 8 RVA: 0x00002C6C File Offset: 0x00000E6C
		public Form2()
		{
			this.InitializeComponent();
			this.dateheure.Start();
			this.logInComboBox9.Enabled = false;
			this.logInButton7.Enabled = false;
			this.motsdepasse.Enabled = false;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002CDC File Offset: 0x00000EDC
		private void logInButton1_Click(object sender, EventArgs e)
		{
			if (this.logInComboBox2.SelectedIndex == 0)
			{
				WebClient webClient = new WebClient();
				string text = webClient.DownloadString("https://api.c99.nl/skyperesolver?key=" + this.KeyAPI.Text + "&username=" + this.SkypeR.Text);
				this.textBox1.Text = text;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander Skype resolver-----");
				this.Historique.AppendText("\r\nSkype Pseudo : " + this.SkypeR.Text + "\r\n IP : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + DateTime.Now.ToLongTimeString());
			}
			if (this.logInComboBox2.SelectedIndex == 1)
			{
				WebClient webClient2 = new WebClient();
				string text2 = webClient2.DownloadString("https://api.c99.nl/ip2skype?key=" + this.KeyAPI.Text + "&ip=" + this.SkypeR.Text);
				this.textBox1.Text = text2;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander IP VERS SKYPE-----");
				this.Historique.AppendText("\r\nIP : " + this.SkypeR.Text + "\r\n Skype : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + DateTime.Now.ToLongTimeString());
			}
			if (this.logInComboBox2.SelectedIndex == 2)
			{
				WebClient webClient3 = new WebClient();
				string text3 = webClient3.DownloadString("https://api.c99.nl/email2skype?key=" + this.KeyAPI.Text + "&email=" + this.SkypeR.Text);
				this.textBox1.Text = text3;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander Email vers skype-----");
				this.Historique.AppendText("\r\nEmail Skype : " + this.SkypeR.Text + "\r\n Skype : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + DateTime.Now.ToLongTimeString());
			}
			if (this.logInComboBox2.SelectedIndex == 3)
			{
				WebClient webClient4 = new WebClient();
				string text4 = webClient4.DownloadString("https://webresolver.nl/api.php?key=" + this.KeyAPI2.Text + "&action=skype2email&string=" + this.SkypeR.Text);
				this.textBox1.Text = text4;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander Skype vers Email-----");
				this.Historique.AppendText("\r\nSkype : " + this.SkypeR.Text + "\r\n Email : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + DateTime.Now.ToLongTimeString());
			}
			if (this.logInComboBox2.SelectedIndex == 4)
			{
				WebClient webClient4 = new WebClient();
				string text4 = webClient4.DownloadString("https://api.c99.nl/skypecheck?key=" + this.KeyAPI.Text + "&username=" + this.SkypeR.Text);
				this.textBox1.Text = text4;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander Verificateur skype-----");
				this.Historique.AppendText("\r\nVerification : " + this.SkypeR.Text + "\r\n Bon/ou pas : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + DateTime.Now.ToLongTimeString());
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00003214 File Offset: 0x00001414
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00003218 File Offset: 0x00001418
		private void logInButton2_Click(object sender, EventArgs e)
		{
			if (this.logInComboBox3.SelectedIndex == 0)
			{
				WebClient webClient = new WebClient();
				string text = webClient.DownloadString("https://api.c99.nl/phonelookup?key=" + this.KeyAPI.Text + "&number=" + this.Telephonemail.Text);
				this.textBox1.Text = text;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n----Action Demander Information d'un numéro de téléphone---");
				this.Historique.AppendText("\r\nNumero : " + this.Telephonemail.Text + "\r\n Information : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + DateTime.Now.ToLongTimeString());
			}
			if (this.logInComboBox3.SelectedIndex == 1)
			{
				WebClient webClient = new WebClient();
				string text = webClient.DownloadString("https://api.c99.nl/emailvalidator?key=" + this.KeyAPI.Text + "&email=" + this.Telephonemail.Text);
				this.textBox1.Text = text;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander Verifier si l'email existe-----");
				this.Historique.AppendText("\r\nEmail : " + this.Telephonemail.Text + "\r\n Information : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + DateTime.Now.ToLongTimeString());
			}
			if (this.logInComboBox3.SelectedIndex == 2)
			{
				WebClient webClient = new WebClient();
				string text = webClient.DownloadString("https://api.c99.nl/disposablemailchecker?key=" + this.KeyAPI.Text + "&email=" + this.Telephonemail.Text);
				this.textBox1.Text = text;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander Email jetable ou non-----");
				this.Historique.AppendText("\r\nEmail : " + this.Telephonemail.Text + "\r\n Information : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + DateTime.Now.ToLongTimeString());
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000352C File Offset: 0x0000172C
		private void logInButton3_Click(object sender, EventArgs e)
		{
			if (this.logInComboBox4.SelectedIndex == 0)
			{
				WebClient webClient = new WebClient();
				string text = webClient.DownloadString("https://api.c99.nl/proxydetector?key=" + this.KeyAPI.Text + "&ip=" + this.flatTextBox4.Text);
				this.textBox1.Text = text;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander Information Proxy-----");
				this.Historique.AppendText("\r\nIP : " + this.flatTextBox4.Text + "\r\n Information : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + DateTime.Now.ToLongTimeString());
			}
			if (this.logInComboBox4.SelectedIndex == 1)
			{
				WebClient webClient2 = new WebClient();
				string text2 = webClient2.DownloadString("https://api.c99.nl/torchecker?key=" + this.KeyAPI.Text + "&ip=" + this.flatTextBox4.Text);
				this.textBox1.Text = text2;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-Action Demander Vérifier si L'IP provient d'un réseau TOR-");
				this.Historique.AppendText("\r\nIP : " + this.flatTextBox4.Text + "\r\n IP TOR ou Pas : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + DateTime.Now.ToLongTimeString());
			}
			if (this.logInComboBox4.SelectedIndex == 2)
			{
				WebClient webClient3 = new WebClient();
				string text3 = webClient3.DownloadString("https://api.c99.nl/ipvalidator?key=" + this.KeyAPI.Text + "&ip=" + this.flatTextBox4.Text);
				this.textBox1.Text = text3;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action DemanderValidateur d'ip-----");
				this.Historique.AppendText("\r\nIP : " + this.flatTextBox4.Text + "\r\n Test IP : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + DateTime.Now.ToLongTimeString());
			}
			if (this.logInComboBox4.SelectedIndex == 3)
			{
				WebClient webClient4 = new WebClient();
				string text4 = webClient4.DownloadString("https://api.c99.nl/dnsresolver?key=" + this.KeyAPI.Text + "&host=" + this.flatTextBox4.Text);
				this.textBox1.Text = text4;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander URL vers IP-----");
				this.Historique.AppendText("\r\nSite : " + this.flatTextBox4.Text + "\r\n IP : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + DateTime.Now.ToLongTimeString());
			}
			if (this.logInComboBox4.SelectedIndex == 4)
			{
				WebClient webClient5 = new WebClient();
				string text5 = webClient5.DownloadString("https://api.c99.nl/gethostname?key=" + this.KeyAPI.Text + "&host=" + this.flatTextBox4.Text);
				this.textBox1.Text = text5;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander IP vers heberger-----");
				this.Historique.AppendText("\r\nIP : " + this.flatTextBox4.Text + "\r\n Heberger : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + DateTime.Now.ToLongTimeString());
			}
			if (this.logInComboBox4.SelectedIndex == 5)
			{
				WebClient webClient6 = new WebClient();
				string text6 = webClient6.DownloadString("https://api.c99.nl/nmap?key=" + this.KeyAPI.Text + "&host=" + this.flatTextBox4.Text);
				this.textBox1.Text = text6;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander Scanner Nmap-----");
				this.Historique.AppendText("\r\nPort : " + this.flatTextBox4.Text + "\r\n Ouvert : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + DateTime.Now.ToLongTimeString());
			}
			if (this.logInComboBox4.SelectedIndex == 6)
			{
				WebClient webClient7 = new WebClient();
				string text7 = webClient7.DownloadString(string.Concat(new string[]
				{
					"https://api.c99.nl/portscanner?key=",
					this.KeyAPI.Text,
					"&host=",
					this.flatTextBox4.Text,
					"&port=",
					this.flatTextBox2.Text
				}));
				this.textBox1.Text = text7;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + this.time.Text);
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander Scanner à port unique-----");
				this.Historique.AppendText(string.Concat(new string[]
				{
					"\r\nIP: ",
					this.flatTextBox4.Text,
					" Port : ",
					this.flatTextBox2.Text,
					"\r\n",
					this.textBox1.Text
				}));
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + DateTime.Now.ToLongTimeString());
			}
			if (this.logInComboBox4.SelectedIndex == 7)
			{
				WebClient webClient8 = new WebClient();
				string text8 = webClient8.DownloadString("https://api.c99.nl/portscanner?key=" + this.KeyAPI.Text + "&host=" + this.flatTextBox4.Text);
				this.textBox1.Text = text8;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + this.time.Text);
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander Scanner à ports multiples-----");
				this.Historique.AppendText("\r\nIP : " + this.flatTextBox4.Text + "\r\n Port : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + DateTime.Now.ToLongTimeString());
			}
			if (this.logInComboBox4.SelectedIndex == 8)
			{
				WebClient webClient = new WebClient();
				string text = webClient.DownloadString("https://webresolver.nl/api.php?key=" + this.KeyAPI2.Text + "&action=header&string=" + this.flatTextBox4.Text);
				this.textBox1.Text = text;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander Skype Information Proxy-----");
				this.Historique.AppendText("\r\nSite : " + this.flatTextBox4.Text + "\r\n Information : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + DateTime.Now.ToLongTimeString());
			}
			if (this.logInComboBox5.SelectedIndex == 9)
			{
				WebClient webClient9 = new WebClient();
				string text9 = webClient9.DownloadString("https://api.c99.nl/iplogger?key=" + this.KeyAPI.Text + "&videoid=" + this.flatTextBox3.Text);
				this.textBox1.Text = text9;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander Ping-----");
				this.Historique.AppendText(string.Concat(new string[]
				{
					"\r\nIP Logger : ",
					this.flatTextBox4.Text,
					"\r\nAucune idée mdr ",
					this.flatTextBox2.Text,
					"\r\n Information : ",
					this.textBox1.Text
				}));
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + DateTime.Now.ToLongTimeString());
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00004023 File Offset: 0x00002223
		private void suppriméeLhistoriqueToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Historique.Clear();
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00004034 File Offset: 0x00002234
		private void logInButton4_Click(object sender, EventArgs e)
		{
			if (this.logInComboBox5.SelectedIndex == 0)
			{
				WebClient webClient = new WebClient();
				string text = webClient.DownloadString("https://api.c99.nl/geoip?key=" + this.KeyAPI.Text + "&host=" + this.flatTextBox3.Text);
				this.textBox1.Text = text;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander Géo IP-----");
				this.Historique.AppendText("\r\nIP : " + this.flatTextBox3.Text + "\r\n Information : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + DateTime.Now.ToLongTimeString());
			}
			if (this.logInComboBox5.SelectedIndex == 1)
			{
				WebClient webClient = new WebClient();
				string text = webClient.DownloadString("https://webresolver.nl/api.php?key=" + this.KeyAPI2.Text + "&action=geoip&string=" + this.flatTextBox3.Text);
				this.textBox1.Text = text;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander Géo Web-----");
				this.Historique.AppendText("\r\nSite : " + this.flatTextBox3.Text + "\r\n Information : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + DateTime.Now.ToLongTimeString());
			}
			if (this.logInComboBox5.SelectedIndex == 2)
			{
				WebClient webClient2 = new WebClient();
				string text2 = webClient2.DownloadString("https://api.c99.nl/cfresolver?key=" + this.KeyAPI.Text + "&domain=" + this.flatTextBox3.Text);
				this.textBox1.Text = text2;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander Cloudfare-----");
				this.Historique.AppendText("\r\nSite : " + this.flatTextBox3.Text + "\r\n Information : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + DateTime.Now.ToLongTimeString());
			}
			if (this.logInComboBox5.SelectedIndex == 3)
			{
				WebClient webClient3 = new WebClient();
				string text3 = webClient3.DownloadString("https://api.c99.nl/alexarank?key=" + this.KeyAPI.Text + "&url=" + this.flatTextBox3.Text);
				this.textBox1.Text = text3;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander Alexa Rank Checker-----");
				this.Historique.AppendText("\r\nSite : " + this.flatTextBox3.Text + "\r\n Information : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + DateTime.Now.ToLongTimeString());
			}
			if (this.logInComboBox5.SelectedIndex == 4)
			{
				WebClient webClient4 = new WebClient();
				string text4 = webClient4.DownloadString("https://api.c99.nl/whois?key=" + this.KeyAPI.Text + "&domain=" + this.flatTextBox3.Text);
				this.textBox1.Text = text4;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander Vérificateur Whois-----");
				this.Historique.AppendText("\r\nSite : " + this.flatTextBox3.Text + "\r\n Information : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + DateTime.Now.ToLongTimeString());
			}
			if (this.logInComboBox5.SelectedIndex == 5)
			{
				WebClient webClient3 = new WebClient();
				string text3 = webClient3.DownloadString("https://api.c99.nl/subdomainfinder?key=" + this.KeyAPI.Text + "&domain=" + this.flatTextBox3.Text);
				this.textBox1.Text = text3;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander Recherche de sous-domaine-----");
				this.Historique.AppendText("\r\nSite : " + this.flatTextBox3.Text + "\r\n Information : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + DateTime.Now.ToLongTimeString());
			}
			if (this.logInComboBox5.SelectedIndex == 6)
			{
				WebClient webClient5 = new WebClient();
				string text5 = webClient5.DownloadString("https://api.c99.nl/domainhistory?key=" + this.KeyAPI.Text + "&domain=" + this.flatTextBox3.Text);
				this.textBox1.Text = text5;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n---Action Demander Vérification l'historique du domaine----");
				this.Historique.AppendText("\r\nSite : " + this.flatTextBox3.Text + "\r\n Information : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + DateTime.Now.ToLongTimeString());
			}
			if (this.logInComboBox5.SelectedIndex == 7)
			{
				WebClient webClient6 = new WebClient();
				string text6 = webClient6.DownloadString("https://api.c99.nl/sharedhostfinder?key=" + this.KeyAPI.Text + "&host=" + this.flatTextBox3.Text);
				this.textBox1.Text = text6;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander Recherche d'hôte partagé-----");
				this.Historique.AppendText("\r\nSite : " + this.flatTextBox3.Text + "\r\n Information : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + DateTime.Now.ToLongTimeString());
			}
			if (this.logInComboBox5.SelectedIndex == 8)
			{
				WebClient webClient7 = new WebClient();
				string text7 = webClient7.DownloadString("https://api.c99.nl/youtubedetails?key=" + this.KeyAPI.Text + "&videoid=" + this.flatTextBox3.Text);
				this.textBox1.Text = text7;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander Skype YouTbe Convertisseur-----");
				this.Historique.AppendText("\r\nSite : " + this.flatTextBox3.Text + "\r\n Information : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + DateTime.Now.ToLongTimeString());
			}
			if (this.logInComboBox5.SelectedIndex == 9)
			{
				WebClient webClient7 = new WebClient();
				string text7 = webClient7.DownloadString("https://webresolver.nl/api.php?key=" + this.KeyAPI2.Text + "&action=ping&string=" + this.flatTextBox3.Text);
				this.textBox1.Text = text7;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander ping (IP OU SITE)-----");
				this.Historique.AppendText("\r\nSite : " + this.flatTextBox3.Text + "\r\n Information : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + this.time.Text);
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00004A98 File Offset: 0x00002C98
		private void monoFlat_Button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show(this.textBox2.Text);
			MessageBox.Show(this.textBox3.Text);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00004AC0 File Offset: 0x00002CC0
		private void logInButton5_Click(object sender, EventArgs e)
		{
			if (this.logInComboBox6.SelectedIndex == 0)
			{
				WebClient webClient = new WebClient();
				string text = webClient.DownloadString("https://api.c99.nl/smsreceiver?key=" + this.KeyAPI.Text + "&country=" + this.logInComboBox7.Text);
				this.textBox1.Text = text;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander Sms receiver-----");
				this.Historique.AppendText("\r\nPayes : " + this.logInComboBox7.Text + "\r\n SMS : " + this.textBox1.Text);
				this.Historique.AppendText("\r\nRelancer a chaque fois refresh pour voir les messages");
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + this.time.Text);
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00004BE0 File Offset: 0x00002DE0
		private void logInButton6_Click(object sender, EventArgs e)
		{
			if (this.logInComboBox8.SelectedIndex == 0)
			{
				WebClient webClient = new WebClient();
				string text = webClient.DownloadString("https://api.c99.nl/bitcoinbalance?key=" + this.KeyAPI.Text + "&address=" + this.flatTextBox5.Text);
				this.textBox1.Text = text;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander Vérificateur de solde Bitcoin-----");
				this.Historique.AppendText("\r\nAdresse BTC : " + this.flatTextBox5.Text + "\r\n INFO : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + this.time.Text);
			}
			if (this.logInComboBox8.SelectedIndex == 1)
			{
				WebClient webClient = new WebClient();
				string text = webClient.DownloadString("https://api.c99.nl/bitcoinaccelerator?key=" + this.KeyAPI.Text + "&txn_id=" + this.flatTextBox5.Text);
				this.textBox1.Text = text;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n---Action Demander Accélérateur de transactions Bitcoin----");
				this.Historique.AppendText("\r\nBitcoin : " + this.flatTextBox5.Text + "\r\n INFO : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + this.time.Text);
			}
			if (this.logInComboBox8.SelectedIndex == 2)
			{
				WebClient webClient = new WebClient();
				string text = webClient.DownloadString("https://api.c99.nl/ethereumbalance?key=" + this.KeyAPI.Text + "&address=" + this.flatTextBox5.Text);
				this.textBox1.Text = text;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander Ethereum Balance Checker-----");
				this.Historique.AppendText("\r\nEthereum : " + this.flatTextBox5.Text + "\r\n INFO : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + this.time.Text);
			}
			if (this.logInComboBox8.SelectedIndex == 3)
			{
				WebClient webClient = new WebClient();
				string text = webClient.DownloadString("https://api.c99.nl/currency?key=" + this.KeyAPI.Text + "&amount=123&from=USD&to=" + this.flatTextBox5.Text);
				this.textBox1.Text = text;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander Convertisseur de devises-----");
				this.Historique.AppendText("\r\nDevice : " + this.flatTextBox5.Text + "\r\n INFO : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + this.time.Text);
			}
			if (this.logInComboBox8.SelectedIndex == 4)
			{
				WebClient webClient = new WebClient();
				string text = webClient.DownloadString("https://api.c99.nl/currencyrates?key=" + this.KeyAPI.Text + "&source=" + this.flatTextBox5.Text);
				this.textBox1.Text = text;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander Taux de change-----");
				this.Historique.AppendText("\r\nTaux : " + this.flatTextBox5.Text + "\r\n INFO : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + this.time.Text);
			}
			if (this.logInComboBox8.SelectedIndex == 5)
			{
				WebClient webClient = new WebClient();
				string text = webClient.DownloadString("https://webresolver.nl/api.php?key=" + this.KeyAPI2.Text + "&action=whois&string=" + this.flatTextBox5.Text);
				this.textBox1.Text = text;
				this.Historique.AppendText("\r\nAction Demander le " + this.date.Text + " à " + DateTime.Now.ToLongTimeString());
				this.Historique.AppendText("\r\n-----------------------------------------------------------");
				this.Historique.AppendText("\r\n-----Action Demander Site Whois-----");
				this.Historique.AppendText("\r\nSite : " + this.flatTextBox5.Text + "\r\n INFO : " + this.textBox1.Text);
				this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + this.time.Text + this.time.Text);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000051FC File Offset: 0x000033FC
		private void monoFlat_Button2_Click(object sender, EventArgs e)
		{
			Form3 form = new Form3();
			form.Show();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00005217 File Offset: 0x00003417
		private void toutSelectionCopierToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Historique.SelectAll();
			this.Historique.Copy();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00005232 File Offset: 0x00003432
		private void selectionToutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Historique.SelectAll();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00005241 File Offset: 0x00003441
		private void copierToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Historique.Copy();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00005250 File Offset: 0x00003450
		private void dateheure_Tick(object sender, EventArgs e)
		{
			this.date.Text = DateTime.Now.ToLongDateString();
			this.time.Text = DateTime.Now.ToLongTimeString();
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00005290 File Offset: 0x00003490
		private void monoFlat_ThemeContainer1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00005293 File Offset: 0x00003493
		private void monoFlat_LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			MessageBox.Show("Envoyer a c'est email : exoti2b@gmail.com : ou alors : https://paypal.me/oldmodz95 ");
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000052A4 File Offset: 0x000034A4
		private void monoFlat_Button3_Click(object sender, EventArgs e)
		{
			this.Historique.AppendText("\r\n-------------------Vérification des APIS-------------------");
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/Accelerateur%20de%20transactions%20Bitcoin.txt");
			this.textBox1.Text = text;
			this.Historique.AppendText("\r\nAccelerateur de transactions Bitcoin : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient2 = new WebClient();
			string text2 = webClient2.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/Alexa%20Rank%20Checker.txt");
			this.textBox1.Text = text2;
			this.Historique.AppendText("\r\nAlexa Rank Checker : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient3 = new WebClient();
			string text3 = webClient3.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/Convertisseur%20de%20devises.txt");
			this.textBox1.Text = text3;
			this.Historique.AppendText("\r\nConvertisseur de devises : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient4 = new WebClient();
			string text4 = webClient4.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/Convertisseur%20de%20devises.txt");
			this.textBox1.Text = text4;
			this.Historique.AppendText("\r\nDétecteur de proxy & VPN : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient5 = new WebClient();
			string text5 = webClient5.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/Email%20vers%20Skype.txt");
			this.textBox1.Text = text5;
			this.Historique.AppendText("\r\nEmail vers Skype : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient6 = new WebClient();
			string text6 = webClient5.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/En-t%eates%20de%20site%20Web.txt");
			this.textBox1.Text = text6;
			this.Historique.AppendText("\r\nEn-têtes de site Web : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient7 = new WebClient();
			string text7 = webClient7.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/Ethereum%20Balance%20Checker.txt");
			this.textBox1.Text = text7;
			this.Historique.AppendText("\r\nEthereum Balance Checker : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient8 = new WebClient();
			string text8 = webClient8.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/GeoIP.txt");
			this.textBox1.Text = text8;
			this.Historique.AppendText("\r\nGéo IP : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient9 = new WebClient();
			string text9 = webClient7.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/GeoWeb.txt");
			this.textBox1.Text = text7;
			this.Historique.AppendText("\r\nGéo WEB : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient10 = new WebClient();
			string text10 = webClient10.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/IP%20Loggers.txt");
			this.textBox1.Text = text10;
			this.Historique.AppendText("\r\nIP Logger : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient11 = new WebClient();
			string text11 = webClient11.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/IP%20vers%20Skype.txt");
			this.textBox1.Text = text11;
			this.Historique.AppendText("\r\nIP vers skype : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient12 = new WebClient();
			string text12 = webClient12.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/IP%20vers%20h%e9berger.txt");
			this.textBox1.Text = text12;
			this.Historique.AppendText("\r\nIP vers héberger : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient13 = new WebClient();
			string text13 = webClient13.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/Ping.txt");
			this.textBox1.Text = text13;
			this.Historique.AppendText("\r\nIP vers skype : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient14 = new WebClient();
			string text14 = webClient14.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/Recherche%20de%20sous-domaine.txt");
			this.textBox1.Text = text14;
			this.Historique.AppendText("\r\nRecherche desous-domaine : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient15 = new WebClient();
			string text15 = webClient15.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/Recherche%20dhote%20partage.txt");
			this.textBox1.Text = text15;
			this.Historique.AppendText("\r\nRecherche d'hote partagé : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient16 = new WebClient();
			string text16 = webClient16.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/Resolveur%20CloudFlare.txt");
			this.textBox1.Text = text16;
			this.Historique.AppendText("\r\nResolver cloudflare : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient17 = new WebClient();
			string text17 = webClient17.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/SMS%20Receiver.txt");
			this.textBox1.Text = text17;
			this.Historique.AppendText("\r\nSMS receiver : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient18 = new WebClient();
			string text18 = webClient18.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/Scanner%20%e0%20ports%20multiples.txt");
			this.textBox1.Text = text18;
			this.Historique.AppendText("\r\nScan port multiples : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient19 = new WebClient();
			string text19 = webClient19.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/Scanner%20%e0%20port%20unique.txt");
			this.textBox1.Text = text19;
			this.Historique.AppendText("\r\nScan a port unique : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient20 = new WebClient();
			string text20 = webClient20.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/Scanner%20Nmap.txt");
			this.textBox1.Text = text20;
			this.Historique.AppendText("\r\nScan Nmap : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient21 = new WebClient();
			string text21 = webClient21.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/Site%20Whois%202.txt");
			this.textBox1.Text = text21;
			this.Historique.AppendText("\r\nSite whois : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient22 = new WebClient();
			string text22 = webClient22.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/Skype%20Resolver.txt");
			this.textBox1.Text = text22;
			this.Historique.AppendText("\r\nSkype resolver : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient23 = new WebClient();
			string text23 = webClient23.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/Skype%20vers%20Email.txt");
			this.textBox1.Text = text23;
			this.Historique.AppendText("\r\nSkype vers email : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient24 = new WebClient();
			string text24 = webClient24.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/Taux%20de%20change.txt");
			this.textBox1.Text = text24;
			this.Historique.AppendText("\r\nTaux de chance : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient25 = new WebClient();
			string text25 = webClient25.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/URL%20d'un%20site%20vers%20IP.txt");
			this.textBox1.Text = text25;
			this.Historique.AppendText("\r\nSite vers IP : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient26 = new WebClient();
			string text26 = webClient26.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/V%e9rificateur%20Whois.txt");
			this.textBox1.Text = text26;
			this.Historique.AppendText("\r\nVérificateur de whois : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient27 = new WebClient();
			string text27 = webClient27.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/V%e9rification%20Skype.txt");
			this.textBox1.Text = text27;
			this.Historique.AppendText("\r\nVérificateur skype : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient28 = new WebClient();
			string text28 = webClient28.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/V%e9rification%20l'historique%20du%20domaine.txt");
			this.textBox1.Text = text28;
			this.Historique.AppendText("\r\nHistorique d'un domaine : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient29 = new WebClient();
			string text29 = webClient29.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/V%e9rifier%20si%20L'IP%20provient%20d'un%20r%e9seau%20TOR.txt");
			this.textBox1.Text = text29;
			this.Historique.AppendText("\r\nVérifier si l'ip vient d'un serveur TOR : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient30 = new WebClient();
			string text30 = webClient30.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/V%e9rifier%20si%20l'email%20est%20%20jetable.txt");
			this.textBox1.Text = text30;
			this.Historique.AppendText("\r\nVérifier si l'email et jetable : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient31 = new WebClient();
			string text31 = webClient31.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/V%e9rifier%20si%20l'email%20existe.txt");
			this.textBox1.Text = text31;
			this.Historique.AppendText("\r\nVérifier si l'email exsite : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient32 = new WebClient();
			string text32 = webClient32.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/Validateur%20IP.txt");
			this.textBox1.Text = text32;
			this.Historique.AppendText("\r\nValidateur D'IP : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient33 = new WebClient();
			string text33 = webClient33.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/Verificateur%20de%20solde%20Bitcoin.txt");
			this.textBox1.Text = text33;
			this.Historique.AppendText("\r\nVérificateur de solde bitcoin : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			WebClient webClient34 = new WebClient();
			string text34 = webClient34.DownloadString("https://oldmodz95.000webhostapp.com/program/data-leak/API/Youtube%20recuperer%20la%20desciption%20d'un%20video.txt");
			this.textBox1.Text = text34;
			this.Historique.AppendText("\r\nRécupérer une discription d'un vidéo : " + this.textBox1.Text);
			this.Historique.AppendText("\r\n-----------------------------------------------------------");
			this.Historique.AppendText("\r\n---------ACTION FINI A-----------" + DateTime.Now.ToLongTimeString());
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00005E29 File Offset: 0x00004029
		private void logInButton7_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0400000D RID: 13
		private WebClient SkypeResolve1 = new WebClient();

		// Token: 0x0400000E RID: 14
		private WebClient combo1 = new WebClient();
	}
}
