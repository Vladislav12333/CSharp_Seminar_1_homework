// Напишите программу, которая на вход принимает два числа и выдаёт, какое число больше, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine("{0} больше, чем {1}", number1, number2);
}
else if (number1 < number2)
{
    Console.WriteLine("{0} меньше, чем {1}", number1, number2);
}
else
{
    Console.WriteLine("{0} равно {1}", number1, number2);
}

Console.ReadLine();