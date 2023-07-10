using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tacotito_s.Views
{
	public partial class FormRoot : Form
	{
		public FormRoot()
		{
			InitializeComponent();
		}

		private void venderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm = new FormCreateTaco();
			frm.ShowDialog();
		}
	}
}
