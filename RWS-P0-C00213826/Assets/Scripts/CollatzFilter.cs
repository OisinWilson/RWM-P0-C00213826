public class CollatzFilter
{
    public static int collatz(int x)
    {
        return (x % 2 == 0) ? (x / 2) : (3 * x + 1);
    }

    public static int[] collatz(int[] xs)
    {
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
            result[i] = collatz(xs[i]);
        return result;
    }
}