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
        /// 
        /// </summary>
        /// <param name="_email"></param>
        /// <param name="_senha"></param>
        /// <returns></returns>
        public static Usuario EfetuarLogin(string _email, string _senha) 
        { 
            Usuario usuario = null;

            return usuario;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="_nome"></param>
        /// <returns></returns>
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
        /// 
        /// </summary>
        public void Inserir()
        {

        }


        /// <summary>
        /// 
        /// </summary>
        public void Atualizar()
        {

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="_id"></param>
        public void Arquivar(int _id) 
        {
        
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="_id"></param>
        public void Restaurar(int _id)
        {

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="_id"></param>
        public void Excluir(int _id)
        {

        }
    }
}
