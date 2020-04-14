using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using center.Properties;
using LogIn_Theme_Dll_By_xVenoxi;
using MonoFlat;
using theme;

namespace center
{
	// Token: 0x02000002 RID: 2
	public partial class Form1 : Form
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Form1()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000206C File Offset: 0x0000026C
		private void monoFlat_Button1_Click(object sender, EventArgs e)
		{
			/*
			 if (this.flatTextBox1.Text == "118999994743596248448716853899")
			{
				Form2 form = new Form2();
				form.Show();
				base.Visible = false;
			}
			else if (this.flatTextBox1.Text == "006368901757484500636890175748")
			{
				Form2 form = new Form2();
				form.Show();
				base.Visible = false;
			}
			else if (this.flatTextBox1.Text == "991462759410002223379456678110")
			{
				Form2 form = new Form2();
				form.Show();
				base.Visible = false;
			}
			else if (this.flatTextBox1.Text == "616330887043497218282364348784")
			{
				Form2 form = new Form2();
				form.Show();
				base.Visible = false;
			}
			else if (this.flatTextBox1.Text == "1231981981981981981981298298298198198298")
			{
				Form2 form = new Form2();
				form.Show();
				base.Visible = false;
			}
			else
			{
				this.monoFlat_Label1.Text = "Licence incorrecte !!!";
			}
			*/
			Form2 form = new Form2();
			form.Show();
			base.Visible = false;
			MessageBox.Show("Shit code lol", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000219C File Offset: 0x0000039C
		private void monoFlat_CheckBox1_CheckedChanged(object sender)
		{
			this.flatTextBox1.UseSystemPasswordChar = false;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000021AC File Offset: 0x000003AC
		private void monoFlat_ThemeContainer1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021AF File Offset: 0x000003AF
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://www.facebook.com/ExoTiQueMoDz/");
			Process.Start("https://www.facebook.com/OldModz95Ytb/");
		}
	}
}
