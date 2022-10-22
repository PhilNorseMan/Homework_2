﻿//В институте биоинформатики по офису передвигается робот. Недавно студенты из группы программистов написали для него программу, по которой робот, когда заходит в комнату, считает количество программистов в ней и произносит его вслух: "n программистов".
//Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание слова.
//Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное), выводящее это число в консоль вместе с правильным образом изменённым словом "программист", для того, чтобы робот мог нормально общаться с людьми, например: 1 программист, 2 программиста, 5 программистов.
//В комнате может быть очень много программистов. Проверьте, что ваша программа правильно обработает все случаи, как минимум до 1000 человек.

Console.WriteLine("Ввести число программистов:");
int number = int.Parse(Console.ReadLine()!);

int remain = number % 10;

if(number > 4 && number < 20)
{
    Console.WriteLine("Ответ робота: В комнате находится " + number + " программистов");
}
else
{
    if(remain == 1)
    {
        Console.WriteLine("Ответ робота: В комнате находится " + number + " программист");
    }
    else
    {
        if(remain > 1 && remain < 5)
        {
            Console.WriteLine("Ответ робота: В комнате находится " + number + " программиста");
        }
        else
        {
            if(remain > 4 && remain < 10)
            {
                Console.WriteLine("Ответ робота: В комнате находится " + number + " программистов");
            }
            else
            {
                Console.WriteLine("Ответ робота: В комнате находится " + number + " программистов");
            }
        }
    }
}