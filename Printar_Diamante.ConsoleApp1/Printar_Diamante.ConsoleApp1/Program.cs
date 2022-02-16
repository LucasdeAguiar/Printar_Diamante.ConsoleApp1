using System;

namespace Printar_Triangulo.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //inicialização de variáveis

            int x;


            //Verificação se o número é ímpar

            do
            {
                Console.Clear();
                Console.WriteLine("Digite um número ímpar:");
                x = System.Convert.ToInt32(Console.ReadLine());
                if (x % 2 == 0)
                {
                    Console.WriteLine("Erro, digite um valor válido..");
                }

            } while (x % 2 == 0);


            //Inicialização do for


            //Parte de cima do diamante
            for (int i = 1; i < x; i++)
            {


                //for para printar espaço
                for (int j = i; j <= x; j++)
                {

                    if (i % 2 != 0)
                    {
                        Console.Write(" ");
                    }
                }

                //for para printar x
                for (int k = 0; k < i; k++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write(" ");
                        Console.Write("X");

                    }

                }
                if (i % 2 != 0)
                {
                    Console.Write("\n");
                }

            }

            //Parte de baixo do diamante




            for (int i = x; i >= 1; i--)
            {

                //for para printar espaço
                for (int j = i; j <= x; j++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write(" ");
                    }
                }

                //for para printar x
                for (int k = 0; k < i; k++)
                {
                    if (i % 2 != 0)
                    {
                        Console.Write(" ");
                        Console.Write("X");

                    }

                }

                if (i % 2 != 0)
                {

                    Console.Write("\n");
                }

            }


        }

    }
}

