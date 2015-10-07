using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atividade;

namespace Atividade
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.ClearSelected();
            for (int i = 0; i < Atividade.count; i++)
            {
                if (textBox1.Text == Atividade.nomes[i]){
                    listBox1.Items.Add("Nome: " + Atividade.nomes[i] + ". Idade: " + Atividade.idades[i] + ".");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.ClearSelected();
            for (int i = 0; i < Atividade.count; i++)
            {
                if (int.Parse(textBox2.Text) == Atividade.idades[i])
                {
                    listBox1.Items.Add("Nome: " + Atividade.nomes[i] + ". Idade: " + Atividade.idades[i] + ".");
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
