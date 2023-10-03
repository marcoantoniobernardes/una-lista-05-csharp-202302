/******************************************************************************

Faça um Programa que peça as quatro notas de 10 alunos, calcule e armazene num
vetor a média de cada aluno, imprima o número de alunos com média maior ou igual
a 7.0

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    double[,] nota = new double[10, 4];
    double[] vMedia = new double[10];
    double contadorM = 0;
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Digite as notas do aluno {i + 1}: ");
        double media = 0;
        for (int j = 0; j < 4; j++)
        {
        nota[i, j] = double.Parse(Console.ReadLine());
        media += nota[i, j];
        }
        vMedia[i] = media/4;
        if(vMedia[i] >= 7)
            contadorM ++;
        media = 0;
    }
    Console.WriteLine($"{contadorM} alunos pegaram média");
    Console.ReadLine();
  }
}
