﻿Console.WriteLine("Задача №3:На ввод число, программа должна определить четное оно или нет: ");
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number %2 ==0)
    {
        Console.WriteLine($"Число {number} четное!");
    }
else
    {
        Console.WriteLine($"Число {number} не четное!");
    }