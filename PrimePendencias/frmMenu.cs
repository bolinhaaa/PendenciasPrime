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

        public Boolean varSaida = true;

      
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

        private void picHome_Click(object sender, EventArgs e)
        {
            AbrirFormSecundario(new homePendencias());
        }

        private void frmPendenciasPrime_Load(object sender, EventArgs e)
        {
            picHome_Click(null, e);

            lblUsuario.Text = frmLogin.varNome;
        }

        private void frmPendenciasPrime_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }

        private void frmPendenciasPrime_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }
    }
}
