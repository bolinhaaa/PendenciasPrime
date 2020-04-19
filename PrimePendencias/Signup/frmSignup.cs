using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace PrimePendencias
{
    public partial class frmSignup : Form
    {
        public frmSignup()
        {
            InitializeComponent();
        }

        private void linkEntrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Signup.Signup objSignup = new Signup.Signup();

        private void Converter()
        {
            objSignup.Usuario = txtusuario.Text;
            objSignup.Senha = txtSenha.Text;
            objSignup.Nome = txtNome.Text;
        }

        private void Clear()
        {
            txtNome.Text = "";
            txtSenha.Text = "";
            txtusuario.Text = "";
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtusuario.Text) && !String.IsNullOrWhiteSpace(txtSenha.Text) && !String.IsNullOrWhiteSpace(txtNome.Text))
            {
                Converter();

                if (!objSignup.Incluir(objSignup))
                {
                    MessageBox.Show("Conta criada com sucesso!", "CADASTRO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Clear();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário já existet", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Usuário, Senha e/ou Nome  são Obrigatorios");
            }
            
        }

        private void Liberar()
        {
            txtusuario.Enabled = false;
            txtSenha.Enabled = true;
            txtNome.Enabled = true;
            picCheck.Enabled = false;
            btnCriar.Enabled = true;
        }

        private void picCheck_Click(object sender, EventArgs e)
        {
            objSignup.Usuario = txtusuario.Text;
            if (objSignup.Consultar(objSignup))
            {
                MessageBox.Show("Usuário já cadastrado", "Verifica Usuário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Usuário Disponivél", "Verifica Usuário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Liberar();
            }
        }
    }
}
