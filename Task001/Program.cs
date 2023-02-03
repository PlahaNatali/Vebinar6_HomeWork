// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2

Console.Write("Сколько чисел хотели бы проверить: ");
int num = Convert.ToInt32(Console.ReadLine());
countNumber(arr(num));

int[] arr(int a)
{
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void countNumber(int[] a)
{
    int[] arr = a;
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            count++;
    }
    Console.WriteLine($"Вы ввели {count} положительных числа");
}