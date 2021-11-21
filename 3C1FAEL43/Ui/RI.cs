using _3C1FAEL43.Code.BLL;
using _3C1FAEL43.Code.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3C1FAEL43.Ui
{
    public partial class RI : Form
    {
        RIBLL medbll = new RIBLL();
        RIDTO meddto = new RIDTO(); 
        public RI()
        {
            InitializeComponent();
            dataGridView1.DataSource = medbll.Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           
            meddto.Produto = txtProduto.Text;
            meddto.Quantidade = txtQuantidade.Text;

            medbll.Inserir(meddto);
            MessageBox.Show("Cadastrado com sucesso!", "RI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = medbll.Listar();
            //limpar campos
            txtId.Clear();
            txtProduto.Clear();
            txtQuantidade.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            meddto.Id = int.Parse(txtId.Text);
            meddto.Produto = txtProduto.Text;
            meddto.Quantidade = txtQuantidade.Text;

            medbll.Editar(meddto);
            MessageBox.Show("Editado com sucesso!", "RI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = medbll.Listar();
            //limpar campos
            txtId.Clear();
            txtProduto.Clear();
            txtQuantidade.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            meddto.Id = int.Parse(txtId.Text);
            meddto.Produto = txtProduto.Text;
            meddto.Quantidade = txtQuantidade.Text;

            medbll.Excluir(meddto);
            MessageBox.Show("Excluido com sucesso!", "RI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = medbll.Listar();
            //limpar campos
            txtId.Clear();
            txtProduto.Clear();
            txtQuantidade.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtProduto.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtQuantidade.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
