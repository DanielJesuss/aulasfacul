using System;

class Program
{
    public static void Main(string[] args)
    {
        int valorSaque, resto, quantidade;
        Console.Write("Digite o valor do saque: ");
        valorSaque = int.Parse(Console.ReadLine());

        //Quantidade de notas de 100
        quantidade = valorSaque / 100;
        resto = valorSaque % 100;

        if (quantidade > 0)
        {
            Console.WriteLine("Notas de R$100: " + quantidade);
        }

        //Quantidade de notas de 50
        quantidade = resto / 50;
        resto = valorSaque % 50;

        if (quantidade > 0)
        {
            Console.WriteLine("Notas de R$50: " + quantidade);
        }
        //Quantidade de notas de 20
        quantidade = resto / 20;
        resto = valorSaque % 20;

        if (quantidade > 0)
        {
            Console.WriteLine("Notas de R$20: " + quantidade);
        }

        //Quantidade de notas de 10
        quantidade = resto / 10;
        resto = valorSaque % 10;

        if (quantidade > 0)
        {
            Console.WriteLine("Notas de R$10: " + quantidade);
        }

        //Se sobrar algum valor, não é possivel realizar o saque
        if (resto > 0)
        {
            Console.WriteLine("Não foi possivel realizar o saque");
        }

        Console.ReadLine();

    }
}