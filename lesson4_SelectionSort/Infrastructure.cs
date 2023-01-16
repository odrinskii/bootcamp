public static class Infrastructure
{
    public static int[] CreateArray(int size, int min = 0, int max = 10)
    {
        return Enumerable.Range(1, size)
       .Select(item => Random.Shared.Next(min, max))
       .ToArray();
    }

    public static void Print(int[] array)
    {
        Console.WriteLine($"[{String.Join(',', array)}]");
    }
}