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
            txtUsuario.BorderStyle = BorderStyle.None;
            txtSenha.PasswordChar = '*';
        }

        public static String varNome;
      
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
            if(txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtusuario_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;
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
            if(!String.IsNullOrWhiteSpace(txtUsuario.Text) && !String.IsNullOrWhiteSpace(txtSenha.Text))
            {
                login.User objUser = new login.User();

                objUser.Usuario = txtUsuario.Text;
                objUser.Senha = txtSenha.Text;

                // acesso ao banco
                if (objUser.Consultar(objUser))
                {
                    varNome = AcessoBD.dataTable.Rows[0][2].ToString();

                    frmPendenciasPrime formprincipal = new frmPendenciasPrime();
                    MessageBox.Show("Usuário Autenticado!");
                    this.Hide();
                    formprincipal.ShowDialog();
                    if (formprincipal.IsDisposed)
                        Close();
                }
                else
                {
                    MessageBox.Show("Usuário e/ou Senha não Encontrados.");
                }
            }
            else
            {
                MessageBox.Show("Usuário e/ou Senhas são Obrigatorios");
            }
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
