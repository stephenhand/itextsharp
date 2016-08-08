using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iTextSharp.xmp.timezone
{
    public abstract class ITimeZoneAdapter
    {
        private readonly object _tz;

        public ITimeZoneAdapter(object tz){
            _tz = tz;    
        }
        object Implementation { get { return _tz; } }
        ITimeZoneAdapter CurrentLocal { get; }
    }
}
