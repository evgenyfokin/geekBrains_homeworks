//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void task_10() {
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine((num / 10) % 10);
}
// task_10();



//Задача 13: Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void task_13() {
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 99)
    {   
        while (num > 999)
        {
            num = num / 10;
        }
        num = num - num / 100 * 100;
        Console.WriteLine(num - num / 10 * 10);
    }
    else 
    {
        Console.WriteLine("Третьей цифры не существует");
    }
    }
//Возможно я слишком буквально воспринял фразу "с помощью деления" :)
// task_13();



//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void task_15() {
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num == 1)
    {
        Console.WriteLine("Понедельник, работаем.");
    }
    if (num == 2)
    {
        Console.WriteLine("Вторник, работаем.");
    }
    if (num == 3)
    {
        Console.WriteLine("Среда, работаем.");
    }
    if (num == 4)
    {
        Console.WriteLine("Четверг, работаем.");
    }
    if (num == 5)
    {
        Console.WriteLine("Пятница, работаем.");
    }
    if (num == 6)
    {
        Console.WriteLine("Суббота, отдыхаем!");
    }
    if (num == 6)
    {
        Console.WriteLine("Воскресение, отдыхаем!");
    }
    else
    {
        Console.WriteLine("Неделя состоит всего из 7 дней");
    }
    }
    task_15();