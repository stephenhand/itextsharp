using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
#if NET_STANDARD
using System.Threading.Tasks;
#endif

namespace System.shims
{
    public class SynchronousWebRequest
    {
        public delegate void RequestStreamWriteHandler(Stream str);
        public delegate void Handler(WebResponse resp);
        public static void WriteRequest(WebRequest req, RequestStreamWriteHandler handler)
        {
            ManualResetEvent done = new ManualResetEvent(false);
            Exception callbackError = null;
            AsyncCallback cb = delegate (IAsyncResult res)
            {
                try
                {
                    using (Stream resp = req.EndGetRequestStream(res))
                    {
                        handler(resp);
                    }

                }
                catch (Exception e)
                {
                    callbackError = e;
                }
                finally
                {
                    done.Set();
                }
            };
            req.BeginGetRequestStream(cb, null);
            done.WaitOne();
            if (callbackError != null)
            {
                throw callbackError;
            }

        }

        public static void GetResponse(WebRequest req, Handler respHandler)
        {
            ManualResetEvent done = new ManualResetEvent(false);
            Exception callbackError = null;
            AsyncCallback cb = delegate (IAsyncResult res)
            {
                try
                {
                    using (WebResponse resp = req.EndGetResponse(res))
                    {
                        respHandler(resp);
                    }

                }
                catch (Exception e) {
                    callbackError = e;
                }
                finally
                {
                    done.Set();
                }
            };
            req.BeginGetResponse(cb, null);
            done.WaitOne();
            if (callbackError != null) {
                throw callbackError;
            }
        }
    }
}
