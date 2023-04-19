/* Задача 62. Напишите программу, которая заполнит спирально массив . 
Размер вводит юзер
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

Console.Clear();

int m = Number("Введите количество строк массива >> ");
int n = Number("Введите количество колонок массива >> ");
int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);

int Number(string message) 
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}

void FillArray(int[,] matr)
{
   int i = 0, j = 0, cout = 1;
   while (cout <= matr.GetLength(0) * matr.GetLength(1))
    {
        matr[i, j] = cout;

        if ((i <= j + 1) && (i + j < matr.GetLength(1) - 1)) j++;

        else if ((i < j) && (i + j >= matr.GetLength(0) - 1)) i++;

        else if ((i >= j) && (i + j > matr.GetLength(1) - 1)) j--;

        else i--;

        cout++;
    }
}

void PrintArray (int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      if (matr[i,j] < 10)
      Console.Write("0" + matr[i, j] + " ");

      else Console.Write(matr[i, j] + " ");
    }
    Console.WriteLine();
  }
}


