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
    public partial class CalcArea : Form
    {
        public CalcArea()
        {
            InitializeComponent();
        }

        Retangulo retangulo = new Retangulo();

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                retangulo.Baser = txtBase.Text;
                retangulo.Altura = txtAltura.Text;

                MessageBox.Show($"a área do retângulo mede {retangulo.AreaRetangulo(double.Parse(retangulo.Baser), double.Parse(retangulo.Altura))} cm²");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERRO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}
