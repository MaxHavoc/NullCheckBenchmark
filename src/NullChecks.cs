using System;
using System.Runtime.CompilerServices;
using GuardNet;
using NullCheckTest.src;

namespace NullCheckTest
{
    public class NullChecks
    {
        [MethodImpl(MethodImplOptions.NoInlining)] 
        public bool UsualCheck(object arg1, object arg2)
        {
            _ = arg1 ?? throw new ArgumentNullException(nameof(arg1));
            _ = arg2 ?? throw new ArgumentNullException(nameof(arg2));

            return arg1.Equals(arg2);
        }

        [MethodImpl(MethodImplOptions.NoInlining)] 
        public bool ExtensionCheck(object arg1, object arg2)
        {
            arg1.NotNull();
            arg2.NotNull();

            return arg1.Equals(arg2);
        }

        [MethodImpl(MethodImplOptions.NoInlining)] 
        public bool ExtensionWithoutCallerCheck(object arg1, object arg2)
        {
            arg1.NotNullWithoutCaller();
            arg2.NotNullWithoutCaller();

            return arg1.Equals(arg2);
        }

        [NotNull]
        [MethodImpl(MethodImplOptions.NoInlining)] 
        public bool AttributeCheck(object arg1, object arg2)
        {
            return arg1.Equals(arg2);
        }

        [MethodImpl(MethodImplOptions.NoInlining)] 
        public bool GuardCheck(object arg1, object arg2)
        {
            Guard.NotNull(arg1, nameof(arg1));
            Guard.NotNull(arg2, nameof(arg2));

            return arg1.Equals(arg2);
        }
    }
}