using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TintSysClass;
using static System.Net.Mime.MediaTypeNames;

namespace TintSysDesk
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (pnlAlterar.Visible != true)
            {
                tbcInserir.Visible = false;
                pnlConsulta.Visible = false;
                pnlAlterar.Visible = true;
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (tbcInserir.Visible != true)
            {
                pnlConsulta.Visible = false;
                pnlAlterar.Visible = false;
                tbcInserir.Visible = true;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (pnlConsulta.Visible != true)
            {
                tbcInserir.Visible = false;
                pnlAlterar.Visible = false;
                pnlConsulta.Visible = true;
            }
        }

        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Começo Consultar

        private void button1_Click(object sender, EventArgs e)
        {
            CarregaGridListar();
            txtId.Clear();
            txtPesquisarAtivo.Clear();
            chkInativos.Checked = false;
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CarregaGridListar();
            ValidarGroup();
        }

        public void CarregaGridListar(string texto = "")
        {
            List<Cliente> lista = null;
            List<Endereco> listaEndereco = null;
            List<Telefone> listaTelefone = null;
            
            if (texto != string.Empty)
                lista = Cliente.Listar(texto);
            else
                lista = Cliente.Listar();

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

            cont = 0;
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

            cont = 0;
            foreach (Telefone item in listaTelefone)
            {
                dgvTelefone.Rows.Add();
                dgvTelefone.Rows[cont].Cells[0].Value = item.Id.ToString();
                dgvTelefone.Rows[cont].Cells[1].Value = item.Numero;
                dgvTelefone.Rows[cont].Cells[2].Value = item.Tipo;
                cont++;
            }
        }

        private void CarregaGridListarInativo(string texto = "")
        {
            List<Cliente> lista = null;
            List<Endereco> listaEndereco = null;
            List<Telefone> listaTelefone = null;

            if (texto != string.Empty)
                lista = Cliente.Listar(texto, 0);
            else
                lista = Cliente.Listar("", 0);

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

            cont = 0;
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

            cont = 0;
            foreach (Telefone item in listaTelefone)
            {
                dgvTelefone.Rows.Add();
                dgvTelefone.Rows[cont].Cells[0].Value = item.Id.ToString();
                dgvTelefone.Rows[cont].Cells[1].Value = item.Numero;
                dgvTelefone.Rows[cont].Cells[2].Value = item.Tipo;
                cont++;
            }
        }

        public void CarregaGridObterPorId(int id)
        {
            List<Cliente> lista = null;
            List<Endereco> listaEndereco = null;
            List<Telefone> listaTelefone = null;

            lista = Cliente.ObterPorIdLista(id);
            listaEndereco = Endereco.ListarPorCliente(id);
            listaTelefone = Telefone.ListarPorCliente(id);

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

            cont = 0;
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

            cont = 0;
            foreach (Telefone item in listaTelefone)
            {
                dgvTelefone.Rows.Add();
                dgvTelefone.Rows[cont].Cells[0].Value = item.Id.ToString();
                dgvTelefone.Rows[cont].Cells[1].Value = item.Numero;
                dgvTelefone.Rows[cont].Cells[2].Value = item.Tipo;
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

                txtId.Clear();
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
                CarregaGridListar(txtPesquisarAtivo.Text);
            }
            else if (txtPesquisarAtivo.Text.Length < 2)
            {
                CarregaGridListar();
            }
        }

        private void chkInativos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInativos.Checked == true)
            {
                CarregaGridListarInativo();
                txtId.Clear();
                txtPesquisarAtivo.Clear();
            }
            else
            {
                CarregaGridListar();
                txtId.Clear();
                txtPesquisarAtivo.Clear();
            }
        }

        // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++ Fim Consultar

        private void btnProxDados_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Focus();
                gbEnderecos.Enabled = false;
                gbTelefones.Enabled = false;
                MessageBox.Show("Informe o nome do cliente");
            }
            else if (txtEmail.Text == "")
            {
                txtEmail.Focus();
                gbEnderecos.Enabled = false;
                gbTelefones.Enabled = false;
                MessageBox.Show("Informe o E-mail do cliente");
            }
            else if (mstCpf.Text == "")
            {
                mstCpf.Focus();
                gbEnderecos.Enabled = false;
                gbTelefones.Enabled = false;
                MessageBox.Show("Digite o CPF do cliente");
            }
            else
            {
                gbEnderecos.Enabled = true;
                gbTelefones.Enabled = true;
                tbcInserir.SelectedTab = tabEnderecos;
            }
        }

        private bool ValidarGroup()
        {
            bool teste = true;

            if (txtNome.Text == "")
            {
                gbEnderecos.Enabled = false;
                gbTelefones.Enabled = false;
                return teste = false;
            }
            else if (txtEmail.Text == "")
            {
                gbEnderecos.Enabled = false;
                gbTelefones.Enabled = false;
                return teste = false;
            }
            else if (mstCpf.Text == "")
            {
                gbEnderecos.Enabled = false;
                gbTelefones.Enabled = false;
                return teste = false;
            }
            else
            {
                return teste;
            }
        }

        private void btnVoltarEnderecos_Click(object sender, EventArgs e)
        {
            tbcInserir.SelectedTab = tabDadosPessoais;
        }

        private void btnProximoEndereco_Click(object sender, EventArgs e)
        {
            tbcInserir.SelectedTab = tabTelefones;
        }

        private void btnPronto_Click(object sender, EventArgs e)
        {
            List<Endereco> ListaEndereco = new List<Endereco>();
            List<Telefone> ListaTelefone = new List<Telefone>();

            Cliente cliente = new Cliente(
                txtNome.Text,
                txtEmail.Text,
                mstCpf.Text,
                ListaEndereco,
                ListaTelefone);

            if (cliente.Inserir())
            {
                MessageBox.Show("Cliente Cadastrado com sucesso");
            }
            else
            {
                MessageBox.Show("ERRO: Cliente não cadastrado");
            }
        }

        private void btnNovoEnderecos_Click(object sender, EventArgs e)
        {
            mstCEP.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtUF.Clear();
            txtTipo.Clear();
            mstCEP.Focus();
        }

        private void btnVoltarTelefones_Click(object sender, EventArgs e)
        {
            tbcInserir.SelectedTab = tabEnderecos;
        }

        private void btnNovoTelefones_Click(object sender, EventArgs e)
        {
            mstNumeroTelefone.Clear();
            txtTipoTelefone.Clear();
            mstNumeroTelefone.Focus();
        }

        private void btnAdicionarTelefone_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionarEnderecos_Click(object sender, EventArgs e)
        {

        }
    }
}
