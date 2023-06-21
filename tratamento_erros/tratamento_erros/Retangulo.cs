using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tratamento_erros
{
    public class Retangulo
    {
        private double baser { get; set; }

        public string Baser
        {
            get
            {
                return baser.ToString();
            }
            set
            {
                if (value != String.Empty)
                    this.baser = double.Parse(value);
                else
                {
                    throw new Exception("insira um valor válido para a base");
                }
            }
        }

        private double altura { get; set; }

        public string Altura
        {
            get
            {
                return altura.ToString();
            }
            set
            {
                if (value != String.Empty)
                    this.altura = double.Parse(value);
                else
                {
                    throw new Exception("insira um valor válido para a altura");
                }
            }
        }

        public double AreaRetangulo(double vlbase, double vlaltura)
        {
            return vlbase * vlaltura;
        }
    }
}
