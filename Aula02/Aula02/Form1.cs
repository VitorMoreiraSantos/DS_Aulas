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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você deseja fechar a janela?", "Fechar Janela", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonExibir_Click(object sender, EventArgs e)
        {
            
            string nome = textBoxNome.Text;

            string dataNascimento = dateTimePickerNascimento.Value.ToString("dd/MM/yyyy");

            string sexo = comboBoxSexo.SelectedItem.ToString();

            string mensagem = $"Nome: {nome}\nData de Nascimento: {dataNascimento}\nSexo: {sexo}";

            MessageBox.Show(mensagem, "Informações Fornecidas");
        }
    }
}
