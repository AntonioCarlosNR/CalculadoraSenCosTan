using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2SenConsTan.Modelo
{
    public abstract class AbsPropriedades
    {
        public string mensagem { get; set; }
        public double n1 { get; set; }
        public double cosseno { get; set; }
        public string numero { get; set; }
        public string resposta { get; set; }
        public double seno { get; set; }
        public double tangente { get; set; }

        public AbsPropriedades(double n1)
        {
            this.n1 = n1;
            this.Executar();
        }

        public AbsPropriedades(string numero)
        {
            this.numero = numero;
            this.Executar();
        }

        public virtual void Executar()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
