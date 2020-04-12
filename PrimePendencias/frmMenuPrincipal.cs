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

        private void AbrirFormSecundario(object frmSecundario)
        {
            if (this.panelPrincipal.Controls.Count > 0)
                this.panelPrincipal.Controls.RemoveAt(0);
            Form fh = frmSecundario as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(fh);
            this.panelPrincipal.Tag = fh;
            fh.Show();

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
            AbrirFormSecundario(new frmAddPendencias());
        }

        private void btnBuscarPendencias_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buscar Pendências");
            AbrirFormSecundario(new frmBuscarPrimeiro());
        }
        
        private void btnEditarStatusPendencias_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Editar Status Das Pendências");
            AbrirFormSecundario(new frmEditarStatusPendencia());
        }

        // CLASS DA DLL

    }
}
