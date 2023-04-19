/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка */

Console.Clear();

int m = Number("Введите количество строк массива >> ");
int n = Number("Введите количество колонок массива\r\nНЕ РАВНОЕ КОЛИЧЕСТВУ СТРОК >> ");
int[,] matrix = new int[m, n];
Rectangle(m, n);
FillArray(matrix);
PrintArray(matrix);
RowsArray(matrix);



int Number(string message) 
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

void Rectangle(int num1, int num2)
{
    if (num1 == num2)
    {
        Console.Write("Программа прервана. Причина:\r\nОшибка ввода. Заданы одинаковые параметры строк и колонок.");
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
    Console.WriteLine("Массив с заданными параметрами:");
    Console.WriteLine();
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

void RowsArray(int[,] matr)
{
    int[] sumRows = new int[matr.GetLength(0)];  // Вводим одномерный массив из значений сумм строк
   
       for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sumRows[i] += matr[i, j];            // Находим элементы введенного ранее одномерного массива
        }
        Console.WriteLine($"Сумма элементов {i + 1} строки массива: {sumRows[i]}");
    }
    Console.WriteLine();

    int indexMinRow = 0;
    
    for (int i = 0; i < sumRows.Length; i++)     // Находим индекс наименьшего элемента одномерного массива
    {
        if (sumRows[indexMinRow] > sumRows[i])
        {
            indexMinRow = i;
        }
    }
    Console.Write($"Номер строки с наименьшей суммой элементов: {indexMinRow + 1}");
}


