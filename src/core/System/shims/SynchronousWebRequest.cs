using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace iTextSharp.core.System.shims
{
    public class SynchronousWebRequest
    {
        public delegate void Handler(WebResponse resp);
        public static void GetResponse(WebRequest req, Handler respHandler)
        {
            ManualResetEvent done = new ManualResetEvent(false);
            AsyncCallback cb = delegate (IAsyncResult res)
            {
                try
                {
                    using (WebResponse resp = req.EndGetResponse(res))
                    {
                        respHandler(resp);
                    }

                }
                finally
                {
                    done.Set();
                }
            };
            req.BeginGetResponse(cb, null);
            done.WaitOne();
        }
    }
}
