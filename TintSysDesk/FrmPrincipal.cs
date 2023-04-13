using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TintSysDesk
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios = new FrmUsuarios();
            frmUsuarios.MdiParent = this;
            frmUsuarios.Show();
        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.MdiParent = this;
            frmClientes.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos frmProdutos = new FrmProdutos();
            frmProdutos.MdiParent = this;
            frmProdutos.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
