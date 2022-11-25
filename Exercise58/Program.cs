/*
Задача 58: 
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


int[,] arrayOne = 
{
    {2, 4},
    {3, 2}
};

int[,] arrayTwo = 
{
    {3, 4},
    {3, 3},
    {1, 4}
};

if (arrayOne.GetLength(1) == arrayTwo.GetLength(0))
{
    PrintDoubleArray(ProductOfMatrices(arrayOne, arrayTwo));
}
else
{
    Console.WriteLine("Не возможно перемножить данные матрицы");
    Console.WriteLine("так как число столбцов в первой матрице не равно числу строк во второй!");
}

int[,] ProductOfMatrices(int[,] array1, int[,] array2)
{  
    int[,] arrayResult = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int row = 0; row < arrayResult.GetLength(0); row++)
    {
        for (int column = 0; column < arrayResult.GetLength(1); column++)
        {
            arrayResult[row, column] = ProductOfMatricesOneItem(array1, array2, row, column);
        }
    }
    return arrayResult;
}

int ProductOfMatricesOneItem(int[,] array1, int[,] array2, int row, int column)
{
    int Result = 0;
    for (int n = 0; n < array1.GetLength(1); n++)
    {
        Result += array1[row, n] * array2[n, column]; 
    }
    return Result;
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
