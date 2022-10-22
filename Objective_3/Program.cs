//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

void DayCount(int dayNum)
{
    if(dayNum > 7) 
    {
        Console.WriteLine("НЕТ ТАКОГО ДНЯ НЕДЕЛИ!=)");
    }
    else
    {
        if(dayNum > 5)
        {
            Console.WriteLine("Выходной день");
        }
        else
        {
            Console.WriteLine("Рабочий день");
        }
    }
}

Console.WriteLine("Введите номер дня недели:");
int dayNum = int.Parse(Console.ReadLine()!);

DayCount(dayNum);