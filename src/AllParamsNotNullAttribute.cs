using System;
using System.Diagnostics;
using System.Reflection;

namespace NullCheckTest.src
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Constructor)]
    public class AllParamsNotNullAttribute : Attribute
    {
        public void Validate(object instance, MethodBase method, object[] parameters)
        {
            var parameterInfos = method.GetParameters();
            for (int i = 0; i < parameterInfos.Length; i++)
            {
                if (parameters[i] == null)
                {
                    throw new ArgumentNullException(parameterInfos[i].Name);
                }
            }
        }
    }
}