//Задача 29: Напишите программу, которая 
//задаёт массив из 8 элементов и выводит их на экран.

int[] FillArray(int[] filling)
{
for (int i = 0; i < filling.Length; i++)
{
filling[i] = new Random().Next(0, 100);

}
return filling;
}

void printArray(int[] writing)
{
for (int i = 0; i < writing.Length; i++)
{
Console.WriteLine(writing[i]);
}
}

int[] myArray = new int[8];

FillArray(myArray);
printArray(myArray);