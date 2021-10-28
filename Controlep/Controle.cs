using Ex2SenConsTan.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2SenConsTan.Controlep
{
     public class Controle : AbsPropriedades
    {
        AbsPropriedades valida;
        //chama a base da classe absPropriedades
        public Controle(string numero):base(numero)
        {
            this.numero = numero;
        }

        public override void Executar()
        {
            valida = new Validacao(numero);

            if (valida.mensagem == "valido")
            {
                this.n1 = valida.n1;

                valida = new Calcular(this.n1);
            }
            this.resposta = valida.resposta;

        }

    }
}
