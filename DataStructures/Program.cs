
using System.Diagnostics;
using DataStructures.Recursion;

var watch = new Stopwatch();
watch.Start();
Console.WriteLine(Fibonacci.FirstWay(50));
watch.Stop();
Console.WriteLine($"{watch.ElapsedMilliseconds} ms");

watch.Reset();
watch.Start();
Console.WriteLine(Fibonacci.SecondWay(50));
watch.Stop();
Console.WriteLine($"{watch.ElapsedMilliseconds} ms");

watch.Reset();
watch.Start();
Console.WriteLine(Fibonacci.ThirdWay(50));
watch.Stop();
Console.WriteLine($"{watch.ElapsedMilliseconds} ms");