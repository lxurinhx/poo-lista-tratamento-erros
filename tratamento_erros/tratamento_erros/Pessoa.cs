using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tratamento_erros
{
    public class Pessoa
    {
        private string nome { get; set; }
        private int idade { get; set; }

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (value != String.Empty)
                {
                    nome = value;
                }
                else
                {
                    throw new Exception("insira o nome");
                }
            }
        }

        public string Idade
        {
            get
            {
                return idade.ToString();
            }
            set
            {
                if (value != String.Empty)
                {
                    idade = int.Parse(value);
                }
                else
                {
                    throw new Exception("insira a idade");
                }
            }
        }

        private int idadeMaior { get; set; }
        private string nomeMaior { get; set; }

        public void MaiorIdade(int idade)
        {
            this.idade = idade;
            if (this.idadeMaior < idade)
            {
                this.nomeMaior = this.nome;
                this.idadeMaior = idade;
            }
        }

        public string Mostrar()
        {
            return $"pessoa mais velha: {this.nomeMaior}\nidade : {this.idadeMaior}";
        }

    }
}
