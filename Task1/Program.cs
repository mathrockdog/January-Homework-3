// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int[] ConvertStringsToNumbers(string[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = Convert.ToInt32(array[i]);
    }
    return newArray;
}

int GetPositiveNumbersAmount(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            counter += 1;
        }
    }
    return counter;
}

Console.WriteLine("Введите числа:");
string numbers = Console.ReadLine()!;
string[] separatingStrings = { ", ", ",", " " };
string[] array = numbers.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
int[] stringsToNumbers = ConvertStringsToNumbers(array);
int positiveNumbersAmount = GetPositiveNumbersAmount(stringsToNumbers);
Console.Write("Количество чисел больше нуля равно: " + positiveNumbersAmount);