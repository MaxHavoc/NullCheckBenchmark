using System;
using System.Runtime.CompilerServices;

namespace NullCheckTest
{
    public static class Extension
    {
        public static void NotNull(this object self, [CallerArgumentExpression("self")] string name = "")
        {
            _ = self ?? throw new ArgumentNullException(name);
        }

        public static void NotNullWithoutCaller(this object self)
        {
            _ = self ?? throw new ArgumentNullException(nameof(self));
        }
    }
}