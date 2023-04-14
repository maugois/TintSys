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
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            grbDados.Enabled = true;
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            cmbCliente.DataSource = Cliente.Listar("", 1);
            cmbCliente.DisplayMember = "Nome";
            cmbCliente.ValueMember = "Id";

            cmbUsuario.DataSource = Usuario.Listar();
            cmbUsuario.DisplayMember= "Nome";
            cmbUsuario.ValueMember = "Id";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido(Cliente.ObterPorId(
                Convert.ToInt32(cmbCliente.SelectedValue)),
                Usuario.ObterPorId(Convert.ToInt32(cmbUsuario.SelectedValue))
                );

            pedido.Inserir();

            Pedido novoPedido = Pedido.ObterPorId(pedido.Id);
            lblStatus.Text = novoPedido.Status + " - " + novoPedido.HashCode;
            txtId.Text = novoPedido.Id.ToString();
        }
    }
}
