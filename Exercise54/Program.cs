/*
Задача 54: 
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] myArray = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

Console.WriteLine("Массив до изменений: ");
PrintDoubleArray(myArray);

Console.WriteLine("Массив после изменений: ");
PrintDoubleArray(SortingNumbersInArrayString(myArray));

int[,] SortingNumbersInArrayString(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        GetSortedOnRow(array, i + 1);
    }
    return array;
}

void PrintDoubleArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] GetSortedOnRow(int[,] array, int row)
{
    row = row - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int maxIndex = i;
        for (int j = i; j < array.GetLength(1); j++)
        {
            if(array[row, j] > array[row, maxIndex])
            {
                int temp = array[row, j];
                array[row, j] = array[row, maxIndex];
                array[row, maxIndex] = temp;
            }
        }
    }
    return array;
}