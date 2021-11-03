/* Leia um valor inteiro N. Este valor será a quantidade de valores que serão lidos em seguida.
Para cada valor lido, mostre uma mensagem em inglês dizendo se este valor lido é par (EVEN), ímpar (ODD),
positivo (POSITIVE) ou negativo (NEGATIVE). No caso do valor ser igual a zero (0), embora a descrição correta
seja (EVEN NULL), pois por definição zero é par, seu programa deverá imprimir apenas NULL.*/

using System; 

class Desafio {

        public static void Main()
        {

            int tc, i, x;
            tc = int.Parse(Console.ReadLine());
            for (i = 1; i <= tc; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x==0)
                {
                    Console.WriteLine("NULL");
                }
                else if (x % 2 == 0)
                {
                    if (x > 0)
                    {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("EVEN NEGATIVE");
                    }

                }
                else
                {
                    if (x > 0)
                    {
                        Console.WriteLine("ODD POSITIVE");
                    }
                    else
                    {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }

            }

            Console.ReadLine();
        }

}
 