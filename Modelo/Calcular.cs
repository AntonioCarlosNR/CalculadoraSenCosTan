using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2SenConsTan.Modelo
{
    public class Calcular: AbsPropriedades
    {
        public Calcular(double n1):base(n1)
        {
            this.n1 = n1;
        }

        public override void Executar()
        {
            this.seno = Math.Sin(n1);
            this.cosseno = Math.Cos(n1);
            this.tangente = Math.Tan(n1);

            this.resposta = $"Seno = {this.seno};\n Coseno = {cosseno};\n Tangente = {this.tangente}";
        }
    }
}
