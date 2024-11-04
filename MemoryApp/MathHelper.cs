class MathHelper
{
    public static int Compute(int x)
    {
        var f = Factorial(x);
        return Sum(f, 10);
    }
    public static int Sum(int a, int b)
    {
        return a + b;
    }
    public static int Factorial(int x)
    {
        int result = 1;
        while (x > 0)
        {
            result = result * x;
            x--;
        }
        return result;
    }
    public static int FactorialRec(int f)
    {
        if (f == 0)
            return 1;
        else
            return f * FactorialRec(f - 1);
    }
}
