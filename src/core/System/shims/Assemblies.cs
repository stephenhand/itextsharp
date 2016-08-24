using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using System.Threading.Tasks;

namespace iTextSharp.core.System.shims
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
