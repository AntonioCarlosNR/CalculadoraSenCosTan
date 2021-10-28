using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2SenConsTan.Modelo
{
    public class Validacao: AbsPropriedades
    {
        public Validacao(string numero):base(numero)
        {
            this.numero = numero;
        }

        public override void Executar()
        {
            try
            {
                this.n1 = Convert.ToDouble(this.numero);
                
                this.mensagem = "valido";
            }
            catch (Exception)
            {
                this.mensagem = "Entrada Invalida!";
            }

        }

    }
}
