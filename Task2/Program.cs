Console.WriteLine("Задача №1:На ввод 3 числа, программа должна определить большее из них число: ");
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (max > number2)
    {
        if (max > number3)
            {
                Console.WriteLine("Наибольшее число из введенных: " + max);
            }
        else
            {
                Console.WriteLine("Наибольшее число из введенных: " + number3);

            }

            

    }
else
    {
        number2 = max;
        if (max > number3)
            {
                Console.WriteLine("Наибольшее число из введенных: " + max);
            }
        else
            {
                Console.WriteLine("Наибольшее число из введенных: " + number3);
            }
    }

