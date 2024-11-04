using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Diagnostics;
using System.Runtime.InteropServices;

var test = new ListTests();
//test.Capacity();
test.LinkedList();

return;

Stack.Push(5);
Stack.Push(7);
var i = MathHelper2.Sum(); // FactorialRec();
Console.WriteLine(i);

