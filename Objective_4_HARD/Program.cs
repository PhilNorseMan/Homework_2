//Задача 11 HARD - необязательная: Напишите программу, которая принимает на вход целое число любой разрядности число и удаляет вторую цифру слева направо этого
//числа. И, конечно же, через строку решать нельзя.

Console.WriteLine("Введите число для удаления второй цифры:");
int num = int.Parse(Console.ReadLine()!);

int count = 10;
int front = 0;
int tail = 0;
int frontCount = 1;
int tailCount = 1;
int remain = num / count;

while(remain > 0)
{
    frontCount = count;
    tailCount = count / 10;
    count = count * 10;
    remain = num / count;
}

front = num / frontCount;
tail = num % tailCount;
if(num < 100)
{
    Console.WriteLine("Число после удаления второй цифры = " + front);
}
else
{
    Console.WriteLine("Число после удаления второй цифры = " + front + tail);
}