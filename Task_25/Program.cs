// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

System.Console.WriteLine("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Введите степень: ");
double pow = Convert.ToDouble(Console.ReadLine());

double MakeFan(double num, double pow)
{
    return Math.Pow(num, pow);
}

System.Console.WriteLine($"Число {num} в степени {pow} = {MakeFan(num, pow)}");
