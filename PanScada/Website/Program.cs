using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Website
{
    class Program
    {
        static void Main(string[] args)
        {
            Website website1 = new Website(@"http://192.168.0.111:80/", Request);
            website1.Start();
            Console.ReadLine();
            website1.Stop();
        }
        static string Request(string p, string q, string m)
        {
            Console.WriteLine("request url: "+m+":"+p+q);
            string head = "";
            string body = "Request method: "+m;
            string str = string.Format("<!DOCTYPE html><html><head>{0}</head><body>{1}</body></html>", head, body);
            return str;
        }
    }
}
