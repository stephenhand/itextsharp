using System;
using System.Collections.Generic;

namespace iTextSharp.xmp.timezone
{
    public class CompatibleTimeZone
    {
#if NET_STANDARD

        public static TimeZoneInfo CurrentLocal
        {
            get
            {
                return TimeZoneInfo.Local;
            }
        }
#else
        public static TimeZone CurrentLocal
        {
            get
            {
                return TimeZone.CurrentTimeZone;
            }
        }
#endif
    }
}
