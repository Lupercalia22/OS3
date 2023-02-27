using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OS3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (webBrowser1.CanGoBack)
			{
				webBrowser1.GoBack();
			}
		}
		private void button2_Click(object sender, EventArgs e)
		{
			if (webBrowser1.CanGoForward)
			{
				webBrowser1.GoForward();
			}
		}
		private void button3_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			fbd.ShowDialog();
			if (fbd.ShowDialog() == DialogResult.OK)
			{
				webBrowser1.Url = new Uri(fbd.SelectedPath);
				textBox1.Text = fbd.SelectedPath;
			}
		}

		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if ((e.KeyCode == Keys.Enter) && (textBox1.Text != ""))
			{
				string txtbx = textBox1.Text;
				webBrowser1.Url = new Uri(txtbx);
				textBox1.Text = txtbx;
			}
		}
	}
}
