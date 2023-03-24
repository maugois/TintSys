using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TintSysClass
{
    internal class Endereco
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
        private Cliente cliente_id;


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
        internal Cliente Cliente_id { get => cliente_id; set => cliente_id = value; }

        // Métodos Construtores
        public Endereco() { }

        public Endereco(int id, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uf, string tipo, Cliente cliente_id)
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

        // Métodos
    }
}
