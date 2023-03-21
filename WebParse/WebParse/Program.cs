using System.Text;
using System;
using System.Net;
using System.Net.Http;
using HtmlAgilityPack;

namespace WebParse
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "https://vk.com/turbojaba";
            var txtPath = @"E:\webParse\WebParse\parse.txt";
            



        }
        static HtmlDocument GetDocument(string url)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlDocument doc = web.Load(url);
            return doc;
        }
    }
}
