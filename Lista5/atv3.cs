/******************************************************************************

Faça um Programa que leia 4 notas, mostre as notas e a média na tela.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    int[] nota = new int[4];
    float media = 0;
    Console.WriteLine("Digite 4 notas:");
    for(int i = 0; i < nota.Length; i++)
        nota[i] = int.Parse(Console.ReadLine());
    Console.WriteLine("Os notas são:");
    foreach (int nts in nota)
    {
        Console.WriteLine(nts);
        media = nts+media;
    }
    Console.WriteLine("Á media é: " + media/4);
    Console.ReadLine();
  }
}
