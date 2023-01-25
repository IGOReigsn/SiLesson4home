/*Задача 25: 
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.WriteLine("Введите число А (основание степени) :");
double A=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число B (показатель степени) :");
double B=Convert.ToDouble(Console.ReadLine());
double result=1;
for (int i = 1; i <= B; i++)
{
    result=result*A;
}
Console.WriteLine(A+" в степени "+B+" = "+result);