/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int ReadInt(string text)   /////задаем тип числа
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
 int[,]GenerateMatrix(int m,int n) /////создаем матрицу
 {
    int[,]matrix= new int[m,n];
    Random rand= new Random();
    for (int i = 0; i < m; i++)
    {
      for (int j = 0; j < n; j++)
      {
        matrix[i,j]=new Random().Next(1,10);
      }  
    }
 }

 void NewMatrix(int[,]matrix)   ////основная матрица
 {
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    double avarage=0;
    for (int j= 0; j < matrix.GetLength(l); i++)
    {
      avarage=avarage/n;
      Console.Write(avarage + " ;");  
    }
    Console.WriteLine();
  }
 }

 void PrintMatrix(int[,]matrix) ////функция печати матрицы
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


int m= ReadInt("Введите количество строк: ");
int n= ReadInt("Введите количество столбцов: ");
var myMatrix=GenerateMatrix(m,n);
NewMatrix(matrix);
PrintMatrix(matrix);