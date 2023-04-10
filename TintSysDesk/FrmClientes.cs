using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TintSysClass;

namespace TintSysDesk
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (pnlConsulta.Visible != true)
            {
                pnlConsulta.Visible = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }

        public void CarregaGridListar(string texto = "")
        {
            List<Produto> lista = null;
            if (texto != string.Empty)
                lista = Produto.Listar(texto, 0);
            else
                lista = Produto.Listar("", 0);

            int cont = 0;
            //dgvLista.Rows.Clear();

            foreach (Produto item in lista)
            {
                //dgvLista.Rows.Add();
                //dgvLista.Rows[cont].Cells[0].Value = item.Id.ToString();
                //dgvLista.Rows[cont].Cells[1].Value = item.Descricao;
                //dgvLista.Rows[cont].Cells[2].Value = item.Unidade;
                //dgvLista.Rows[cont].Cells[3].Value = item.CodBar;
                //dgvLista.Rows[cont].Cells[4].Value = item.Preco.ToString();
                //dgvLista.Rows[cont].Cells[5].Value = item.Desconto.ToString();
                //dgvLista.Rows[cont].Cells[6].Value = item.Descontinuado;
                cont++;
            }
        }

        public void CarregaGridObterPorId(int id)
        {
            //List<Produto> lista = null;
            //if (lista != string.Empty)
            //    lista = Produto.Listar(id);
            //else
            //    lista = Produto.Listar();

            int cont = 0;
            //dgvLista.Rows.Clear();

            //foreach (Produto item in lista)
            //{
            //    //dgvLista.Rows.Add();
            //    //dgvLista.Rows[cont].Cells[0].Value = item.Id.ToString();
            //    //dgvLista.Rows[cont].Cells[1].Value = item.Descricao;
            //    //dgvLista.Rows[cont].Cells[2].Value = item.Unidade;
            //    //dgvLista.Rows[cont].Cells[3].Value = item.CodBar;
            //    //dgvLista.Rows[cont].Cells[4].Value = item.Preco.ToString();
            //    //dgvLista.Rows[cont].Cells[5].Value = item.Desconto.ToString();
            //    //dgvLista.Rows[cont].Cells[6].Value = item.Descontinuado;
            //    cont++;
            //}
        }
    }
}
