﻿// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Amn = m + n.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] CreateArray(int rows, int colums)
{
 int[,] array = new int[rows, colums];
 // Random rnd = new Random();
 for (int i = 0; i < array.GetLength(0); i++)
 {
  for (int j = 0; j < array.GetLength(1); j++)
  {
   array[i, j] = i + j;
  }
 }
 return array;
}

void PrintaMatrix(int[,] matrix)
{
 for (int i = 0; i < matrix.GetLength(0); i++)
 {
  Console.Write("[");
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
   if (j < matrix.GetLength(1) - 1) System.Console.Write($"{matrix[i, j],3} |"); else System.Console.Write($"{matrix[i, j],3} ]");
  }
  System.Console.WriteLine();
 }
}

int[,] arr = CreateArray(3, 4);
PrintaMatrix(arr);