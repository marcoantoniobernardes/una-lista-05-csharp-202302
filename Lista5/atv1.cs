/******************************************************************************

Faça um Programa que leia um vetor de 5 números inteiros e mostre-os.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    int[] numero = new int[5];
    Console.WriteLine("Digite 5 numeros:");
    for(int i = 0; i < numero.Length; i++)
        numero[i] = int.Parse(Console.ReadLine());
    Console.WriteLine("Os números do vetor são:");
    foreach (int num in numero)
        Console.WriteLine(num);
    Console.ReadLine();
  }
}
