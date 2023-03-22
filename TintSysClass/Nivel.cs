using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace TintSysClass
{
    public class Nivel
    {
        // Atributos
            //private (-) 
            //protected (#)
            //public (+)
        private int id;
        private string nome;
        private string sigla;

        // Propriedades (Encapsulamento) getters and setters ou Métodos de acesse 
        
        public int Id { get { return id; } set {  id = value; } }
        
        public string Nome { get {  return nome; } set {  nome = value; } }
        
        public string Sigla { get {  return sigla; } set {  sigla = value; } }
        
        // Métodos construtores - Int x = new Int();
        public Nivel() { } // Vazio
        
        public Nivel(string _nome, string _sigla)
        {
            Nome = _nome;
            Sigla = _sigla;
        }

        public Nivel(int _id, string _nome, string _sigla)
        {
            Id = _id;
            Nome = _nome;
            Sigla = _sigla;
        }

        // Métodos da Classes (Inserir, Alterar, Consultar, Por Id, Por ...)
        public void Inserir()
        {
            // Cria uma variável com uma conexão de banco aberta 
            var cmd = Banco.Abrir();

            // Define o tipo de uma instrução MySQL a ser processada pelo Banco de dados
            cmd.CommandType = CommandType.Text;
            
            // Define uma query SQL especificada com parâmetros (@nome, @sigla)
            cmd.CommandText = "insert niveis (nome, sigla) values (@nome,@sigla)";
            
            // Cria o parãmetro e associa ao valor da instrução SQL
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.AddWithValue("@sigla", Sigla);
            
            // Executa a instrução SQL na conexão aberta
            cmd.ExecuteNonQuery();

            // Obtendo o ID do nível recém inserindo
            cmd.CommandText = "select @@identity";

            // Recupera o ID na Propriedade
            Id = Convert.ToInt32(cmd.ExecuteScalar());

            // Fecha a conexão do banco aberto
            Banco.Fechar(cmd);
        }
    }
}
