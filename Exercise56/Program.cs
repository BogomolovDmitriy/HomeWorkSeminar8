/*
Задача 56: 
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] myArray = 
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
    {5, 2, 6, 7}
};

MinSummOnRowArray(myArray);

void MinSummOnRowArray(int[,] array)
{
    int[] tempArray = SummOnRowArray(array);
    int minIndex = 0;
    for (int i = 1; i < tempArray.Length; i++)
    {
        int min = tempArray[0];
        if (tempArray[i] < min)
        {
            min = tempArray[i];
            minIndex = i;
        }
    }
    minIndex ++;
    Console.WriteLine($"строка с наименьшей суммой элементов: {minIndex}.");
}

int SummArray(int[,] array, int row)
{
    int summ = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        summ += array[row, i];
    }
    return summ;
}

int[] SummOnRowArray(int[,] array)
{
    int[] summOnRow = new int[array.GetLength(1)];
    for (int i = 0; i < summOnRow.Length; i++)
    {
        summOnRow[i] = SummArray(array, i);
    }
    return summOnRow;
}
