using System;
using System.Collections.Generic;
using System.Reflection;

#if NET_STANDARD
using System.Runtime.Loader;
#endif

namespace System.shims
{
    public static class Assemblies
    {
#if NET_STANDARD
        public static Assembly LoadFrom(String path)
        {
            return AssemblyLoadContext.Default.LoadFromAssemblyPath(path);
        }
#else

        
        public static Assembly LoadFrom(String path)
        {
            return Assembly.LoadFrom(path);
        }
#endif
    }
}
