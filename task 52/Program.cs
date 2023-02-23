// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

var massive = Generate2DArray(3,4);
Print2DArray(massive);
PrintElement(massive);

int[,] Generate2DArray(int m, int n)
{
    int [,] result = new int [m,n];

    for (int i=0; i<result.GetLength(0); i++)
    {
        for (int j=0; j<result.GetLength(1); j++)
        {
            result [i, j] = new Random().Next(1,100);
        }
    }
    return result;
}

void Print2DArray(int [,] arr)
{
    for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
           Console.Write($"{arr[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

void PrintElement(int [,] arr)
{
    int sum;
    int count = arr.GetLength(0);
    for (int j=0; j<arr.GetLength(1); j++)
    {
        sum = 0;
        for (int i=0; i<arr.GetLength(0); i++)
        {
           sum = sum + arr[i,j];
        }
         Console.WriteLine($"Среднее арифметическое каждого столбца: {Math.Round((decimal)sum/count, 1)}"); 
    }
    System.Console.WriteLine();
}