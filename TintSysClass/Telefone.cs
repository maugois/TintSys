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
        private Cliente cliente_id;

        // Propriedades
        public int Id { get => id; set => id = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public Cliente Cliente_id { get => cliente_id; set => cliente_id = value; }

        // Métodos Construtores
        public Telefone() { }

        public Telefone(int id, string numero, string tipo, Cliente cliente_id)
        {
            this.id = id;   
            this.numero = numero;
            this.tipo = tipo;
            this.cliente_id = cliente_id;
        }

        // Métodos
        /// <summary>
        /// 
        /// </summary>
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert telefones (numero, tipo, cliente_id) " +
                               "values(@numero, @tipo, @cliente_id)";
            cmd.Parameters.Add("@numero", MySqlDbType.VarChar).Value = Numero;
            cmd.Parameters.Add("@tipo", MySqlDbType.VarChar).Value = Tipo;
            cmd.Parameters.Add("@cliente_id", MySqlDbType.Int32).Value = Cliente_id.Id;

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

            cmd.CommandText = "update telefones set numero = @numero, tipo = @tipo where id = " + Id;
            cmd.Parameters.Add("@numero", MySqlDbType.VarChar).Value = Numero;
            cmd.Parameters.Add("@tipo", MySqlDbType.VarChar).Value = Tipo;

            cmd.ExecuteNonQuery();

            Banco.Fechar(cmd);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="_id"></param>
        public void Excluir(int _id)
        {
            var cmd = Banco.Abrir();

            cmd.CommandText = "delete from telefones where id = " + _id;
            cmd.ExecuteNonQuery();

            Banco.Fechar(cmd);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="_filtro"></param>
        /// <returns></returns>
        public static List<Telefone> Listar(string _filtro = "")
        {
            List<Telefone> lista = new List<Telefone>();

            var cmd = Banco.Abrir();

            if (_filtro != string.Empty)
                cmd.CommandText = "select * from telefones nome like '%" + _filtro + "%'";
            else
                cmd.CommandText = "select * from telefones";

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new Telefone(
                       dr.GetInt32(0),
                       dr.GetString(1),
                       dr.GetString(2),
                       Cliente.ObterPorId(dr.GetInt32(3))
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
                       dr.GetString(2),
                       Cliente.ObterPorId(dr.GetInt32(3))
                    );
            }

            Banco.Fechar(cmd);
            return telefone;
        }
    }
}
