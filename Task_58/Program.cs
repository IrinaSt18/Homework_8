/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/ 
int [,] Generate2DMatrix_1_2(int rowLength, int colLength, int start, int finish)
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
int [,] GetProductOfMatrix12(int [,] Matrix1,int [,] Matrix2)
{
        int [,] Matrix3 = new int [Matrix1.GetLength(0),Matrix2.GetLength(1)];
       
        for (int i = 0; i < Matrix3.GetLength(0); i++)
        {   
            for (int j = 0; j < Matrix3.GetLength(1); j++)
            {
             int  product = Matrix3 [i,j];
             for (int h = 0; h < Matrix1.GetLength(1); h++)
             {
                product += Matrix1[i,h]*Matrix2[h,j];
             }
            
            }
        
        }
    return Matrix3;
 
}
int [,] Matrix1 = Generate2DMatrix_1_2 (2, 2, 0, 10);
printArray(Matrix1);
int [,] Matrix2 = Generate2DMatrix_1_2 (2, 2, 0, 10);
printArray(Matrix2);
int [,] Matrix3 = GetProductOfMatrix12( Matrix1, Matrix2);
printArray(Matrix3);