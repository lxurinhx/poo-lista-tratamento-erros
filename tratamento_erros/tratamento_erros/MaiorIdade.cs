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
    public partial class MaiorIdade : Form
    {
        public MaiorIdade()
        {
            InitializeComponent();
        }

        Pessoa pessoa = new Pessoa();
        int cont = 0;

        private void btnVerificar_Click(object sender, EventArgs e)
        {
                try
                {
                    pessoa.Nome = txtNome.Text;
                    pessoa.Idade = txtIdade.Text;
                    pessoa.MaiorIdade(int.Parse(pessoa.Idade));

                    if (cont == 2)
                    {
                        MessageBox.Show(pessoa.Mostrar());
                    }
                    cont++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }

        }
    }
}
