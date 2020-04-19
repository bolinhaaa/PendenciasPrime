using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PrimePendencias.Signup
{
    class Signup
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

        public Boolean Incluir(Signup s)
        {
            // criar string SQL
            String varSql = "INSERT INTO usuario (usuario, senha, nome) VALUES (@1, @2, @3)";

            // adicionar os parametros
            ListaParametros.Clear();

            ListaParametros.Add(new SqlParameter("@1", s.Usuario));
            ListaParametros.Add(new SqlParameter("@2", s.Senha));
            ListaParametros.Add(new SqlParameter("@3", s.Nome));
            
            return AcessoBD.Consultar(varSql, ListaParametros);
        }

        public Boolean Consultar(Signup s)
        {
            string varSqlConsulta = "SELECT * from usuario WHERE usuario=@1";

            ListaParametros.Clear();
            ListaParametros.Add(new SqlParameter("@1", s.usuario));

            return AcessoBD.Consultar(varSqlConsulta, ListaParametros);
        }
    }
}
