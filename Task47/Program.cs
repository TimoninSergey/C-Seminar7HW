/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

double[,] CreateArray ()
{   Console.WriteLine("Введите количество строк");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[m,n];
    return array;
}

double[,] FillArray (double[,] arr)
{
    Random rand = new Random();
    for (int countColumn=0; countColumn < arr.GetLength(0); countColumn++)
    {
        for (int countLine=0; countLine < arr.GetLength(1); countLine++)
        {
            arr[countColumn, countLine] = Math.Round(-10 + rand.NextDouble()*20, 1);  //промежуток и масштаб округления подобраны для удобства проверки
        }
    }
    return arr;
}

void PrintArray (double[,] arr)
{
    for (int countColumn=0; countColumn < arr.GetLength(0); countColumn++)
    {
        for (int countLine=0; countLine < arr.GetLength(1); countLine++)
        {
            Console.Write($"{arr[countColumn, countLine]} ");
        }
        Console.WriteLine();
    }

}

PrintArray(FillArray(CreateArray()));
