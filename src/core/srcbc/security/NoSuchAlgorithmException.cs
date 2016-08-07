using System;

namespace Org.BouncyCastle.Security
{
	[Obsolete("Never thrown")]
#if !(NETCF_1_0 || NETCF_2_0 || SILVERLIGHT || NET_STANDARD)
    [Serializable]
#endif
    public class NoSuchAlgorithmException : GeneralSecurityException
	{
		public NoSuchAlgorithmException() : base() {}
		public NoSuchAlgorithmException(string message) : base(message) {}
		public NoSuchAlgorithmException(string message, Exception exception) : base(message, exception) {}
	}
}
