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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtusuario.BorderStyle = BorderStyle.None;
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtusuario_Enter(object sender, EventArgs e)
        {
            if(txtusuario.Text == "Usuario")
            {
                txtusuario.Text = "";
                txtusuario.ForeColor = Color.LightGray;
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if(txtusuario.Text == "")
            {
                txtusuario.Text = "Usuario";
                txtusuario.ForeColor = Color.DimGray;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if(txtSenha.Text == "Senha")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.LightGray;
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if(txtSenha.Text == "")
            {
                txtSenha.Text = "Senha";
                txtSenha.ForeColor = Color.DimGray;
                txtSenha.UseSystemPasswordChar = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmPendenciasPrime formprincipal = new frmPendenciasPrime();
            this.Hide();
            formprincipal.ShowDialog();
            this.Show();
        }

        private void linkCriarConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignup frmCriarconta = new frmSignup();
            this.Hide();
            frmCriarconta.ShowDialog();
            this.Show();         
        }
    }
}
