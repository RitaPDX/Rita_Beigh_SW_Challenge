using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCards
	{
	public partial class frmHlp : Form
		{
		public frmHlp()
			{
			InitializeComponent();
			}

		private void rtbHlp_TextChanged(object sender, EventArgs e)
			{

			}

		private void btnCanx_Click(object sender, EventArgs e)
			{
			this.Visible = false;
			this.Dispose();
			}
		}
	}
