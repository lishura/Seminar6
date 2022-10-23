// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

string str = PrintStringAndGetArray("Введите числа через запятую");

string[] input = str.Split(",", StringSplitOptions.RemoveEmptyEntries);
int[] array = new int[input.Length];

for (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(input[i]);
}

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}

Console.WriteLine("Количество чисел больше нуля " + count);

string PrintStringAndGetArray(string message)
{
    Console.WriteLine(message);
    string array = Console.ReadLine();
    return array;
}