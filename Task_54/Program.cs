/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2    */
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
int [,] getSortedArray(int[,] array, int rowLength, int colLength)
{   int [,]result = new int [rowLength,colLength];
    for (int i = 0; i < array.GetLength(0); i++)
    {  
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {   
            if (array [i,j] > array [i, j + 1])
            {
                int temp = array[i,j];
                array [i,j] = array[i,j + 1];
                array[ i,j + 1] = temp;  
            }
                
             Console.Write ($"{array [i,j]}"); 
            
        }
        Console.WriteLine();
    }
    
    return result;
}
int[,] array = generate2DArray(4, 3, 0, 10);
printArray(array);
int[,] SortedArray = getSortedArray(array,4, 3);
printArray(SortedArray);