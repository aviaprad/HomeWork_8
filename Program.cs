// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
/*

int [,] Create2dRandomArray(int rows,int cols, int min, int max)
{
    int[,] array  = new int [rows, cols];
    for (int i=0;i<rows;i++)
    {
        for (int j=0; j < cols;j++)
        {
         array[i,j]=new Random().Next(min,max+1);
        }
    }
    return array;
}



void Show2dArray(int [,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}

int [,] SortedArray(int [,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
  return array;
}


Console.WriteLine("Input rows number: ");
int rows= Convert.ToInt32(Console.ReadLine());
Console.Write("Input cols number");
int cols=Convert.ToInt32(Console.ReadLine());
Console.Write("Input min number");
int min=Convert.ToInt32(Console.ReadLine());
Console.Write("Input max number");
int max=Convert.ToInt32(Console.ReadLine());

int [,] array = Create2dRandomArray(rows,cols,min,max);
Show2dArray(array);
Console.WriteLine();
int [,] changedArray = SortedArray(array);
Show2dArray(changedArray);

*/


/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7


Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
/*
int [,] Create2dRandomArray(int n, int min, int max)
{
    int[,] array  = new int [n, n];
    for (int i=0;i<n;i++)
    {
        for (int j=0; j < n;j++)
        {
         array[i,j]=new Random().Next(min,max+1);
        }
    }
    return array;
}

void Show2dArray(int [,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}


int SumRowElements(int[,] array, int i) // Метод нахождения суммы элементов стороки i
{
  int sumRow = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumRow += array[i,j];
  }
  return sumRow;
}


Console.WriteLine("Input rows = cols number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min number");
int min=Convert.ToInt32(Console.ReadLine());
Console.Write("Input max number");
int max=Convert.ToInt32(Console.ReadLine());

int [,] array = Create2dRandomArray(n,min,max);
Show2dArray(array);
Console.WriteLine();

int minSumRow = 0;      
int sumRow = SumRowElements(array, 0); 
for (int i = 1; i < array.GetLength(0); i++)
    {
    int temp = SumRowElements(array, i);
     if (sumRow > temp)
        {
        sumRow = temp;
        minSumRow = i;
        }
    }


Console.WriteLine($"{minSumRow+1} - row with mimum sum of elements ({sumRow}) ");

*/

/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

*/

/*

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secondMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

void CreateArray(int[,] array, int min, int max)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(min,max+1);;
    }
  }
}

void ShowArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

Console.WriteLine("Input number of rows  matrix: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input numbers of columns  matrix ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("Input min number");
int min=Convert.ToInt32(Console.ReadLine());
Console.Write("Input max number");
int max=Convert.ToInt32(Console.ReadLine());

int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix, min, max);
Console.WriteLine($"First matrix:");
ShowArray(firstMartrix);

int[,] secondMartrix = new int[m, n];
CreateArray(secondMartrix, min, max);
Console.WriteLine($"Second matrix:");
ShowArray(secondMartrix);

int[,] resultMatrix = new int[m,n];

MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine($"Matrix1 * Matrix2 = : ");
ShowArray(resultMatrix);

*/

/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)1
*/
/*
void ShowArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"{array3D[i,j,k]} ({i},{j},{k}); ");
      }
      Console.WriteLine();
    }
  }
}

void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        array3D[i, j, k] = temp[count];
        count++;
      }
    }
  }
}

int i = 2;
int j = 2;
int k = 2;

int[,,] array3D = new int[i, j, k];
CreateArray(array3D);
ShowArray(array3D);
*/
/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/


int [,] CreateSpiralArray()
{
int n = 4;
int[,] array = new int[n, n];

int value = 1;
int i = 0;
int j = 0;

while (value <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = value;
        value++;
    if (i <= j + 1 && i + j < array.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= array.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > array.GetLength(1) - 1)
        j--;
    else
        i--;
    }
return array;
}

void ShowArray (int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1); j++)
        {
            if (array[i,j]<10)
            Console.Write(array[i,j]+"  ");
            else Console.Write(array[i,j]+" ");
        }
    Console.WriteLine();
    }
}

int [,] array = CreateSpiralArray();
ShowArray(array);

