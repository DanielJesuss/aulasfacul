using System;

class Program {
  public static void Main (string[] args) {
    float totalIdades = 90;
    float segundoAmigo = 0;
    float terceiroAmigo = 0;

   for(float primeiroAmigo = 1; primeiroAmigo < totalIdades / 3; primeiroAmigo++)
    {
      segundoAmigo = primeiroAmigo * 2;
      terceiroAmigo = primeiroAmigo * 3;

      if(primeiroAmigo + segundoAmigo + terceiroAmigo == totalIdades) 
      {
       Console.WriteLine("Idade do primeiro amigo é: " + primeiroAmigo);
       Console.WriteLine("Idade do segundo amigo é: " + segundoAmigo);
        Console.WriteLine("Idade do terceiro amigo é: " + terceiroAmigo);
      }
    }
  }
}