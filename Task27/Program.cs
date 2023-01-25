/*Задача 27: 
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("Введите число");
int num=Convert.ToInt32(Console.ReadLine());
int rangeNum=Convert.ToInt32(Math.Truncate((Math.Log10(Math.Abs(num))))+1);//Порядок числа 
// (количество цифр в числе в целой части числа)-сделано так просто ради интереса
int result=0;
for(int i=1;i<=rangeNum;i++)
    {
       result=result+num%10;
       num=num/10;
    }
Console.WriteLine("Сумма цифр в числе ="+ result);