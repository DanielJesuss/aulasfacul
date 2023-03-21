using System;

class Program {
  public static void Main (string[] args) {
    Consolr.WriteLine("Digite um numero: ");
    int num = int.Parse(Console.ReadLine());

    if (num > 0) {
      Console.WriteLine("O numero é positivo");
    } else if (num < 0) {
      Console.WriteLine("O numero é negativo");
    } else {
      Console.WriteLine("O numero é neutro");
    }
    
    Console.Readline();
  } 
}
