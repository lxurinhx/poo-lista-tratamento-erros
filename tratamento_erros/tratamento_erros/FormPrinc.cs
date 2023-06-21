using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tratamento_erros
{
    public partial class FormPrinc : Form
    {
        public FormPrinc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExAnimal animal = new ExAnimal();
            animal.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalcArea calcArea = new CalcArea();
            calcArea.ShowDialog();
        }

        private void btnQuestao3_Click(object sender, EventArgs e)
        {
            MaiorIdade idade = new MaiorIdade();
            idade.ShowDialog();
        }
    }
}
