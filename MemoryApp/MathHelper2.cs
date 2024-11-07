class MathHelper2
{
    public static int Sum() //int a, int b
    {
        var a = Stack.Read(-2);
        var b = Stack.Read(-1);

        Stack.Pop();
        Stack.Pop();

        return a + b;
    }
    public static int Square() //int x
    {
        var x = Stack.Read(-1);
        return x * x;
    }
    public static int Factorial() //int x, local int tmp
    {
        ref int x = ref Stack.Read(-1);

        var result = Stack.Push(1);
        while (x > 0)
        {
            result = result * x;
            x--;
        }

        return result; 
    }
    public static int FactorialRec() //int f
    {
        Stack.Trace();
        var f = Stack.Read(-1);
        if (f == 0)
        {
            f = 1;
        }
        else
        {
            Stack.Push(f - 1);
            f = f * FactorialRec();
        }
        Stack.Pop();
        Stack.Trace();
        return f;
    }
}
