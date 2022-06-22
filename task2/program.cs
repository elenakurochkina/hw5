/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.*/

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

int SumOddNumbers(int[] arrA)
{
    int SumOdd = 0;
    for (int i = 1; i < arrA.Length; i += 2)
    {
        SumOdd += arrA[i];

    }
    return SumOdd;
}

int[] arrA = InitArray(5);
System.Console.WriteLine();
int SumOdd = SumOddNumbers(arrA);
System.Console.WriteLine($"sum of elements on odd positon = {SumOdd}");
