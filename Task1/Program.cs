Console.WriteLine("Задача №1:На ввод 2 числа, программа должна определить большее из них число: ");
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (max > number2)
    {
        Console.WriteLine("Правильный ответ: " + max);
    }
else
    {
        Console.WriteLine("Правильный ответ: " + number2);
    }
