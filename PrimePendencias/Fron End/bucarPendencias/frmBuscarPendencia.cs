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
    public partial class frmBuscarPrimeiro : Form
    {
        public frmBuscarPrimeiro()
        {
            InitializeComponent();
        }

        private void Exibir()
        {
            lblPallet.Visible = true;
            lblPalletResultado.Visible = true;
            lblPalletResultado.Text = txtNumeroPendencia.Text;

            lblStatus.Visible = true;
            lblStatusResultado.Visible = true;
            lblStatusResultado.Text = "Removido";

            lblUsuario.Visible = true;
            lblResultadoUsuario.Visible = true;
            lblResultadoUsuario.Text = "Daniel";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Exibir();
        }
    }
}
