// Напишите программу, которая заполнит спирально массив 4 на 4.
using static System.Console;
using System.Linq;
Clear();
int number = 1;
int[,]array = new int[4,4];
for(int j = 0;j < 4; j++)
{
    array[0,j] = number;
    number++;
}
for(int i = 1;i < 4; i++)
{
   array[i,3] = number; 
   number++;
}
for(int j = 2;j >= 0; j--)
{
  array[3,j] = number; 
  number++;  
}
for(int i = 2;i >= 1; i--)
{
  array[i,0] = number; 
  number++;  
}
for(int j = 1;j <3; j++)
{
  array[1,j] = number; 
  number++;   
}
 array[2,2] = number;
 array[2,1] = number+1; 
for(int i = 0;i <4; i++)
{
   for(int j = 0;j <4; j++)
   {
    Write(array[i,j]+"");
   }
   WriteLine();
} 
