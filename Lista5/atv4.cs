/******************************************************************************

Faça um Programa que leia um vetor de 10 caracteres, e diga quantas consoantes
foram lidas. Imprima as consoantes.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    char[] alfa = new char[10];
    int contadorC = 0;
    Console.WriteLine("Digite 10 caracteres:");
    for(int i = 0; i < alfa.Length; i++)
        alfa[i] = char.Parse(Console.ReadLine());
    Console.WriteLine("Os caracteres consoantes são:");
    for (int i = 0; i < alfa.Length; i++)
    {
        if(!Vogal(alfa[i]) && char.IsLetter(alfa[i]))
            contadorC++;
    }
    Console.WriteLine($"O número de consoantes é:  {contadorC}");
    Console.ReadLine();
  }
  static bool Vogal(char c)
    {
        char[] vogais = { 'a', 'e', 'i', 'o', 'u' };
        return Array.Exists(vogais, vogal => vogal == c);
    }
}
