using System;
using Musica.Entities;

namespace Musica
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Quantas vezes você vai querer escolher uma musica?");
                var qtde = int.Parse(Console.ReadLine());
                for (int i = 0; i < qtde; i++)
                {
                    Console.WriteLine("Digite dois numeros inteiros de 0 a 9: ");
                    string[] numeros = Console.ReadLine().Split(' ');
                    var botao1 = int.Parse(numeros[0]);
                    var botao2 = int.Parse(numeros[1]);
                    SomarNumeroInteiro calculo = new SomarNumeroInteiro(botao1, botao2);
                    Console.WriteLine(calculo.CalcularSoma());
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro, por favor digite um numero inteiro");
            }
        }
    }
}
