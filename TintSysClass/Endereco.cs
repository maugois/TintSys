using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TintSysClass
{
    public class Endereco
    {
        // Atributos
        private int id;
        private string cep;
        private string logradouro;
        private string numero;
        private string complemento;
        private string bairro;
        private string cidade;
        private string estado;
        private string uf;
        private string tipo;
        private int cliente_id;


        // Propriedades
        public int Id { get => id; set => id = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Cliente_id { get => cliente_id; set => cliente_id = value; }

        // Métodos Construtores
        public Endereco() { }

        public Endereco(int id, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uf, string tipo, int cliente_id)
        {
            this.id = id;
            this.cep = cep;
            this.logradouro = logradouro;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.uf = uf;
            this.tipo = tipo;
            this.cliente_id = cliente_id;
        }

        public Endereco(int id, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uf, string tipo)
        {
            this.id = id;
            this.cep = cep;
            this.logradouro = logradouro;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.uf = uf;
            this.tipo = tipo;
        }

        public Endereco(string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uf, string tipo, int cliente_id)
        {
            this.cep = cep;
            this.logradouro = logradouro;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.uf = uf;
            this.tipo = tipo;
            this.cliente_id = cliente_id;
        }

        public Endereco(string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uf, string tipo)
        {
            this.cep = cep;
            this.logradouro = logradouro;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.uf = uf;
            this.tipo = tipo;
        }

        // Métodos
        public void Inserir(int _cliente_id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert enderecos (cep, logradouro, numero, complemento, bairro, cidade, estado, uf, tipo, cliente_id) " +
                               "values(@cep, @logradouro, @numero, @complemento, @bairro, @cidade, @estado, @uf, @tipo, @cliente_id)";
            cmd.Parameters.Add("@cep", MySqlDbType.VarChar).Value = Cep;
            cmd.Parameters.Add("@logradouro", MySqlDbType.VarChar).Value = Logradouro;
            cmd.Parameters.Add("@numero", MySqlDbType.VarChar).Value = Numero;
            cmd.Parameters.Add("@complemento", MySqlDbType.VarChar).Value = Complemento;
            cmd.Parameters.Add("@bairro", MySqlDbType.VarChar).Value = Bairro;
            cmd.Parameters.Add("@cidade", MySqlDbType.VarChar).Value = Cidade;
            cmd.Parameters.Add("@estado", MySqlDbType.VarChar).Value = Estado;
            cmd.Parameters.Add("@uf", MySqlDbType.VarChar).Value = Uf;
            cmd.Parameters.Add("@tipo", MySqlDbType.VarChar).Value = Tipo;
            cmd.Parameters.Add("@cliente_id", MySqlDbType.Int32).Value = _cliente_id;

            cmd.ExecuteNonQuery();

            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());

            Banco.Fechar(cmd);
        }


        public void Atualizar()
        {
            var cmd = Banco.Abrir();

            cmd.CommandText = "update enderecos set cep = @cep, logradouro = @logradouro, numero = @numero, complemento = @complemento, bairro = @bairro, cidade = @cidade, estado = @estado, uf = @uf tipo = @tipo where id = " + Id;
            cmd.Parameters.Add("@cep", MySqlDbType.VarChar).Value = Cep;
            cmd.Parameters.Add("@logradouro", MySqlDbType.VarChar).Value = Logradouro;
            cmd.Parameters.Add("@numero", MySqlDbType.VarChar).Value = Numero;
            cmd.Parameters.Add("@complemento", MySqlDbType.VarChar).Value = Complemento;
            cmd.Parameters.Add("@bairro", MySqlDbType.VarChar).Value = Bairro;
            cmd.Parameters.Add("@cidade", MySqlDbType.VarChar).Value = Cidade;
            cmd.Parameters.Add("@estado", MySqlDbType.VarChar).Value = Estado;
            cmd.Parameters.Add("@uf", MySqlDbType.VarChar).Value = Uf;
            cmd.Parameters.Add("@tipo", MySqlDbType.VarChar).Value = Tipo;
            
            cmd.ExecuteNonQuery();

            Banco.Fechar(cmd);
        }


        public void Excluir(int _id)
        {
            var cmd = Banco.Abrir();

            cmd.CommandText = "delete from enderecos where id = " + _id;
            cmd.ExecuteNonQuery();

            Banco.Fechar(cmd);
        }


        public static List<Endereco> ListarPorUsuario(int _cliente_id = 0)
        {
            List<Endereco> lista = new List<Endereco>();

            var cmd = Banco.Abrir();

            if (_cliente_id != 0)
                cmd.CommandText = "select * from enderecos where cliente_id = " + _cliente_id;
            else
                cmd.CommandText = "select * from enderecos";

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new Endereco(
                       dr.GetInt32(0),
                       dr.GetString(1),
                       dr.GetString(2),
                       dr.GetString(3),
                       dr.GetString(4),
                       dr.GetString(5),
                       dr.GetString(6),
                       dr.GetString(7),
                       dr.GetString(8),
                       dr.GetString(9)
                   ));
            }

            Banco.Fechar(cmd);
            return lista;
        }


        public static Endereco ObterPorId(int _id)
        {
            Endereco endereco = null;
            var cmd = Banco.Abrir();

            cmd.CommandText = "select * from enderecos where id = " + _id;
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                endereco = new Endereco(
                        dr.GetInt32(0),
                       dr.GetString(1),
                       dr.GetString(2),
                       dr.GetString(3),
                       dr.GetString(4),
                       dr.GetString(5),
                       dr.GetString(6),
                       dr.GetString(7),
                       dr.GetString(8),
                       dr.GetString(9)
                       );
            }

            Banco.Fechar(cmd);
            return endereco;
        }
    }
}
