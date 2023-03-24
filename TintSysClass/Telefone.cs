using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TintSysClass
{
    internal class Telefone
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
        internal Cliente Cliente_id { get => cliente_id; set => cliente_id = value; }

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
    }
}
