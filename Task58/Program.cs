/* Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.Clear();

Console.WriteLine("Важно! Колличество СТОЛБЦОВ первой матрицы\r\nдолжно быть РАВНО количеству СТРОК второй матрицы!");

int m = Number("Введите количество строк первого массива >> ");
int n = Number("Введите количество колонок первого массива >> ");
int k = Number("Введите количество строк вторго массива >> ");
int x = Number("Введите количество колонок второго массива >> ");
int[,] matrix1 = new int[m, n];
int[,] matrix2 = new int[k, x];
Equality(n, k);
FillArray(matrix1);
PrintArray(matrix1);
FillArray(matrix2);
PrintArray(matrix2);
int[,] matrix3 = ProductArrays(matrix1, matrix2);
PrintArray(matrix3);

int Number(string message) 
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

void Equality(int num1, int num2)
{
    if (num1 != num2)
    {
        Console.Write("Программа прервана. Причина:\r\nОшибка ввода. Не выполнено вводное условие.");
        Console.WriteLine();
        num1 = num2 / 0;
    } 
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

int[,] ProductArrays(int[,] matr1, int[,] matr2)
{
    int[,] matr3 = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
        {
            for (int j = 0; j < matr2.GetLength(1); j++)
                {
                    for (int k = 0; k < matr1.GetLength(1); k++)
                    {
                        matr3[i,j] += matr1[i,k] * matr2[k,j];
                    }
                }
        }
            return matr3;
}


