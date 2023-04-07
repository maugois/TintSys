using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TintSysClass
{
    public class Produto
    {
        // Atributo - Métodos de acesso - Propriedades
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Unidade { get; set; }
        public string CodBar { get; set;}
        public double Preco { get; set;}
        public double Desconto { get; set; }
        public bool Descontinuado { get; set; }


        // Métodos construtores
        public Produto()
        {

        }


        public Produto(int id, string descricao, string unidade, string codBar, double preco, double desconto, bool descontinuado)
        {
            Id = id;
            Descricao = descricao;
            Unidade = unidade;
            CodBar = codBar;
            Preco = preco;
            Desconto = desconto;
            Descontinuado = descontinuado;
        }

        public Produto(string descricao, string unidade, string codBar, double preco, double desconto, bool descontinuado)
        {
            Descricao = descricao;
            Unidade = unidade;
            CodBar = codBar;
            Preco = preco;
            Desconto = desconto;
            Descontinuado = descontinuado;
        }

        public Produto(string descricao, string unidade, string codBar, double preco, double desconto)
        {
            Descricao = descricao;
            Unidade = unidade;
            CodBar = codBar;
            Preco = preco;
            Desconto = desconto;
        }


        // Métodos da classe
        public void Inserir()
        {
            var cmd = Banco.Abrir();

            cmd.CommandText = "insert produtos (descricao, unidade, codbar, " +
                " preco, desconto, descontinuado) " +
                " values(@descricao, @unidade, @codbar, @preco, @desconto, 0)";

            cmd.Parameters.Add("@descricao", MySqlDbType.VarChar).Value = Descricao;
            cmd.Parameters.Add("@unidade", MySqlDbType.VarChar).Value = Unidade;
            cmd.Parameters.Add("@codbar", MySqlDbType.VarChar).Value = CodBar;
            cmd.Parameters.Add("@preco", MySqlDbType.Decimal).Value = Preco;
            cmd.Parameters.Add("@desconto", MySqlDbType.Decimal).Value = (Desconto/100);                                                                                                                                                                                                      
            
            cmd.ExecuteNonQuery();

            cmd.CommandText = "select @@identity";
            Id = (Convert.ToInt32(cmd.ExecuteScalar()));

            Banco.Fechar(cmd);
        }

        public static List<Produto> Listar(string descricao = "", int ativo = 0)
        {
            List<Produto> lista = new List<Produto>();
            
            MySqlCommand cmd = Banco.Abrir();

            if (descricao.Length > 0)
                cmd.CommandText = "select * from produtos where descricao like '%"+ descricao +"%' and descontinuado = " + ativo;
            else
                cmd.CommandText = "select * from produtos where descontinuado = " + ativo;

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                lista.Add(new Produto(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDouble(4),
                    dr.GetDouble(5),
                    dr.GetBoolean(6)));
            }

            Banco.Fechar(cmd);

            return lista; 
        }

        public static Produto ObterPorId(int id)
        {
            Produto produto = null;

            MySqlCommand cmd = Banco.Abrir();

            cmd.CommandText = "select * from produtos where id = " + id;

            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                produto = new Produto(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDouble(4),
                    dr.GetDouble(5),
                    dr.GetBoolean(6));
            }

            Banco.Fechar(cmd);

            return produto;
        }

        public void Atualizar()
        {
            var cmd = Banco.Abrir();

            cmd.CommandText = "update produtos set " +
                "descricao = @descricao, unidade = @unidade, codbar = @codbar, preco = @preco, desconto = @desconto, descontinuado = @descontinuado where id = " + Id;

            cmd.Parameters.Add("@descricao", MySqlDbType.VarChar).Value = Descricao;
            cmd.Parameters.Add("@unidade", MySqlDbType.VarChar).Value = Unidade;
            cmd.Parameters.Add("@codbar", MySqlDbType.VarChar).Value = CodBar;
            cmd.Parameters.Add("@preco", MySqlDbType.Decimal).Value = Preco;
            cmd.Parameters.Add("@desconto", MySqlDbType.Decimal).Value = Desconto;
            cmd.Parameters.Add("@descontinuado", MySqlDbType.Bit).Value = Descontinuado;

            cmd.ExecuteNonQuery();

            Banco.Fechar(cmd);
        }

        public static void Arquivar(int _id)
        {
            var cmd = Banco.Abrir();

            cmd.CommandText = "update produtos set descontinuado = 1 where id = " + _id;

            cmd.ExecuteNonQuery();

            Banco.Fechar(cmd);
        }

        public static void Restaurar(int _id)
        {
            var cmd = Banco.Abrir();

            cmd.CommandText = "update produtos set descontinuado = 0 where id = " + _id;

            cmd.ExecuteNonQuery();

            Banco.Fechar(cmd);
        }
    }
}
