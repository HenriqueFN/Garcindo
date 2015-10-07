using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade
{
    public partial class Atividade : Form
    {

        public static String[] nomes = new String[50];
        public static int[] idades = new int[50];
        public static int count;

        public Atividade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FormCadastrar newform = new FormCadastrar();
           newform.Show();
       }

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Atividade_Load(object sender, EventArgs e)
        {

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsulta newform = new FormConsulta();
            newform.Show();
        }
    }
}
