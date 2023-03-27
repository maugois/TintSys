using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TintSysClass
{
    public class Cliente
    {
        // Atributos
        private int id;
        private string nome;
        private string cpf;
        private string email;
        private DateTime dataCad;
        private bool ativo;
        private List<Endereco> enderecos;
        private List<Telefone> telefones;

        //Propriedades
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public DateTime DataCad { get => dataCad; set => dataCad = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        public List<Endereco> Enderecos { get => enderecos; set => enderecos = value; }
        public List<Telefone> Telefones { get => telefones; set => telefones = value; }

        // Métodos Construtores
        public Cliente() { }

        public Cliente(int id, string nome, string cpf, string email, DateTime dataCad, bool ativo, List<Endereco> Enderecos, List<Telefone> Telefones)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Email = email;
            this.DataCad = dataCad;
            this.Ativo = ativo;
            this.Enderecos = Enderecos;
            this.Telefones = Telefones;   
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

        public Cliente(string nome, string cpf, string email, bool ativo)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Email = email;
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
        /// Método para Inserir/Registrar dados do Cliente no Banco de Dados.
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
        /// Método para Atualizar/Alterar dados do Cliente no Banco de Dados.
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
        /// Método para Arquivar dados do Cliente no Banco de Dados.
        /// </summary>
        /// <param name="_id">Parâmetro que identifica o dado a ser Arquivado.</param>
        public static void Arquivar(int _id)
        {
            var cmd = Banco.Abrir();

            cmd.CommandText = "update clientes set ativo = 0 where id = " + _id;
            cmd.ExecuteNonQuery();

            Banco.Fechar(cmd);
        }


        /// <summary>
        /// Método para Restaurar dados Arquivados do Cliente no Banco de Dados.
        /// </summary>
        /// <param name="_id">Parâmetro que identifica o dado a ser Restaurado.</param>
        public static void Restaurar(int _id)
        {
            var cmd = Banco.Abrir();

            cmd.CommandText = "update clientes set ativo = 1 where id = " + _id;
            cmd.ExecuteNonQuery();

            Banco.Fechar(cmd);
        }


        /// <summary>
        /// Método para Exluir permanentemente dados do Cliente no Banco de Dados.
        /// </summary>
        /// <param name="_id">Parâmetro que identifica o dado a ser Excluído permanentemente.</param> 
        /// <returns>Retorna um valor 0, 1 ou 2. 0 para mostrar que o Cliente não foi excluído. 1 para mostrar que o Cliente foi excluído. 2 para mostrar que o Cliente não foi excluído por conta de uma chave estrangeira.</returns>
        public int Excluir(int _id)
        {
            int msg = 0;
            var cmd = Banco.Abrir();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from clientes where id = " + _id;

            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    msg = 1;
                }
            }
            catch (Exception e)
            {
                if (e.Message.Contains("FOREIGN KEY"))
                    msg = 2;
            }

            Banco.Fechar(cmd);
            return msg;
        }


        /// <summary>
        /// Método que traz uma Lista de dados do Cliente que está cadastrado no Banco de Dados.
        /// Se for entregue um parâmetro ele trará o dado relacionado ao especificado. Caso contrário
        /// ele lista-rá todos os dados.
        /// </summary>
        /// <param name="_nome">Parâmetro que especifica o dado que irá Listar/Filtrar no banco de dados.</param>
        /// <returns>Retorna uma lista de objetos com dados obtidos.</returns>
        public static List<Cliente> Listar(string _nome = "") 
        {
            List<Cliente> lista = new List<Cliente>();

            var cmd = Banco.Abrir();

            if (_nome != string.Empty)
                cmd.CommandText = "select * from clientes nome like '%" + _nome + "%'";
            else
                cmd.CommandText = "select * from clientes";

            var dr = cmd.ExecuteReader();

            //while (dr.Read())
            //{
            //    lista.Add(new Cliente(
            //            dr.GetInt32(0),
            //            dr.GetString(1),
            //            dr.GetString(2),
            //            dr.GetString(3),
            //            dr.GetDateTime(4),
            //            dr.GetBoolean(5)
            //       ));
            //}

            Banco.Fechar(cmd);
            return lista;
        }


        /// <summary>
        /// Método que traz os dados do Cliente pelo ID especificado que está cadastrado no Banco de Dados.
        /// </summary>
        /// <param name="_id">Parâmetro que especifica o dado por ID que irá Listar no banco de dados.</param>
        /// <returns>Retorna um objeto de Cliente com dados obtidos.</returns>
        public static Cliente ObterPorId(int _id)
        {
            Cliente cliente = null;
            var cmd = Banco.Abrir();

            cmd.CommandText = "select * from clientes where id = " + _id;
            var dr = cmd.ExecuteReader();

            //while (dr.Read())
            //{
            //    cliente = new Cliente(
            //            dr.GetInt32(0),
            //            dr.GetString(1),
            //            dr.GetString(2),
            //            dr.GetString(3),
            //            dr.GetDateTime(4),
            //            dr.GetBoolean(5)
            //        );
            //}

            Banco.Fechar(cmd);
            return cliente;
        }
    }
}
