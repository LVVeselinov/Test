using System;
using System.Net;

namespace UrlDecode
{
    class Program
    {
        static void Main(string[] args)
        {

            var Url = Console.ReadLine();

            while (Url != string.Empty)
            {
                Console.WriteLine(WebUtility.UrlDecode(Url));
                Uri uri;
                
                bool result = Uri.TryCreate(WebUtility.UrlDecode(Url), UriKind.Absolute, out uri)
                    && (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps) ;
                if (result)
                {
                    Console.WriteLine($"Protocol:{uri.Scheme}");
                    Console.WriteLine($"Host:{uri.Host}");
                    Console.WriteLine($"Port:{uri.Port}");
                    Console.WriteLine($"Path:{uri.LocalPath}");
                    if (uri.Query != string.Empty)
                        Console.WriteLine($"Query:{uri.Query}");
                    if (uri.Query != string.Empty)
                        Console.WriteLine($"Fragment:{uri.Fragment}");
                }
                else Console.WriteLine("Invalid Url");
                
                Url = Console.ReadLine();
               
            }
            
            
            
        }

    }
}
