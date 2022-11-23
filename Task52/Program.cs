/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] CreateArray ()
{   Console.WriteLine("Введите количество строк");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[m,n];
    return array;
}

int[,] FillArray (int[,] arr)
{
    for (int countColumn=0; countColumn < arr.GetLength(0); countColumn++)
    {
        for (int countLine=0; countLine < arr.GetLength(1); countLine++)
        {
            Console.WriteLine($"Введите элемент массива номер {countLine}, {countColumn}");
            arr[countColumn, countLine] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return arr;
}

void PrintMeanColumn (int[,] array)
{
    for (int columnCount = 0; columnCount < array.GetLength(1); columnCount++)
    {
        double columnSum = 0;
        for (int lineCount = 0; lineCount < array.GetLength(0); lineCount++)
        {
            columnSum = columnSum + array[lineCount, columnCount];

        }
        double columnMean = columnSum / array.GetLength(0);
        Console.WriteLine($"Среднее арифметическое столбца номер {columnCount} равно {columnMean}");
    }
    
}

PrintMeanColumn(FillArray(CreateArray()));