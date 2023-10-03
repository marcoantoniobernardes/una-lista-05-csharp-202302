/******************************************************************************

 Faça um Programa que leia um vetor de 10 números reais e mostre-os na ordem
inversa.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    int[] numero = new int[10];
    Console.WriteLine("Digite 10 numeros:");
    for(int i = 0; i < numero.Length; i++)
        numero[i] = int.Parse(Console.ReadLine());
    Console.WriteLine("Os números do vetor de tras pra frente são:");
    for(int i = 9; i >= 0; i--)
        Console.WriteLine($"O {i+1}º elemento é {numero[i]}");
    Console.ReadLine();
  }
}
