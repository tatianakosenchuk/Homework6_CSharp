/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/
int[] GetArrayFromConsole(int length)
{
    Console.WriteLine($"Введите {length} элементов массива");
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine() ?? "");
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

int GetQtyOfPositiveNumbers(int[] arrayOfNums)
{
    int quantity = 0;
for (int i = 0; i < arrayOfNums.Length; i++)
{
    if (arrayOfNums[i] > 0) quantity++;
}
return quantity;
}

int [] arrayFromConsole = GetArrayFromConsole(5);
Console.WriteLine();
int qty = GetQtyOfPositiveNumbers(arrayFromConsole);
PrintArray(arrayFromConsole);
Console.Write($" -> {qty}");
Console.WriteLine();
