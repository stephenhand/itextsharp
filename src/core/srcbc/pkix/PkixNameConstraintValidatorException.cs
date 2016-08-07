using System;

namespace Org.BouncyCastle.Pkix
{
#if !(NETCF_1_0 || NETCF_2_0 || SILVERLIGHT || NET_STANDARD)
    [Serializable]
#endif
    public class PkixNameConstraintValidatorException
        : Exception
    {
        public PkixNameConstraintValidatorException(String msg)
            : base(msg)
        {
        }
    }
}
