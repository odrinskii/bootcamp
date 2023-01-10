// Задан массив, нужно найти макс комбинацию трех элементов
using System.Diagnostics;

int size = 1_000_000;
int m = 30000;
int[] array = Enumerable.Range(1, size)
                        .Select(item => Random.Shared.Next(10))
                        .ToArray();
//Console.WriteLine($"[{string.Join(", ", array)}]");

Stopwatch sw = new();
sw.Start();

int max = 0;

// for (int i = 0; i < array.Length - m; i++) // много ресурсов ест такой алгоритм
// {
//     int t = 0;
//     for (int j = i; j < i + m; j++)
//     {
//         t += array[j];
//         if (t > max) max = t;
//     }
// }

for (int j = 0; j < m; j++) max += array[j]; // этот алгоритм должен быть быстрее.
int t = max;
for (int i = 1; i < array.Length - m; i++)
{
    t = t - array[i - 1] + array[i + (m - 1)];
    if (t > max) max = t;
}

sw.Stop();
Console.WriteLine($"time = {sw.ElapsedMilliseconds}");
Console.WriteLine(max);