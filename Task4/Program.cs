Console.WriteLine("Задача №4:На ввод число, программа должна вывести все четные числа от 1 до введенного: ");
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int index = 2;
while (index <= number)
    {
        Console.Write(index + " ");
        index = index + 2;
    }