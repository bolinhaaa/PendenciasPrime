using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimePendencias
{
    public partial class frmAddPendencias : Form
    {
        public frmAddPendencias()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtNumeroPendencia.Text);
            MessageBox.Show(txtPallet.Text);
            MessageBox.Show(txtStatus.Text);
        }
    }
}
