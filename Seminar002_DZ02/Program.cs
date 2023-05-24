// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int num = ReadInt("Введите число: ");
int count = num.ToString().Length;
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
if (count < 2)
    {
       //"в числе указан 1 символ"
        Console.WriteLine("в числе нету третьей цифры");
    }
else if (count < 3)
    {
       //"в числе указано 2 символа"
        Console.WriteLine("в числе нету третьей цифры");
    }
else if (count < 4)
    {
       //"в числе указано 3 символа"
        
        Console.WriteLine(num);
        int num1 = num%10;
        Console.WriteLine($"число в 3 символе = {num1}");
    }
else if (count < 5)
    {
       //"в числе указано 4 символа"
        
        Console.WriteLine(num);
        int result1 = num/1000;
        int result2 = num-(result1*1000);
        int num1 = result2/100;
        int num2 = result2%10;
        int num3 = num1*100+num2;
        int num4 = result2-num3;
        int result = num4/10;
        Console.WriteLine($"число в 3 символе = {result}");  
    }
else if (count < 6)
    {
       //"в числе указано 5 символв"
        
        Console.WriteLine(num);
        int result1 = num/10000;
        int result2 = num-(result1*10000);
        int result3 = result2/1000;
        int result4 = result2-(result3*1000);
        int result5 = result4/100;
        Console.WriteLine($"число в 3 символе = {result5}");
    }
else if (count < 7)
    {
       //"в числе указано 6 символв"
        
        Console.WriteLine(num);
        int result1 = num/100000;
        int result2 = num-(result1*100000);
        int result3 = result2/10000;
        int result4 = result2-(result3*10000);
        int result5 = result4/1000;
        Console.WriteLine($"число в 3 символе = {result5}");
    }
else if (count > 6)
    {
       // "в числе указано больше 6 символв"

        Console.WriteLine($"Неверное значение");
    }


// альтернативный вариант решения программа работает до 11 одновременно введенных символов

// int number = ReadInt("Введите число: ");
// int count = number.ToString().Length;
// Console.Write(Array(number, count));
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }
// int Array(int num1, int num2)
// {
// int result = 0;
//     if (num2 < 3)
//     {
//         Console.Write("Числа в 3 символе нет, держи: ");
//     }
//     else
//     {
//         int num3 = 1;
//         for (int num4 = num2; num4 > 3; num4--)
//         {
//             num3 = num3 * 10;
//         }
//         result = (num1 / num3) % 10;
//         Console.Write("Число в 3 символе = ");
//     }
// return result;
// }