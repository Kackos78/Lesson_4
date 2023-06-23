// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] arr = new int[8];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(0, 10);
// System.Console.Write($"{arr[i]} ");
}

// for (int i = 0; i < arr.Length - 1; i++)
// {
// System.Console.Write($"{arr[i]}; ");
// }
// System.Console.Write($"{arr[arr.Length - 1]}");

// System.Console.WriteLine();
System.Console.WriteLine($"[{string.Join("; ", arr)}]");