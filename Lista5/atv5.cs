/******************************************************************************

Faça um Programa que leia 20 números inteiros e armazene-os num vetor.
Armazene os números pares no vetor PAR e os números IMPARES no vetor ímpar.
Imprima os três vetores

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    int[] numero = new int[20];
    int par = 0, impar =0, contadorI = 0, contadorP = 0;
    Console.WriteLine("Digite 20 numeros:");
    for(int i = 0; i < numero.Length; i++)
    {
        numero[i] = int.Parse(Console.ReadLine());
        if(numero[i]%2 == 0)
            par++;
        else
            impar ++;
    }
    int[] vPar = new int[par];
    int[] vImpar = new int [impar];
    for(int i = 0; i < numero.Length; i++)
    {
        if(numero[i]%2 == 0)
        {
            contadorP++;
            vPar[contadorP-1] = numero[i]; 
        }
        else
        {
            contadorI++;
            vImpar[contadorI-1] = numero[i];
        }
    }
    Console.WriteLine("Vetor: ");
    for(int i = 0; i < numero.Length; i++)
        Console.Write(numero[i]+ " ");
    Console.WriteLine($"\nVetor Impar({contadorI}): ");
    for(int i = 0; i < vImpar.Length; i++)
        Console.Write(vImpar[i]+ " ");
    Console.WriteLine($"\nVetor Par({contadorP}): ");
    for(int i = 0; i < vPar.Length; i++)
        Console.Write(vPar[i]+ " ");
    Console.ReadLine();
    
  }
}
