using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_case
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboSemana.Text)
            {
                case "Domingo":
                    MessageBox.Show("Você escolheu Domingo que é o 1° dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Segunda":
                    MessageBox.Show("Você escolheu Segunda que é o 2° dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Terça":
                    MessageBox.Show("Você escolheu Terça que é o 3° dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Quarta":
                    MessageBox.Show("Você escolheu Quarta que é o 4° dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Quinta":
                    MessageBox.Show("Você escolheu Quinta que é o 5° dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Sexta":
                    MessageBox.Show("Você escolheu Sexta que é o 6° dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Sabado":
                    MessageBox.Show("Você escolheu Sábado que é o 7° dia da semana", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }
    }
}
