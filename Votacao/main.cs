using System;

class Program {
  public static void Main (string[] args) {
    int idade;

  Console.WriteLine("digite sua idade: ");
    idade = int.Parse(Console.ReadLine());

    if (idade >= 16) {
      Console.WriteLine("voce pode votar");
    } else {
      Console.WriteLine("voce nao pode votar");
    }
    Console.ReadLine();
    }
}