using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmAdmin
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void btnUsluge_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmUsluge frmUsluge = new FrmUsluge();

            frmUsluge.ShowDialog();

            this.Show();
        }

      
    }
}
