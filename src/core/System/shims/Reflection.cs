using System;

using System.Reflection;

namespace iTextSharp.core.System.shims
{
    public class Reflection
    {
        public class CompatibleTimeZone
        {
#if NET_STANDARD

            public static TypeInfo GetReflectionType(Object o)
            {
                return o.GetType().GetTypeInfo();
            }

            public static TypeInfo GetReflectionType(Type t)
            {
                return t.GetTypeInfo();
            }
#else


            public static Type GetReflectionType(Object o)
            {
                return o.GetType();
            }
            public static Type GetReflectionType(Type t)
            {
                return t;
            }
#endif
        }
    }
}
