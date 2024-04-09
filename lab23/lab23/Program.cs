internal class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 3, 2, 8, 5 };
        int min1 = int.MaxValue;
        int min2 = int.MaxValue;
        int max1 = int.MinValue;
        int max2 = int.MinValue;
        int sumMin = 0;
        int sumMax = 0;
        int sumAll = sumMin + sumMax;
     
        foreach (int num in arr)
        {
            if (num < min1)

            {
                min2 = min1;
                min1 = num;
            }
            else if (num < min2)
            {
                min2 = num;
            }
            if (num > max1)
            {
                max2 = max1;
                max1 = num;
            }
            else if (num > max2)
            {
                max2 = num;
            }
        }
            sumMin = min1 + min2;
            sumMax = max1 + max2;
        int vurmaMin = min1 * min2;
        int vurmaMax = max1 * max2;
        int bolMin = min1 / min2;
        int bolMax = max1 / max2;
        int minFerq = min2 - min1;
        int maxFerq = max1 - max2;
        Console.WriteLine("minimum cemi:" + sumMin);
            Console.WriteLine("maksimum cemi:" + sumMax);
        Console.WriteLine("minimum hasili:" + vurmaMin);
        Console.WriteLine("maksimum hasili:" + vurmaMax);
        Console.WriteLine("minimum bolen:" + bolMin);
        Console.WriteLine("maksimum bolen:" + bolMax);
        Console.WriteLine("minimum ferq:" + minFerq);
        Console.WriteLine("maksimum ferq:" + maxFerq);
    }
}
