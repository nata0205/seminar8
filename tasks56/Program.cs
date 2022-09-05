// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
//строку с наименьшей суммой элементов.
using static System.Console;
using System.Linq;
Clear();
Write("Введите количество строк: ");
int m = int.Parse(ReadLine());
Write("Введите количество столбцов: ");
int n = int.Parse(ReadLine());
int[,]array = new int[m,n];
for(int i = 0; i < m; i++)
{
 for(int j = 0; j < n; j++)
 {
    array[i,j] = new Random().Next(10);
 }   
}

void MinSumLine(int[,]arr)
{
    int minSum = 0;
    int minLine = 0;
    for(int i = 0; i <m; i++)
    {
        int sum = 0;
        for(int j = 0; j <n; j++)
        {
            sum = sum+arr[i,j];
        }
        if(i == 0)minSum = sum;
        else if(sum < minSum)
        {
            minLine = i;
            minSum = sum;
        }
    }
    WriteLine($"Наименьшая сумма элементов в строке {minLine}");
}

void PrintArray(int[,]arr)
{
 for(int i = 0; i <m; i++)
 {
 for(int j = 0; j < n; j++)
 {
    Write($"{arr[i,j]}");
 }
 WriteLine();
 }   
}
PrintArray(array);
MinSumLine(array);