using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidadorCPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cpf = maskedTextBox1.Text;

            bool verifica = true;

            verifica = Validacoes.CPFValido(cpf);
            if (verifica == true)
            {
                MessageBox.Show("CPF válido!");
            }
            else
            {
                MessageBox.Show("CPF inválido!");
            }

        }
    }
}
