//Напишите программу, 
// 1. Которая на вход принимает число (N), 
// 2. А на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int i = 0;
bool not = true;

Console.Write("Введите число: ");

int N = Convert.ToInt32(Console.ReadLine());

while (i <= N)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;
}

if (not)
{
    Console.Write("Нет четных ");
}