/*Задача 29: 
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int [] ar =new int[8];
Random rnd = new Random();
for (int i=0;i<ar.Length;i++)
    {
        ar[i] = rnd.Next(0,100);
    } 
System.Console.WriteLine("[ "+String.Join(", ",ar)+"]");