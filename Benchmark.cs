using BenchmarkDotNet.Attributes;

namespace NullCheckTest
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class Benchmark
    {
        private static readonly NullChecks nullChecks = new NullChecks();
        private static readonly object arg1 = new object();
        private static readonly object arg2 = new object();

        [Benchmark]
        public void UsualCheck()
        {
            nullChecks.UsualCheck(arg1, arg2);
        }

        [Benchmark]
        public void UsualIfCheck()
        {
            nullChecks.UsualIfCheck(arg1, arg2);
        }

        [Benchmark]
        public void ExtensionCheck()
        {
            nullChecks.ExtensionCheck(arg1, arg2);
        }

        [Benchmark]
        public void ExtensionWithoutCallerCheck()
        {
            nullChecks.ExtensionWithoutCallerCheck(arg1, arg2);
        }

        [Benchmark]
        public void AttributeCheck()
        {
            nullChecks.AttributeCheck(arg1, arg2);
        }

        
        [Benchmark]
        public void ContractCheck()
        {
            nullChecks.ContractCheck(arg1, arg2);
        }

        [Benchmark]
        public void CodeAnalysisAttribute()
        {
            nullChecks.CodeAnalysisAttribute(arg1, arg2);
        }

        [Benchmark]
        public void ClawsCheck()
        {
            nullChecks.ClawsCheck(arg1, arg2);
        }

        [Benchmark]
        public void DawnGuardCheck()
        {
            nullChecks.DawnGuardCheck(arg1, arg2);
        }

        [Benchmark]
        public void GuardCheck()
        {
            nullChecks.GuardCheck(arg1, arg2);
        }

    }
}