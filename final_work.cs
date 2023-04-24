// common
int Input(string text) {
    Console.Write(text);
    return int.Parse(Console.ReadLine());
}

// first
Console.WriteLine("Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");
int n = Input("Введите положительное число: ");
int m = 1;
if (n < 1) {
    Console.WriteLine("Ввели не положительное число");
}
int NaturalNumber(int n, int m) {
    if (n == m) return n;
    else Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}
Console.WriteLine(NaturalNumber(n, m));

// second
Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
m = Input("Введите M: ");
n = Input("Введите N: ");
Console.WriteLine($"Сумма элементов от {m} до {n} = {NaturalSumm(m, n)}");

int NaturalSumm(int m, int n) {
    if (m == n) return m;
    int sum = 0;
    int max = Math.Max(m, n);
    int min = Math.Min(m, n);
    for (; min <= max; min++) {
        sum = sum + min;
    }
    return sum;
}

// third
Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
int AkkermanFunc(int m, int n) {
    if (m == 0) {
        return n + 1;
    }

    if (m > 0 && n == 0) {
        return AkkermanFunc(m - 1, 1);
    }

    return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}
n = Input("Введите M: ");
m = Input("Введите N: ");
Console.Write($"{AkkermanFunc(n, m)}");