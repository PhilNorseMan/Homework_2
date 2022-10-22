//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введите трехзначное число");
int num = int.Parse(Console.ReadLine()!);

bool ThreeDigitNum(int num)
{
    return 99 < num && num < 1000;
}

if(ThreeDigitNum(num))
{
    int secondNum = num / 10 % 10;
    Console.WriteLine("Вторая цифра введенного числа = " + secondNum);
}
else
{
    Console.WriteLine("ВВЕДЕНО НЕ ТРЕХЗНАЧНОЕ ЧИСЛО!!!");
}
