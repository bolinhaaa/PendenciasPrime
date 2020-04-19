using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PrimePendencias.login
{
    class User
    {
        #region campos da classe
        private String usuario;
        private String senha;
        private String nome;
        #endregion

        #region propriedades da classe
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        #endregion

        public static List<SqlParameter> ListaParametros = new List<SqlParameter>();

        public Boolean Consultar(User u)
        {
            //criar string SQL
            String varSql = "SELECT usuario, senha, nome FROM usuario WHERE usuario=@1 AND senha=@2";

            // adicionar os parametros
            ListaParametros.Clear();

            ListaParametros.Add(new SqlParameter("@1", u.Usuario));
            ListaParametros.Add(new SqlParameter("@2", u.Senha));

            return AcessoBD.Consultar(varSql, ListaParametros);
        }
    }
}
