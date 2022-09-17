//Задача 27: Напишите программу,
//которая принимает на вход число и выдаёт сумму цифр в числе.

int number = int.Parse(Console.ReadLine());
int sum(int num)
{
    int sum = 0;
    while (num != 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

Console.WriteLine(sum(number));
