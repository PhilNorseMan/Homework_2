//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);

bool DigitNum(int num)
{
    return 99 < num;
}

if(num < 0) num = num * -1;

if(DigitNum(num))
{
    while(num > 1000)
    {
        num = num / 10;
    }
    int thirdNum = num % 10;
    Console.WriteLine("Третья цифра введенного числа = " + thirdNum);
}
else
{
    Console.WriteLine("ТРЕТЬЕЙ ЦИФРЫ В ЧИСЛЕ НЕТ!!!");
}