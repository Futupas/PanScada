using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Website
{
    public class Website
    {
        protected string[] Prefixes;

        protected HttpListener Listener;
        protected Thread WebsiteThread;

        public delegate string OnRequest(HttpListenerContext context);
        public delegate string OnRequestSimple(string path, string query, string method);
        protected bool issipmle;
        protected OnRequest onRequest;
        protected OnRequestSimple onRequestSimple;

        public Website(string[] prefixes, OnRequest request)
        {
            this.Prefixes = prefixes;
            this.onRequest = request;

            issipmle = false;
        }
        public Website(string prefix, OnRequestSimple request)
        {
            this.Prefixes = new string[] { prefix };
            this.onRequestSimple = request;

            issipmle = true;
        }
        public void Start()
        {
            try
            {
                this.Listener = new HttpListener();
                Listener.Prefixes.Clear();
                foreach (string p in this.Prefixes)
                {
                    Listener.Prefixes.Add(p);
                }
                WebsiteThread = new Thread(WebsiteLife);
                Listener.Start();
                WebsiteThread.Start();
            }
            catch (Exception ex)
            {
                throw new WebsiteException(ex);
            }
        }


        public void Stop()
        {
            try
            {
                Listener.Close();
                Listener.Stop();
                WebsiteThread.Abort();
            }
            catch (Exception ex)
            {
                throw new WebsiteException(ex);
            }
        }

        protected void WebsiteLife()
        {
            try
            {
                while (Listener.IsListening)
                {
                    HttpListenerContext context = Listener.GetContext();
                    Task.Factory.StartNew(() =>
                    {
                        Stream output = context.Response.OutputStream;
                        byte[] buffer;
                        if (issipmle)
                        {
                            buffer = System.Text.Encoding.UTF8.GetBytes(onRequestSimple.Invoke(
                                context.Request.Url.AbsolutePath,
                                context.Request.Url.Query,
                                context.Request.HttpMethod
                            ));
                        }
                        else
                        {
                            buffer = System.Text.Encoding.UTF8.GetBytes(onRequest.Invoke(context));
                        }
                        output.Write(buffer, 0, buffer.Length);
                        output.Close();
                    });
                }
            }
            catch (ThreadAbortException ex)
            {
                //
            }
            catch (Exception ex)
            {
                throw new WebsiteException(ex);
            }
        }
    }
    public class WebsiteException : Exception
    {
        public Exception InnnerException;
        public WebsiteException(Exception inner_ex)
        {
            this.InnnerException = inner_ex;
        }
    }
    public class SimpleWebsite
    {
        protected string Prefix;

        protected HttpListener Listener;
        protected Thread WebsiteThread;

        public delegate string OnRequest(HttpListenerContext context);
        protected OnRequest onRequest;
        public SimpleWebsite(string prefix, OnRequest request)
        {
            this.Prefix = prefix;
            this.onRequest = request;
        }
        public void Start()
        {
            try
            {
                this.Listener = new HttpListener();
                Listener.Prefixes.Clear();
                Listener.Prefixes.Add(this.Prefix);

                WebsiteThread = new Thread(WebsiteLife);
                Listener.Start();
                WebsiteThread.Start();
            }
            catch (Exception ex)
            {
                throw new WebsiteException(ex);
            }
        }

        public void Stop()
        {
            try
            {
                Listener.Close();
                Listener.Stop();
                WebsiteThread.Abort();
            }
            catch (Exception ex)
            {
                throw new WebsiteException(ex);
            }
        }

        protected void WebsiteLife()
        {
            try
            {
                while (Listener.IsListening)
                {
                    HttpListenerContext context = Listener.GetContext();
                    Task.Factory.StartNew(() =>
                    {
                        byte[] buffer = System.Text.Encoding.UTF8.GetBytes(onRequest.Invoke(context));

                        HttpListenerRequest request = context.Request;
                        HttpListenerResponse response = context.Response;

                        string[] urlsegments = request.Url.Segments;
                        
                        Stream output = context.Response.OutputStream;
                        output.Write(buffer, 0, buffer.Length);
                        output.Close();
                    });
                }
            }
            catch (ThreadAbortException ex)
            {
                //
            }
            catch (Exception ex)
            {
                throw new WebsiteException(ex);
            }
        }
    }
}
