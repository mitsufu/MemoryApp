static class Stack
{
    const int size = 1024 * 1024;
    public static int[] buffer;
    public static int pointer;
    static Stack()
    {
        buffer = new int[size];
        pointer = 0;
    }
    public static ref int Read(int offset)
    {
        return ref buffer[pointer + offset];
    }
    public static ref int Push(int value)
    {
        ref int x = ref buffer[pointer++];
        if (pointer >= size)
            throw new Exception("Stack overflow");
        x = value;
        return ref x;
    }
    public static void Pop(int offset = 1)
    {
        pointer = pointer - offset;
    }
    public static IEnumerable<int> EnumerateBuffer()
    {
        for (int i = 0; i < pointer; i++)
        {
            yield return buffer[i];
        }
    }
    public static void Trace()
    {
        Console.WriteLine("STACK: " + string.Join(" ", Stack.EnumerateBuffer()));
    }
}
