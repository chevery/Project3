using Project_3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form1 f = new Form1();
			f.ShowDialog();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form5 f = new Form5();
			f.ShowDialog();
		}
	}
}
