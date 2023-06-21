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
    public partial class ExAnimal : Form
    {
        public ExAnimal()
        {
            InitializeComponent();
        }

        Animal animal = new Animal();
        int contador = 0;
        string animall;
        string nome;
        string raca;


        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                nome = txtNome.Text;
                raca = txtRaca.Text;
                animall = txtAnimal.Text;
                animal.TipoAnimal(animall);
                contador++;
                
                if (contador == 5)
                {
                    MessageBox.Show(animal.QuantAnimais());
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
    }
}
