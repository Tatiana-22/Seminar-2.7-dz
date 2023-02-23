// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//17 -> такого числа в массиве нет

var massive = Generate2DArray(3,4);
Print2DArray(massive);
PrintElement(massive, 3,2);

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
    Console.WriteLine("Массив");
    for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        {
            Console.WriteLine($"Элемент[{i},{j}] = {arr[i, j]}");

        }
    }
}

void PrintElement(int [,] arr, int r, int s)
{
    if(r> arr.GetLength(0) || s>arr.GetLength(1))
    {
        Console.Write("такого элемента нет");
    } 
    else
    {
        Console.Write($"Найденный элемент массива: {arr[r-1, s-1]}");
    }
    
    System.Console.WriteLine();
}