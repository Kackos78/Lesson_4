// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Введите число: ");
//int num = Convert.ToInt32(Console.ReadLine());
string numInStr = Console.ReadLine();
int ArrLenght = numInStr.Length;
int DoSumNum(string numInStr)
{
    int ArrLenght = numInStr.Length;
    string[] arrNumStr = { };
    for (int i = 0; i < ArrLenght; i++)
    {
        arrNumStr[i] = numInStr[i];
        
    }
    return 
}
