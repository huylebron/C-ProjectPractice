namespace C_ConsoleProject.LeetCode;

public class PlusOne
{
    public int[] Plusone ( int[] digits )
    {
        for (var i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] < 9)
            {
                digits[i]++;

                return digits;
            }

            digits[i] = 0;
        }

        var result = new int[digits.Length + 1];
        result[0] = 1;

        return result;
    }

    public static void Main1 ( string[] args )
    {
        var plusOne = new PlusOne ( );
        int[] digits = { 1, 2, 3 };
        var result = plusOne.Plusone ( digits );

        Console.WriteLine ( $"Result: {string.Join ( ", ", result )}" );
        Console.ReadKey ( );
    }
}