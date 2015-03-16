using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Problem 12. Parse URL

Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
Example:

URL	Information
http://telerikacademy.com/Courses/Courses/Details/212	[protocol] = http 
[server] = telerikacademy.com 
[resource] = /Courses/Courses/Details/212
 */

namespace Problem_12.Parse_URL
{
    class Program
    {
        static void Main(string[] args)
        {
            //Just edit the url to try for different inputs
            string url = "http://telerikacademy.com/Courses/Courses/Details/212";
            string editUrl = url;
            
            string protocol = editUrl.Substring(0, url.IndexOf("//") + 2);
            editUrl = editUrl.Remove(0, url.IndexOf("//") + 2);
            string host = editUrl.Substring(0, editUrl.IndexOf("/"));
            editUrl = editUrl.Remove(0, editUrl.IndexOf("/"));
            string resource = editUrl;
            Console.WriteLine("Protocol: " + protocol + "\nhost: " + host + "\nresource: " + resource);
        }
    }
}
