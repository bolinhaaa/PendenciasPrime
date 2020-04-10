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
    public partial class frmPendenciasPrime : Form
    {
        public frmPendenciasPrime()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnAddPendencias_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adicionar Pendencias");
        }

        private void btnBuscarPendencias_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buscar Pendências");
        }

        private void btnEditarStatusPendencias_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Editar Status Das Pendências");
        }

        // CLASS DA DLL

    }
}
