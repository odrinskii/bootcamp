﻿// int[] array = new int[5];
// for (int i = 0; i < 5; i++)
// {
//     array[i] = Convert.ToInt32(Console.Readline());
// }
// Console.WriteLine(string.Join(" ", array));

int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];

for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
        {
            matrix[i, j] = (i + 1) * (j + 1);
            matrix[j, i] = (i + 1) * (j + 1);
        }
    }
    Console.WriteLine();
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j]);
        Console.Write(" ");
    }
    Console.WriteLine();
}