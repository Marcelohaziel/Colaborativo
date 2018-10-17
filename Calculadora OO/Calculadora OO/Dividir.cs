using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_OO
{
    class Dividir
    {
        public Dividir()
        {
            Console.WriteLine("Objeto Dividir Criado.");
        }
        public Dividir(int num1, int num2){
            int total = num1 / num2;
            Console.WriteLine("Resultado da Div: " + total);
        }

        public void DivEterno()
        {

        }
    }
}
