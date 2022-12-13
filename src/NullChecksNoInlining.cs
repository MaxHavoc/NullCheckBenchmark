using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using GuardClaws;
using GuardNet;
using NullCheckTest.src;

namespace NullCheckTest
{
    public class NullChecksNoInlining
    {
        [MethodImpl(MethodImplOptions.NoInlining)] 
        public bool UsualCheck(object arg1, object arg2)
        {
            _ = arg1 ?? throw new ArgumentNullException(nameof(arg1));
            _ = arg2 ?? throw new ArgumentNullException(nameof(arg2));

            return arg1.Equals(arg2);
        }

        [MethodImpl(MethodImplOptions.NoInlining)] 
        public bool UsualIfCheck(object arg1, object arg2)
        {
            if(arg1 is null) throw new ArgumentNullException(nameof(arg1));
            if(arg2 is null) throw new ArgumentNullException(nameof(arg2));

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

        [AllParamsNotNull]
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

        [MethodImpl(MethodImplOptions.NoInlining)] 
        public bool ContractCheck(object arg1, object arg2)
        {
            Contract.Requires(arg1 != null);
            Contract.Requires(arg2 != null);
            return arg1.Equals(arg2);
        }

        [MethodImpl(MethodImplOptions.NoInlining)] 
        public bool CodeAnalysisAttribute([NotNull] object arg1, [NotNull] object arg2)
        {
            return arg1.Equals(arg2);
        }

        [MethodImpl(MethodImplOptions.NoInlining)] 
        public bool ClawsCheck(object arg1, object arg2)
        {
            Claws.NotNull(() => arg1);   
            Claws.NotNull(() => arg2);   

            return arg1.Equals(arg2);
        }

        [MethodImpl(MethodImplOptions.NoInlining)] 
        public bool DawnGuardCheck(object arg1, object arg2)
        {
            Dawn.Guard.Argument(arg1, nameof(arg1)).NotNull();
            Dawn.Guard.Argument(arg2, nameof(arg2)).NotNull();

            return arg1.Equals(arg2);
        }
    }
}