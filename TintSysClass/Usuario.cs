using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TintSysClass
{
    public class Usuario
    {
        // Atributos
        private int id;
        private string nome;
        private string email;
        private string senha;
        private Nivel nivel;
        private bool ativo;


        // Propriedades
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public Nivel Nivel { get => nivel; set => nivel = value; }
        public bool Ativo { get => ativo; set => ativo = value; }


        // Métodos Construtores
        public Usuario() { }

        public Usuario(int id, string nome, string email, string senha, Nivel nivel, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }

        public Usuario(string nome, string email, string senha, Nivel nivel)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
        }

        public Usuario(string nome, string email, string senha, Nivel nivel, bool ativo)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }


        // Métodos
        /// <summary>
        /// Um método que busca email e senha no Banco de Dados especificado pelos parâmetros, para validação.
        /// </summary>
        /// <param name="_email">Email especificado para fazer a busca no Banco de Dados.</param>
        /// <param name="_senha">Senha especificado para fazer a busca no Banco de Dados.</param>
        /// <returns>Ele retorna um objeto de dados obtidos na consulta.</returns>
        public static Usuario EfetuarLogin(string _email, string _senha) 
        { 
            Usuario usuario = null;
            MySqlCommand cmd = Banco.Abrir();

            cmd.CommandText = "select id, nome, email, nivel from usuarios " +
                              "where email = @email and senha = md5(@senha) and ativo = 1";

            cmd.Parameters.AddWithValue("@email", _email);
            cmd.Parameters.AddWithValue("@email", _senha);

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                usuario = new Usuario();
                usuario.Id = dr.GetInt32(0);
                usuario.Nome = dr.GetString(1);
                usuario.Email = dr.GetString(2);
                usuario.Nivel = Nivel.ObterPorId(dr.GetInt32(3));

            }

            return usuario;
        }

        /// <summary>
        /// Método que traz os dados do Usuário pelo ID especificado que está cadastrado no Banco de Dados.
        /// </summary>
        /// <param name="_id">Parâmetro que especifica o dado por ID que irá Listar no banco de dados.</param>
        /// <returns>Retorna um objeto de Usuario com dados obtidos.</returns>
        public static Usuario ObterPorId(int _id)
        {
            Usuario usuario = null;
            var cmd = Banco.Abrir();

            cmd.CommandText = "select * from usuarios where id = " + _id;
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                usuario = new Usuario(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        Nivel.ObterPorId(dr.GetInt32(4)),
                        dr.GetBoolean(5)
                    );
            }

            Banco.Fechar(cmd);
            return usuario;
        }


        /// <summary>
        /// Método que traz uma Lista de dados do Usuário que está cadastrado no Banco de Dados.
        /// Se for entregue um parâmetro ele trará dados relacionado ao especificado. Caso contrário
        /// ele lista-rá todos os dados.
        /// </summary>
        /// <param name="_nome">Parâmetro que especifica o dado que irá Listar/Filtrar no banco de dados.</param>
        /// <returns>Retorna uma lista de objetos com dados obtidos.</returns>
        public static List<Usuario> Listar(string _nome = "")
        {
            List<Usuario> lista = new List<Usuario>();

            var cmd = Banco.Abrir();

            if (_nome != string.Empty)
                cmd.CommandText = "select * from usuarios nome like '%" + _nome + "%'";
            else
                cmd.CommandText = "select * from usuarios";
            
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                 lista.Add(new Usuario(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        Nivel.ObterPorId(dr.GetInt32(4)),
                        dr.GetBoolean(5)
                    ));
            }

            Banco.Fechar(cmd);
            return lista;
        }


        /// <summary>
        /// Método para Inserir/Registrar dados do Usuário no Banco de Dados.
        /// </summary>
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert usuarios (nome, email, senha, nivel_id, ativo) " +
                               "values(@nome, @email, md5(@senha), @nivel, 1)";
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
            cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = Senha;
            cmd.Parameters.Add("@nivel", MySqlDbType.Int32).Value = Nivel.Id;

            cmd.ExecuteNonQuery();

            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());

            Banco.Fechar(cmd);
        }


        /// <summary>
        /// Método para Atualizar/Alterar dados do Usuário no Banco de Dados.
        /// </summary>
        public void Atualizar()
        {
            var cmd = Banco.Abrir();

            cmd.CommandText = "update usuarios set nome = @nome, nivel_id = @nivel where id = " + Id;
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.Add("@nivel", MySqlDbType.Int32).Value = Nivel.Id;
            cmd.ExecuteNonQuery();

            Banco.Fechar(cmd);
        }


        /// <summary>
        /// Método para Arquivar dados do Usuário no Banco de Dados.
        /// </summary>
        /// <param name="_id">Parâmetro que identifica o dado a ser Arquivado.</param>
        public static void Arquivar(int _id) 
        {
            var cmd = Banco.Abrir();

            cmd.CommandText = "update usuarios set ativo = 0 where id = " + _id;
            cmd.ExecuteNonQuery();

            Banco.Fechar(cmd);
        }


        /// <summary>
        /// Método para Restaurar dados do Usuário no Banco de Dados.
        /// </summary>
        /// <param name="_id">Parâmetro que identifica o dado a ser Restaurado.</param>
        public static void Restaurar(int _id)
        {
            var cmd = Banco.Abrir();

            cmd.CommandText = "update usuarios set ativo = 1 where id = " + _id;
            cmd.ExecuteNonQuery();

            Banco.Fechar(cmd);  
        }


        /// <summary>
        /// Método para Exluir permanentemente dados do Usuário no Banco de Dados.
        /// </summary>
        public void Excluir()
        {
            var cmd = Banco.Abrir();

            cmd.CommandText = "delete from usuarios where id = " + Id;
            cmd.ExecuteNonQuery();

            Banco.Fechar(cmd);
        }
    }
}
