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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuario usuario = Usuario.ObterPorId(Convert.ToInt32(txtId.Text));

            if (usuario != null)
            {
                txtNome.Text = usuario.Nome;
                txtEmail.Text = usuario.Email;
                txtNivel.SelectedValue = usuario.Nivel.Id;
                checkBox1.Checked = usuario.Ativo;
                txtEmail.Enabled = false;

            }
            else
            {
                MessageBox.Show("Usuário não localizado!");
                txtSigla.Clear();
                txtNomeNivel.Clear();
                txtIdNivel.Focus();
                txtIdNivel.Clear();
            }
        } 

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Usuario usuario= new Usuario(
                txtNome.Text, txtEmail.Text, txtSenha.Text,
                Nivel.ObterPorId(Convert.ToInt32(txtNivel.SelectedValue)));

            usuario.Inserir();

            txtId.Text = usuario.Id.ToString();

            // Carrega lista do usuário
            CarregaListaGrid();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // Carregamento de Nível
            CarregaTxtNivel();

            // Carrega lista do Usuário
            CarregaListaGrid();

            // Carrega lista do Nivel
            CarregaListaGridNiveis();
        }

        private void CarregaTxtNivel()
        {
            // Carregamento de nível
            txtNivel.DataSource = Nivel.Listar();
            txtNivel.ValueMember = "Id";
            txtNivel.DisplayMember = "Nome";
        }

        private void CarregaListaGrid()
        {
            // Listar Usuário no Data View Grid
            List<Usuario> lista = Usuario.Listar();

            int linha = 0;
            dgvUsuarios.Rows.Clear();
            foreach (Usuario usuario in lista)
            {
                dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[linha].Cells[0].Value = usuario.Id.ToString();
                dgvUsuarios.Rows[linha].Cells[1].Value = usuario.Nome;
                dgvUsuarios.Rows[linha].Cells[2].Value = usuario.Email;
                dgvUsuarios.Rows[linha].Cells[3].Value = usuario.Nivel.Nome;
                dgvUsuarios.Rows[linha].Cells[4].Value = usuario.Ativo;

                linha++;
            }
        }

        private void CarregaListaGridNiveis()
        {
            // Listar Usuário no Data View Grid
            List<Nivel> lista = Nivel.Listar();

            int linha = 0;
            dgvNiveis.Rows.Clear();
            foreach (Nivel nivel in lista)
            {
                dgvNiveis.Rows.Add();
                dgvNiveis.Rows[linha].Cells[0].Value = nivel.Id.ToString();
                dgvNiveis.Rows[linha].Cells[1].Value = nivel.Nome;
                dgvNiveis.Rows[linha].Cells[2].Value = nivel.Sigla;

                linha++;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnInserirNivel_Click(object sender, EventArgs e)
        {
            Nivel nivel = new Nivel(txtNomeNivel.Text, txtSigla.Text);

            nivel.Inserir();

            CarregaTxtNivel();
        }

        private void btnConsultarNivel_Click(object sender, EventArgs e)
        {
            Nivel nivel = Nivel.ObterPorId(Convert.ToInt32(txtIdNivel.Text));

            if (nivel != null) 
            { 
                txtNomeNivel.Text = nivel.Nome;
                txtSigla.Text = nivel.Sigla;
            } 
            else
            {
                MessageBox.Show("Nível não localizado!");
                txtSigla.Clear();
                txtNomeNivel.Clear();
                txtIdNivel.Focus();
                txtIdNivel.Clear();
            }

        }

        private void txtIdNivel_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvNiveis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditarNivel_Click(object sender, EventArgs e)
        {
            Nivel nivel = new Nivel(Convert.ToInt32(txtIdNivel.Text), txtNomeNivel.Text, txtSigla.Text);

            nivel.Atualizar();

            CarregaListaGrid();
            CarregaTxtNivel();
            CarregaListaGridNiveis();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.Id = Convert.ToInt32(txtId.Text);
            usuario.Nome = txtNome.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Nivel.Id = Convert.ToInt32(txtNivel.SelectedValue);

            usuario.Atualizar();
            
            CarregaListaGrid();
        }

        private void txtNivel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
