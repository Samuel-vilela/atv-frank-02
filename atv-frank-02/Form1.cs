using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atv_frank_02
{
    public partial class Ola : Form
    {
        public Ola()
        {
            InitializeComponent();
        }

        private void btnOii_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oi");
            MessageBox.Show("Tudo bem?");
        }
    }
}
