using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_Ball
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		int p = 5000;
		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
			{
				MessageBox.Show("No input detected!");
			}
			else
			{
				Random random = new Random();
				int num = random.Next(10000);
				if (p > num)
				{
					MessageBox.Show("YES!");
				}
				else
				{
					MessageBox.Show("NO!");
				}
			}
		}
	}
}
