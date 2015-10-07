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
    public partial class FormCadastrar : Form
    {

        public FormCadastrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nome.Text == "" || idade.Text == "" || numero.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else {
                if (nome.Text == "")
                {
                    MessageBox.Show("Preencha o campo nome");
                }
                else {
                    Atividade.nomes[Atividade.count] = nome.Text;
                    Atividade.idades[Atividade.count] = int.Parse(idade.Text);
                    MessageBox.Show(Atividade.count.ToString());
                    Atividade.count++;
                    this.Close();
                }
                
            }
        
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
