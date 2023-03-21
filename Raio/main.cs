using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("Digite o raio do circulo: ");

    double raio = double.Parse(Console.ReadLine());
    double area = Math.PI 8 Math.Pow(raio, 2);

    Console.WriteLine("O resultado é " + area);
  }
}
