using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _221048
{
    public partial class TecnoMarket : Form
    {
        public TecnoMarket()
        {
            InitializeComponent();
        }

        int numeroVenda = 1;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calcularValorTotal()
        {
            double valorTotal = 0;

            foreach(DataGridViewRow linha in dataGridView.Rows)
            {
                string descricao = linha.Cells["Descrição"].Value.ToString();
                int quantidade = int.Parse(linha.Cells["Quantidade"].Value.ToString());
                double valorUnitario = double.Parse(linha.Cells["ValorUnitário"].Value.ToString());

                double valorProduto = quantidade * valorUnitario;
                valorTotal += valorProduto;
            }

            labelValorTotal.Text = valorTotal.ToString("C");
        }

        private void limparTextBoxes()
        {
            textBoxDescricao.Clear();
            textBoxQuantidade.Clear();
            textBoxValorUnitario.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string descricao = textBoxDescricao.Text;
            string quantidade = textBoxQuantidade.Text;
            string valor = textBoxValorUnitario.Text;

            if (descricao == "" || quantidade == "" || valor == "") return;

            dataGridView.Rows.Add(descricao, quantidade, valor);
            calcularValorTotal();
            limparTextBoxes();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxQuantidadeItemSelecionado.Text = dataGridView.CurrentRow.Cells["Quantidade"].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelVendaAtual.Text = numeroVenda.ToString();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            dataGridView.CurrentRow.Cells["Quantidade"].Value = textBoxQuantidadeItemSelecionado.Text;
            calcularValorTotal();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            limparTextBoxes();
        }

        private void buttonSalvarVenda_Click(object sender, EventArgs e)
        {
            limparTextBoxes();
            dataGridView.RowCount = 0;
            numeroVenda++;
            calcularValorTotal();
            labelVendaAtual.Text = numeroVenda.ToString();
            textBoxQuantidadeItemSelecionado.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 0)
            {
                dataGridView.Rows.RemoveAt(dataGridView.CurrentRow.Index);
                calcularValorTotal();
                textBoxQuantidadeItemSelecionado.Text = "";
            }

        }
    }
}
