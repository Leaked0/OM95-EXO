using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using MonoFlat;
using SQL_Web_Template_Leak.Properties;
using theme;

namespace SQL_Web_Template_Leak
{
	// Token: 0x02000004 RID: 4
	public partial class login : Form
	{
		// Token: 0x0600004B RID: 75 RVA: 0x0000C027 File Offset: 0x0000A227
		public login()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000C040 File Offset: 0x0000A240
		private void button19_Click(object sender, EventArgs e)
		{
			/*
			if (this.flatTextBox1.Text == (this.label3.Text ?? ""))
			{
				Form1 form = new Form1();
				form.Show();
				base.Visible = false;
			}
			else if (this.flatTextBox1.Text == (this.label2.Text ?? ""))
			{
				Form1 form = new Form1();
				form.Show();
				base.Visible = false;
			}
			else if (this.flatTextBox1.Text == (this.label5.Text ?? ""))
			{
				Form1 form = new Form1();
				form.Show();
				base.Visible = false;
			}
			else
			{
				this.label1.Visible = true;
			}
			*/
			Form1 form = new Form1();
			form.Show();
			base.Visible = false;
			MessageBox.Show("Shit code lol", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000C12C File Offset: 0x0000A32C
		private void label4_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/3t2568W");
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000C13A File Offset: 0x0000A33A
		private void licencetext_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/watch?v=vqEl36DIQmE");
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000C148 File Offset: 0x0000A348
		private void label1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Rejoins mon server dicord (clic sur le text a droite)\nPuis va sur la channel \ud83c\udf10sql-web-leak\ud83c\udf10\n\nAttention ! Il faut rester sur le server car les licences change !");
		}
	}
}
