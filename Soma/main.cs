using System;

class Program {
  public static void Main (string[] args) {
    int num1, num2, soma;

    Console.Write("Digite o primeiro numero: ");
    num1= int.Parse(Conosle.ReadLine());
    
    Console.Write("Digite o segundo numero: ");
    num2= int.Parse(Conosle.ReadLine());

    soma = num1 + num2;

    Console.WriteLine("A soma dos dois numero é: " + soma);
  }
}
