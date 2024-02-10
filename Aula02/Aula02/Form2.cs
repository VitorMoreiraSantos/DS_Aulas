using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você deseja fechar a janela?", "Fechar Janela", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonExibir_Click(object sender, EventArgs e)
        {

            string nome = textBoxProduto.Text;

            string mensagem = $"Nome do Produto: {nome}";

            MessageBox.Show(mensagem, "Informações Fornecidas");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 produtotela = new Form2();
            produtotela.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form1 usuariotela = new Form1();
            usuariotela.ShowDialog();
        }

        private void subMenu21ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 sobre = new AboutBox1();
            sobre.ShowDialog();
        }

        private void subMenu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 produtotela = new Form2();
            produtotela.ShowDialog();
        }

        private void subMenu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 usuariotela = new Form1();
            usuariotela.ShowDialog();
        }
    }
}
