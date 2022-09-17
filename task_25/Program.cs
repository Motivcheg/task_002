//Задача 25: Напишите цикл, который принимает 
//на вход два числа (A и B) и возводит число A в натуральную степень B.

int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());
int result = 0;
for (int i = 0; i < numberB; i++)
{
    result = numberA * numberA;
    for (int j = 0; j < i; j++)
    {
        result = result * numberA;
        
    }
}
Console.WriteLine(result);   
