/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Console.WriteLine("Введите номер строки: ");
int n= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int m= Convert.ToInt32(Console.ReadLine());
int[,]numbers= new int[10,10];

 void FillArray( int[]numbers)
 {
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
       for (int j = 0; j < numbers.GetLength(1); j++)
       {
        for (n>numbers.GetLength(0)&& m>numbers.GetLength(1))
        {
          Console.WriteLine("Такого элемента нет");  
        }
        Console.WriteLine($"значение элемента {n} строки и {m} столбца равно{numbers[n-1,m-1]}");
       } 
    }
 }

void GenerateArray(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          array[i,j]=new Random().Next(10,10);  
        }
        Console.WriteLine(" ");
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
         Console.Write(matrix[i,j]+ "t");   
        }
        System.Console.WriteLine();
    }
 }
 