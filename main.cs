using System;

class Program {
  public static void Main (string[] args) {
    int numero1, numero2;

    Console.WriteLine("Digite um numero: ");
    numero1 = int.Parse(Console.ReadLine());
    numero2 = int.Parse(Console.ReadLine());

    if (numero1 > numero2) {
      Console.WriteLine("O numero " + numero1 + " é maior que " + numero2);
    }
    else {
      Console.WriteLine("O numero " + numero2 + " é maior que " + numero1);
    }
    
    Console.ReadLine();
    }
}
