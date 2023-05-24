// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

//небольшое усложнение для себя, программа перезапускается пока не получит верное значение

int day;
do {
    Console.WriteLine("Введите день недели от 1 до 7: ");
    Int32.TryParse(Console.ReadLine(), out day);
}
while(day < 1 || day > 7);
{
    if (day == 1)
        {
            Console.WriteLine("Понедельник: ");
            Console.WriteLine("будний день");
        }
    else if (day == 2)
        {
            Console.WriteLine("Вторник: ");
            Console.WriteLine("будний день");
        }
    else if (day == 3)
        {
            Console.WriteLine("Среда: ");
            Console.WriteLine("будний день"); 
        }
    else if (day == 4)
        {
            Console.WriteLine("Четверг: ");
            Console.WriteLine("будний день");  
        }
    else if (day == 5)
        {
            Console.WriteLine("Пятница: ");
            Console.WriteLine("будний день");
        }   
    else if (day == 6)
        {
            Console.Write("Суббота: ");
            Console.WriteLine("выходной день");
        }
    else if (day == 7)
        {
            Console.Write("Воскресенье: ");
            Console.WriteLine("выходной день");
        }
}