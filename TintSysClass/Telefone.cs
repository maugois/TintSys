using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace TintSysClass
{
    public class Telefone
    {
        // Atributo
        private int id;
        private string numero;
        private string tipo;

        // Propriedades
        public int Id { get => id; set => id = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        // Métodos Construtores
        public Telefone() { }

        public Telefone(int id, string numero, string tipo)
        {
            this.id = id;   
            this.numero = numero;
            this.tipo = tipo;
        }

        public Telefone(string numero, string tipo)
        {
            this.numero = numero;
            this.tipo = tipo;
        }

        // Métodos
        public void Inserir(int _cliente_id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert telefones (numero, tipo, cliente_id) " +
                               "values(@numero, @tipo, @cliente_id)";
            cmd.Parameters.Add("@numero", MySqlDbType.VarChar).Value = Numero;
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

            cmd.CommandText = "update telefones set numero = @numero, tipo = @tipo where cliente_id = " + Id;
            cmd.Parameters.Add("@numero", MySqlDbType.VarChar).Value = Numero;
            cmd.Parameters.Add("@tipo", MySqlDbType.VarChar).Value = Tipo;

            cmd.ExecuteNonQuery();

            Banco.Fechar(cmd);
        }


        public void Excluir(int _id)
        {
            var cmd = Banco.Abrir();

            cmd.CommandText = "delete from telefones where id = " + _id;
            cmd.ExecuteNonQuery();

            Banco.Fechar(cmd);
        }


        public static List<Telefone> ListarPorCliente(int _cliente_id = 0)
        {
            List<Telefone> lista = new List<Telefone>();

            var cmd = Banco.Abrir();

            if (_cliente_id != 0)
                cmd.CommandText = "select * from telefones where cliente_id = " + _cliente_id;
            else
                cmd.CommandText = "select * from telefones";

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new Telefone(
                       dr.GetInt32(0),
                       dr.GetString(1),
                       dr.GetString(2)
                   ));
            }

            Banco.Fechar(cmd);
            return lista;
        }


        public static Telefone ObterPorId(int _id)
        {
            Telefone telefone = null;
            var cmd = Banco.Abrir();

            cmd.CommandText = "select * from telefones where id = " + _id;
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                telefone = new Telefone(
                       dr.GetInt32(0),
                       dr.GetString(1),
                       dr.GetString(2)
                    );
            }

            Banco.Fechar(cmd);
            return telefone;
        }
    }
}
