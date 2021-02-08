using System;

/*
Escreva um programa onde o usuário digite um valor inteiro e o programa escreva a musica do “Elefante incomoda” correspondente ao valor digitado: 
Exemplo: Usuário digitou o nº 3 
Saída: Incomoda Incomoda Incomoda muito mais

*/

namespace ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero de elefantes!:" );

            int contador = int.Parse(Console.ReadLine());

            int incomoda = contador;


            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine("Incomoda");
            } 
            Console.WriteLine("muito mais");






            

            }
        }
    }

