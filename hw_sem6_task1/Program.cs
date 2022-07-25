/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/
/*
Console.Write("Введите количество элементов массива: ");
int elementsCount = int.Parse(Console.ReadLine());
int [] arr = new int [elementsCount];

int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine($"Введите элемент массива под индексом {i}: ");
    arr[i] = int.Parse(Console.ReadLine());
    if (arr[i] > 0)
        count++;
}
 
Console.WriteLine($"Кол-во элементов > 0: {count}");*/

int[] GetArray(int dimension)
{
    Console.Write("Введите количество элементов массива: ");
    dimension = int.Parse(Console.ReadLine());
    int[] arr = new int[dimension];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void PositiveCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            count++;
    }
    Console.WriteLine($"Кол-во элементов > 0 в заданном массиве = {count}");
}


int[] array = GetArray(1);
PrintArray(array);
Console.WriteLine(string.Empty);
PositiveCount(array);