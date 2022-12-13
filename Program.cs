using System;
using BenchmarkDotNet.Running;

namespace NullCheckTest
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Benchmark>();
        }
    }
}
