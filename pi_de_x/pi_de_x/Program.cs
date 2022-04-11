using System;
using System.Collections.Generic;

namespace numerosprimos
{
    class Program
    {
        static void Main(string[] args)
        {
            int maiornumero;
            int menornumero;


            Console.WriteLine("Digite o valor de pi(x): ");
        
            int numero = int.Parse(Console.ReadLine());



            List<int> numerosLista = new List<int>();

            for (int i = 1; i <= numero; i++)
            {

                numerosLista.Add(i);

            }

            int soma = 0;
            foreach (int numerol in numerosLista)
            {
                int count = 0;
               

                //contagem de divisores de um número
                for (int i = 1; i <= numerol; i++)
                {
                    if (numerol % i == 0)
                    {
                        count += 1;
                    }
                }

                //verificando se o número é primo ou não
                if (count == 2)
                {
                    soma += 1;
                }
            }
            Console.WriteLine("O valor de pi(x) é:");
            Console.WriteLine(soma);








        }
    }
}
