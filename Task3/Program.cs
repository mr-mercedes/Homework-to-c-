Console.WriteLine("Задача №3:На ввод число, программа должна определить четное оно или нет: ");
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (Convert.ToBoolean(number %= 2)) 
    {
        Console.WriteLine("Число не четное!");
    }
else
    {
        Console.WriteLine("Число четное!");
    }