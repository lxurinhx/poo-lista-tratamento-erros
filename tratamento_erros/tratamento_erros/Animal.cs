using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tratamento_erros
{
    public class Animal
    {
        private string animal { get; set; }
        private int coelhos { get; set; }
        private int cachorros { get; set; }
        private int gatos { get; set; }
        private string raca { get; set; }
        private string nome { get; set; }

        public string Raca
        {
            get
            {
                return raca;
            }
            set
            {
                this.raca = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                this.nome = value;
            }
        }

        public void TipoAnimal(string animalTipo)
        {
                this.animal = animalTipo.ToLower();
                if (this.animal == "cachorro") this.cachorros++;
                else if (this.animal == "gato") this.gatos++;
                else if (this.animal == "coelho") this.coelhos++;
                else { throw new Exception("invalido, so pode cachorro gato ou coelho"); }
        }
        public string QuantAnimais()
        {
            return $"Foram informados um total de {this.gatos} gatos, \n{this.cachorros} cachorros \n e {this.coelhos} coelhos";
        }

    }


}
