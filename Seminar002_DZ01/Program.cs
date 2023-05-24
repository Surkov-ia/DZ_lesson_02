// Задача 10: Напишите программу, которая принимает на
//  вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num/100;
if(num1==0)
{
    Console.Write("Число не является трех значным");  
}
else if(num1>0)
{
int num2 = num%10;
int num3 = num1*100+num2;
int num4 = num-num3;
int result = num4/10;
Console.WriteLine($"ваше число между первым и последним {result}");
}