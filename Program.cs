// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// double[,] array = new double[new Random().Next(2, 4), new Random().Next(2, 5)];

// void FillArrayWithDouble()
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = new Random().NextDouble() * (9.9 - (-9.9)) - 9.9;
//     }
// }
// }
// void PrintArrayWithRound()
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     Console.Write("#{0}",i);
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         System.Console.Write(" " + Math.Round(array[i, j], 1));
//     }
//     System.Console.WriteLine();
// }
// }
// FillArrayWithDouble();
// PrintArrayWithRound();

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int[,] myArray = new int[new Random().Next(2, 4), new Random().Next(2, 5)];

// void FillMyArray()
// {
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             myArray[i, j] = new Random().Next(1, 6);
//         }
//     }
// }
// void PrintMyArray()
// {
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); j++)
//         {
//             System.Console.Write(" " + myArray[i, j]);
//         }
//         System.Console.WriteLine();
//     }
// }
// int IntroducePozition(string message)
// {
//     System.Console.WriteLine(message);
//     int poz = Convert.ToInt32(Console.ReadLine());
//     return poz;
// }

// void CheckPozition(int i, int j)
// {
//     if ((i > myArray.GetLength(0)) || (j > myArray.GetLength(1)))
//     {
//         System.Console.WriteLine("Такого элемента нет в массиве");
//     }
//     else
//     {
//         System.Console.WriteLine($"Ответ: {myArray[i, j]}");
//     }
// }
// FillMyArray();
// PrintMyArray();
// int row = IntroducePozition("Введите на какой линии находится элемент");
// int collum = IntroducePozition("Введите в каком ряду находится элемент");
// CheckPozition(row, collum);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] myArray = new int[new Random().Next(3, 4), new Random().Next(3, 5)];
void FillMyArray()
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            myArray[i, j] = new Random().Next(1, 9);
        }
    }
}
void PrintMyArray()
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            System.Console.Write(" " + myArray[i, j]);
        }
        System.Console.WriteLine();
    }
}
void SredArif()
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < myArray.GetLength(0); i++)
        {
            sum += myArray[i, j];
        }
        System.Console.WriteLine($"Среднее ариф {j + 1} столбца= {Math.Round(sum / myArray.GetLongLength(0), 1)}");
    }
}
FillMyArray();
PrintMyArray();
SredArif();