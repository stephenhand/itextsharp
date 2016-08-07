using System;

namespace Org.BouncyCastle.X509.Store
{
	public interface IX509Selector
#if !SILVERLIGHT && !NET_STANDARD
		: ICloneable
#endif
	{
#if SILVERLIGHT || NET_STANDARD
        object Clone();
#endif
        bool Match(object obj);
	}
}
