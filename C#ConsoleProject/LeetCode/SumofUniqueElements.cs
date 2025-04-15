namespace C_ConsoleProject.LeetCode;

public class SumofUniqueElements
{
    public int SumofUnique(int[] nums)
    {
        Dictionary<int, int> freq = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (freq.ContainsKey(num))
            {
                freq[num]++;
            }
            else
            {
                freq[num] = 1;
            }
        }

        int sum = 0;

        foreach (var v in freq)
        {
            if (v.Value == 1)
            {
                sum += v.Key;
            }
        }

        return sum;
    }

    public static void Main(string[] args)
    {
        var sumofUnique = new SumofUniqueElements();

        Console.WriteLine($"REsult: {sumofUnique.SumofUnique(new[] { 1, 2, 2, 3 })}");
    }
}