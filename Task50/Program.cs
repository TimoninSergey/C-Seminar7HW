/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1,7] -> такого числа в массиве нет
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

void CheckArray (int[,] array)
{
    Console.WriteLine ("Введите номер строки");
    int line = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Введите номер столбца");
    int column = Convert.ToInt32(Console.ReadLine());

    if (line >= array.GetLength(0) || column >= array.GetLength(1)) Console.WriteLine("Элемента с таким номером нет");
    else Console.WriteLine(array[line, column]);
    
}

CheckArray(FillArray(CreateArray()));