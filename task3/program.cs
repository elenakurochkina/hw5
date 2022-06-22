/*Задайте массив вещественных чисел. Найдите разницу между максимальным 
и минимальным элементов массива.*/

int[] InitArray(int len)
{
    int[] arrA = new int[len];
    for (int i = 0; i < len; i++)
    {
        arrA[i] = new Random().Next(2, 9);
        System.Console.Write($"{arrA[i]} | ");
    }
    System.Console.WriteLine();
    return arrA;
}

int DiffMinMax(int[] arrA)
{
    int Diff = 0;
    int Min = 9;
    int Max = 2;

    foreach (int element in arrA)
    {
        if (element > Max) Max = element;
        if (element < Min) Min = element;
        Diff = Max - Min;
    }
    return Diff;
}

int[] arrA = InitArray(3);
System.Console.WriteLine();
int Diff = DiffMinMax(arrA);
System.Console.WriteLine($"difference between MAX & MIN = {Diff}");
