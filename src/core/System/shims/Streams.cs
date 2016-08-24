using System;
using System.Collections.Generic;
using System.IO;

namespace System.shims
{
    public static class Streams
    {
#if NET_STANDARD
        public static byte[] GetBuffer(this MemoryStream source){
            ArraySegment<byte> bufferSegment;
            if (source.TryGetBuffer(out bufferSegment)) {
                return bufferSegment.Array;
            }

            throw new UnauthorizedAccessException("Unauthorized access to MemoryStream buffer");
        }
#endif

    }
}
