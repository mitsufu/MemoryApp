class MathHelper2
{
    public static int Sum() //int a, int b
    {
        var a = Stack.Read(-2);
        var b = Stack.Read(-1);

        Stack.Push(b);
        b = FactorialRec();

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
        ref int i = ref Stack.buffer[1];
        ref int tmp = ref Stack.buffer[1];

        Stack.Push(1);
        while (Stack.Read(0) > 0)
        {
            Stack.Push(Stack.Read(1) * Stack.Read(0));
            Stack.Push(Stack.Read(0) - 1);
        }
        return Stack.Read(1);
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
