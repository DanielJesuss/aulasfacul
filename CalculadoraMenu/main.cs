using System;

class Program {
  public static void Main (string[] args) {
    double num1, num2, resultado;

    char operacao;

  Console.WriteLine("Calculadora simples com menu");
  Console.Write("Digite o primeiro numero: ");
  num1 = double.Parse(Console.ReadLine());
  Console.Write("Digite o segundo numero: ");
  num2 = double.Parse(Console.ReadLine());

    Console.WriteLine("\nSelecione a Operação");
    Console.WriteLine("1 - Adição");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divisao");
    Console.Write("Opção ");

    operacao = char.Parse(Console.ReadLine());

    if(operacao == '1')
    {
     resultado = num1 + num2;
     Console.WriteLine("Resultado: " + resultado);
    } 
    else if(operacao == '2')
    {
     resultado = num1 - num2;
     Console.WriteLine("Resultado: " + resultado);
    }
    else if(operacao == '3')
    {
     resultado = num1 * num2;
     Console.WriteLine("Resultado: " + resultado);
    }
    else if (operacao == '4')
    {
     resultado = num1 / num2;
     Console.WriteLine("Resultado: " + resultado);
    }
    Console.ReadLine();
  }
}