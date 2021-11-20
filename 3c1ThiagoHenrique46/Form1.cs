using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3c1ThiagoHenrique46.Code.BLL;
using _3c1ThiagoHenrique46.Code.DTO;

namespace _3c1ThiagoHenrique46
{
    public partial class Form1 : Form
    {
        produtosbll produtos = new produtosbll();
        Produto produtosdto = new Produto();
        public Form1()
        {
            InitializeComponent();
        }

        private void inserir_Click(object sender, EventArgs e)
        {
            produtosdto.Nome = NOMEtxt.Text;
            produtosdto.Preco = int.Parse(PRECOtxt.Text);

            produtos.ADD(produtosdto);
            MessageBox.Show("O nome e preço do brinquedo foi inserido");
            dataGridView1.DataSource = produtos.LIST();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            produtosdto.Nome = NOMEtxt.Text;
            produtosdto.Preco = int.Parse(PRECOtxt.Text);
            produtosdto.Id = int.Parse(IDtxt.Text);

            produtos.EDIT(produtosdto);
            MessageBox.Show("O nome e preço do brinquedo foi editado");
            dataGridView1.DataSource = produtos.LIST();
        }

        private void excluir_Click(object sender, EventArgs e)
        {
            produtosdto.Id = int.Parse(IDtxt.Text);

            produtos.DELETE(produtosdto);
            MessageBox.Show("O nome e preço do brinquedo foi deletado");
            dataGridView1.DataSource = produtos.LIST();
        }

        private void listar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = produtos.LIST();
        }
    }
}
