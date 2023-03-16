//Напишите программу, которая   
// 1. На вход принимает два числа и выдаёт, 
// 2. какое число большее,
// 3. а какое меньшее.

// a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int numberA = 0;
int numberB = 1;
{
double a, b;

        Console.Write("Введите первое число: ");
        a = Double.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        b = Double.Parse(Console.ReadLine());
        if (a > b)
            Console.WriteLine("{0} - максимальное значение, {1} - минимальное значение", a, b);
        else Console.WriteLine("{0} - максимальное значение, {1} - минимальное значение", b, a);
}