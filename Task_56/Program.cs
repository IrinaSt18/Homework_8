/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей 
суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 
1 строка*/ 
int[,] generate2DArray(int rowLength, int colLength, int start, int finish)
{
    int[,] array = new int[rowLength, colLength];
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            array[i, j] = new Random().Next(start, finish + 1);
        }
    }
    return array;
}
void printInColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(data);
    Console.ResetColor();
}
void printHeadOfArray(int length)
{
    Console.Write("\t");
    for (int i = 0; i < length; i++)
    {
        printInColor(i + "\t", ConsoleColor.DarkGreen);
    }
    Console.WriteLine();
}
void printArray(int[,] array)
{
    printHeadOfArray(array.GetLength(1));
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i + "|\t", ConsoleColor.Cyan);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine("----------------------------");
}
int getMinSum(int [,] array)
{
    int minSum = int.MaxValue;
    int minRow = -1;
    for (int i = 0; i < array.GetLength(0); i++)   
    {
       int rowSum = 0;
        for (int j = 0; j < array.GetLength(1);j++)
        {
            rowSum+=array[i,j];
        }
        if (rowSum < minSum)
        {
            minSum = rowSum;
            minRow = i;
        }
    }
    return minSum;
    return minRow;
}
int[,] array = generate2DArray(8, 3, 0, 10);
printArray(array);
int minRow = getMinSum(array); 
int minSum = getMinSum(array); 
Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow}");
Console.WriteLine($"Суммоа элементов в этой строке: {minSum}");