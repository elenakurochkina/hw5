/*Задайте массив заполненный случайными положительными трёхзначными 
числами. Напишите программу, которая покажет количество чётных чисел 
в массиве.*/

int[] InitArray(int len)
{
    int[] arrA = new int[len];
    for (int i = 0; i < len; i++)
    {
        arrA[i] = new Random().Next(100, 999);
        System.Console.Write($"{arrA[i]} | ");
    }
    System.Console.WriteLine();
    return arrA;
}

int EvenNumbers(int[] arrA)
{
    int count = 0;
    foreach(int element in arrA)
    {
        if (element %2 == 0)
        {
            count ++;

        }
    }
    return count;
}

int[] arrA = InitArray(5);
System.Console.WriteLine();
int count = EvenNumbers(arrA);
System.Console.WriteLine($"even's count is {count}");

