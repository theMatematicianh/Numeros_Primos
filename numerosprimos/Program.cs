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


            Console.WriteLine("Digite o intervalo que deseja ser verificado: ");
            Console.WriteLine(" ");

            Console.WriteLine("O primeiro numero:");
            int numero1 = int.Parse(Console.ReadLine());


            Console.WriteLine("O segundo numero:");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            if(numero1 > numero2)
            {
                 maiornumero = numero1;
                 menornumero = numero2;
            }
            else
            {
                 maiornumero = numero2;
                 menornumero = numero1;
            }

            List<int> numerosLista = new List<int>();

            for(int i = menornumero ; menornumero <= maiornumero; menornumero++)
            {

                numerosLista.Add(menornumero);

            }

            Console.WriteLine("Os numeros primos do intervalo são...");
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
                    Console.WriteLine(numerol);
                }
            }









        }
    }
}
