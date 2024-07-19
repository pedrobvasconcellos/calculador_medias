using System;

class CalculadoraDeMedia 
{
    static void Main() 
    {
        Console.WriteLine("----------------");
        Console.WriteLine("\nBem vindo(a) ao calculador de médias");
        Console.WriteLine("---------------");

        while(true)
        {
            Console.WriteLine("1 - Calcular a média");
            Console.WriteLine("2 - Sair");
            int escolha = int.Parse(Console.ReadLine());

            switch(escolha)
            {
                case 1:
                    Console.WriteLine("----------------");
                    Console.Write("Quantos números você deseja inserir? ");
                    int quantidade = int.Parse(Console.ReadLine());

                    int[] numeros = new int[quantidade];

                    for(int i = 0; i < quantidade; i++) 
                    {
                        Console.Write("Digite o {0}° número: ", i + 1);
                        numeros[i] = int.Parse(Console.ReadLine());
                    }

                    double media = CalcularMedia(numeros);
                    int soma = CalcularSoma(numeros);
                    Console.WriteLine("----------------");
                    Console.WriteLine("A soma dos números é: {0}", soma);
                    Console.WriteLine("A média dos números é: {0}", media);
                    Console.WriteLine("----------------");
                    break;

                case 2:
                    Console.WriteLine("----------------");
                    Console.WriteLine("Obrigado por usar");
                    Console.WriteLine("---------------");
                    return;

                default:
                    Console.WriteLine("----------------");
                    Console.WriteLine("Escolha inválida. Tente novamente.");
                    break;
            }
        }
    }

    static int CalcularSoma(int[] numeros)
    {
        int soma = 0;

        for(int i = 0; i < numeros.Length; i++) 
        {
            soma += numeros[i];
        }

        return soma;
    }

    static double CalcularMedia(int[] numeros) 
    {
        int soma = CalcularSoma(numeros);
        double media = (double)soma / numeros.Length;
        return media;
    }
}
