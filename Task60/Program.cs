/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

Console.Clear();

int rows = Number("Введите количество строк массива >> ");
int columns = Number("Введите количество колонок массива >> ");
int depth = Number("Введите количество глубину массива массива >> ");
int[,,] matrix = new int[rows, columns, depth];

FillArray(matrix);
PrintResult(matrix);

int Number(string message) 
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

void FillArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = new Random().Next(10) + new Random().Next(40) + new Random().Next(50);
            }
        }
    }
}

void PrintResult(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]}({i},{j},{k}) ");
            }
             Console.WriteLine();
        }
    }
}
