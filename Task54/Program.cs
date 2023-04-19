/* Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

Console.Clear();

int m = Number("Введите количество строк массива >> ");
int n = Number("Введите количество колонок массива >> ");
int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
ChangeArray(matrix);
PrintArray(matrix);

int Number(string message) 
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
     Console.WriteLine();
}

void ChangeArray(int[,] matr)
{
    int number;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(1) - 1; k++)    // Сортируем каждую строку как одномерный массив //
            {
                if (matr[i, k] < matr[i, k + 1])    
                {
                    number = matr[i, k + 1];
                    matr[i, k + 1] = matr[i, k];
                    matr[i, k] = number;
                }
            }
        }
    }
}
    



