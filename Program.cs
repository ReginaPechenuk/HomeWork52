/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


int getDataFronUser(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int[,] getArray(int colLength, int rowLength, int start, int Finish)
{
    int[,] array = new int[colLength, rowLength];
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i, j] = new Random().Next(start, Finish + 1);
        }
    }
    return array;
}
void printArray(int[,] array)
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
double[] AritmeticMean(int[,] array, int row)
{
    double[] arr = new double[row];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        
        double average = 0;
        double sumAverege = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumAverege = sumAverege + array[i, j];
            average = sumAverege / (array.GetLength(0));
            arr[j] = average;
        }

    }
    return arr;
}
void PrintArray2(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int n = getDataFronUser("Введите количествуо строк = ");
int m = getDataFronUser("Введите количествуо столбцов = ");
int[,] array = getArray(n, m, 0, 10);
Console.WriteLine();
printArray(array);
Console.WriteLine();
double[] averageU = AritmeticMean(array, m);
Console.WriteLine($"Среднее арифметическое по столбцам:");
PrintArray2(averageU);

