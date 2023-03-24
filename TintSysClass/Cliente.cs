using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TintSysClass
{
    internal class Cliente
    {
        // Atributos
        private int id;
        private string nome;
        private string cpf;
        private string email;
        private DateTime dataCad;
        private bool ativo;

        //Propriedades
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public DateTime DataCad { get => dataCad; set => dataCad = value; }
        public bool Ativo { get => ativo; set => ativo = value; }

        // Métodos Construtores
        public Cliente() { }

        public Cliente(int id, string nome, string cpf, string email, DateTime dataCad, bool ativo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Email = email;
            this.DataCad = dataCad;
            this.Ativo = ativo;
        }

        public Cliente(string nome, string cpf, string email, DateTime dataCad, bool ativo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Email = email;
            this.DataCad = dataCad;
            this.Ativo = ativo;
        }

        public Cliente(string nome, string cpf, string email, DateTime dataCad)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Email = email;
            this.DataCad = dataCad;
            this.Ativo = ativo;
        }

        // Métodos
        /// <summary>
        /// 
        /// </summary>
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert clientes (nome, cpf, email, datacad, ativo) " +
                               "values(@nome, @cpf, @email, default, 1)";
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = Cpf;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;

            cmd.ExecuteNonQuery();

            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());

            Banco.Fechar(cmd);
        }


        /// <summary>
        /// 
        /// </summary>
        public void Atualizar()
        {
            var cmd = Banco.Abrir();

            cmd.CommandText = "update clientes set nome = @nome where id = " + Id;
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.ExecuteNonQuery();

            Banco.Fechar(cmd);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="_id"></param>
        public static void Arquivar(int _id)
        {
            var cmd = Banco.Abrir();

            cmd.CommandText = "update clientes set ativo = 0 where id = " + _id;
            cmd.ExecuteNonQuery();

            Banco.Fechar(cmd);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="_id"></param>
        public static void Restaurar(int _id)
        {
            var cmd = Banco.Abrir();

            cmd.CommandText = "update clientes set ativo = 1 where id = " + _id;
            cmd.ExecuteNonQuery();

            Banco.Fechar(cmd);
        }


        /// <summary>
        /// 
        /// </summary>
        public void Excluir()
        {
            var cmd = Banco.Abrir();

            cmd.CommandText = "delete from clientes where id = " + Id;
            cmd.ExecuteNonQuery();

            Banco.Fechar(cmd);  
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="_nome"></param>
        /// <returns></returns>
        public static List<Cliente> Listar(string _nome = "") 
        {
            List<Cliente> lista = new List<Cliente>();

            var cmd = Banco.Abrir();

            if (_nome != string.Empty)
                cmd.CommandText = "select * from clientes nome like '%" + _nome + "%'";
            else
                cmd.CommandText = "select * from clientes";

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new Cliente(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetDateTime(4),
                        dr.GetBoolean(5)
                   ));
            }

            Banco.Fechar(cmd);
            return lista;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="_id"></param>
        /// <returns></returns>
        public static Cliente ObterPorId(int _id)
        {
            Cliente cliente = null;
            var cmd = Banco.Abrir();

            cmd.CommandText = "select * from clientes where id = " + _id;
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cliente = new Cliente(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetDateTime(4),
                        dr.GetBoolean(5)
                    );
            }

            Banco.Fechar(cmd);
            return cliente;
        }
    }
}
