// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
//каждой строки двумерного массива.
using static System.Console;
using System.Linq;
Clear();

int m = 0;
int n = 0;

Write("Введите m:");
int.TryParse(ReadLine(),out m);
Write("Введите n:");
int.TryParse(ReadLine(),out n);
int[,]array = new int[m,n];
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        array[i,j] = new Random().Next(0,10);
    }
}

void PrintArray(int[,]arr)
{
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            Write($"{arr[i,j]}");
        }
        WriteLine();
    }
}
PrintArray(array);
WriteLine();
int[,]MaxToMin(int[,]arr)
{
    for(int i = 0; i < m; i++)
    {
    for(int j = 0; j < n; j++)
    {
        int max = j;
        for(int k = j+1; k<n; k++)
        {
            if(array[i,k]>array[i,max])max = k;
        }
        int temp = array[i,j];
        array[i,j] = array[i,max];
        array[i,max] = temp;
    }    
    }
    return array;
}
MaxToMin(array);
PrintArray(array);
