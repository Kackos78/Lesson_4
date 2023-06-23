// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string numLenghtStr = Convert.ToString(num);

int numLenght = numLenghtStr.Length;

int DoSumNum(int num, int numLenght)
{
    int sum = 0;
    for (int i = 0; i < numLenght; i++)
    {
        sum = sum + num % 10;
        num = num / 10;
        
    }
    return sum;
}

Console.Write(DoSumNum(num, numLenght));