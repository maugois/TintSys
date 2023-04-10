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
            CarregaGridListarAtivo();
            CarregaGridListarInativo(); 
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CarregaGridListarAtivo();
            CarregaGridListarInativo();
        }

        public void CarregaGridListarAtivo(string texto = "")
        {
            List<Cliente> lista = null;
            List<Endereco> listaEndereco = null;
            List<Telefone> listaTelefone = null;
            
            if (texto != string.Empty)
                lista = Cliente.Listar(texto, 1);
            else
                lista = Cliente.Listar("", 1);

            listaEndereco = Endereco.ListarPorCliente();
            listaTelefone = Telefone.ListarPorCliente();

            int cont = 0;
            dgvListaCliente.Rows.Clear();
            dgvEndereco.Rows.Clear();
            dgvTelefone.Rows.Clear();

            foreach (Cliente item in lista)
            {
                dgvListaCliente.Rows.Add();
                dgvListaCliente.Rows[cont].Cells[0].Value = item.Id.ToString();
                dgvListaCliente.Rows[cont].Cells[1].Value = item.Nome;
                dgvListaCliente.Rows[cont].Cells[2].Value = item.Cpf;
                dgvListaCliente.Rows[cont].Cells[3].Value = item.Email;
                dgvListaCliente.Rows[cont].Cells[4].Value = item.DataCad.ToString("dd-MM-yyy");
                cont++;
            }

            foreach (Endereco item in listaEndereco)
            {
                dgvEndereco.Rows.Add();
                dgvEndereco.Rows[cont].Cells[0].Value = item.Id.ToString();
                dgvEndereco.Rows[cont].Cells[1].Value = item.Cep;
                dgvEndereco.Rows[cont].Cells[2].Value = item.Logradouro;
                dgvEndereco.Rows[cont].Cells[3].Value = item.Numero;
                dgvEndereco.Rows[cont].Cells[4].Value = item.Complemento;
                dgvEndereco.Rows[cont].Cells[5].Value = item.Bairro;
                dgvEndereco.Rows[cont].Cells[6].Value = item.Cidade;
                dgvEndereco.Rows[cont].Cells[7].Value = item.Estado;
                dgvEndereco.Rows[cont].Cells[8].Value = item.Uf;
                dgvEndereco.Rows[cont].Cells[9].Value = item.Tipo;
                cont++;
            }

            foreach (Telefone item in listaTelefone)
            {
                dgvTelefone.Rows.Add();
                dgvTelefone.Rows[cont].Cells[0].Value = item.Id.ToString();
                dgvTelefone.Rows[cont].Cells[1].Value = item.Numero;
                dgvTelefone.Rows[cont].Cells[2].Value = item.Tipo;
                cont++;
            }
        }

        public void CarregaGridListarInativo(string texto = "")
        {
            List<Cliente> lista = null;
            List<Endereco> listaEndereco = null;
            List<Telefone> listaTelefone = null;

            if (texto != string.Empty)
                lista = Cliente.Listar(texto);
            else
                lista = Cliente.Listar("");

            listaEndereco = Endereco.ListarPorCliente();
            listaTelefone = Telefone.ListarPorCliente();

            int cont = 0;
            dgvListaIdCliente.Rows.Clear();
            dgvEndereco.Rows.Clear();
            dgvTelefone.Rows.Clear();

            foreach (Cliente item in lista)
            {
                dgvListaIdCliente.Rows.Add();
                dgvListaIdCliente.Rows[cont].Cells[0].Value = item.Id.ToString();
                dgvListaIdCliente.Rows[cont].Cells[1].Value = item.Nome;
                dgvListaIdCliente.Rows[cont].Cells[2].Value = item.Cpf;
                dgvListaIdCliente.Rows[cont].Cells[3].Value = item.Email;
                dgvListaIdCliente.Rows[cont].Cells[4].Value = item.DataCad.ToString("dd-MM-yyy");
                cont++;
            }

            foreach (Endereco item in listaEndereco)
            {
                dgvEnderecoInativo.Rows.Add();
                dgvEnderecoInativo.Rows[cont].Cells[0].Value = item.Id.ToString();
                dgvEnderecoInativo.Rows[cont].Cells[1].Value = item.Cep;
                dgvEnderecoInativo.Rows[cont].Cells[2].Value = item.Logradouro;
                dgvEnderecoInativo.Rows[cont].Cells[3].Value = item.Numero;
                dgvEnderecoInativo.Rows[cont].Cells[4].Value = item.Complemento;
                dgvEnderecoInativo.Rows[cont].Cells[5].Value = item.Bairro;
                dgvEnderecoInativo.Rows[cont].Cells[6].Value = item.Cidade;
                dgvEnderecoInativo.Rows[cont].Cells[7].Value = item.Estado;
                dgvEnderecoInativo.Rows[cont].Cells[8].Value = item.Uf;
                dgvEnderecoInativo.Rows[cont].Cells[9].Value = item.Tipo;
                cont++;
            }

            foreach (Telefone item in listaTelefone)
            {
                dgvTelefoneInativo.Rows.Add();
                dgvTelefoneInativo.Rows[cont].Cells[0].Value = item.Id.ToString();
                dgvTelefoneInativo.Rows[cont].Cells[1].Value = item.Numero;
                dgvTelefoneInativo.Rows[cont].Cells[2].Value = item.Tipo;
                cont++;
            }
        }

        public void CarregaGridObterPorId(int id)
        {
            List<Cliente> lista = null;

            lista = Cliente.ObterPorId(id);

            int cont = 0;
            dgvListaCliente.Rows.Clear();

            foreach (Cliente item in lista)
            {
                dgvListaCliente.Rows.Add();
                dgvListaCliente.Rows[cont].Cells[0].Value = item.Id.ToString();
                dgvListaCliente.Rows[cont].Cells[1].Value = item.Nome;
                dgvListaCliente.Rows[cont].Cells[2].Value = item.Cpf;
                dgvListaCliente.Rows[cont].Cells[3].Value = item.Email;
                dgvListaCliente.Rows[cont].Cells[4].Value = item.DataCad.ToString("dd-MM-yyy");
                
                dgvEndereco.Rows.Add();
                dgvEndereco.Rows[cont].Cells[0].Value = item.Enderecos.ToString();
                dgvEndereco.Rows[cont].Cells[1].Value = item.Enderecos;
                dgvEndereco.Rows[cont].Cells[2].Value = item.Enderecos;
                dgvEndereco.Rows[cont].Cells[3].Value = item.Enderecos;
                dgvEndereco.Rows[cont].Cells[4].Value = item.Enderecos;
                dgvEndereco.Rows[cont].Cells[5].Value = item.Enderecos;
                dgvEndereco.Rows[cont].Cells[6].Value = item.Enderecos;
                dgvEndereco.Rows[cont].Cells[7].Value = item.Enderecos;
                dgvEndereco.Rows[cont].Cells[8].Value = item.Enderecos;
                dgvEndereco.Rows[cont].Cells[9].Value = item.Enderecos;

                dgvTelefone.Rows.Add();
                dgvTelefone.Rows[cont].Cells[0].Value = item.Telefones.ToString();
                dgvTelefone.Rows[cont].Cells[1].Value = item.Telefones;
                dgvTelefone.Rows[cont].Cells[2].Value = item.Telefones;

                cont++;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (btnBuscar.Text == "...")
            {
                txtId.ReadOnly = false;

                txtId.Focus();

                btnBuscar.Text = "Obter";
            }
            else if (txtId.Text != String.Empty)
            {
                txtId.ReadOnly = true;

                btnBuscar.Text = "...";

                CarregaGridObterPorId(int.Parse(txtId.Text));
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisarAtivo.Text.Length > 1)
            {
                CarregaGridListarAtivo(txtPesquisarAtivo.Text);
            }
            else if (txtPesquisarAtivo.Text.Length < 2)
            {
                CarregaGridListarAtivo();
            }
        }

        private void txtPesquisarInativos_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisarInativos.Text.Length > 1)
            {
                CarregaGridListarInativo(txtPesquisarInativos.Text);
            }
            else if (txtPesquisarInativos.Text.Length < 2)
            {
                CarregaGridListarInativo();
            }
        }
    }
}
