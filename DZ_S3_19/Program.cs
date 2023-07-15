

Console.Clear();
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int revers = 0;
int num = 0;
int rest = 0;
if (number > 9999 && number < 100000)
{
    for (num = number; number != 0; number = number / 10)
    {
        rest = number % 10;
        revers = revers * 10 + rest;
    }
}
if (num == revers)
    Console.Write($"{num} является палиндромом");
else if (num != revers)
    Console.Write($"{num} не является палиндромом");
