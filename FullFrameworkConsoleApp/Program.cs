using System;
using System.Configuration;
using System.Net;
using System.Net.Configuration;
using System.Net.Http;
using System.Reflection;

namespace FullFrameworkConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //var settings = (SettingsSection)config.GetSection("system.net/settings");
            //settings.HttpWebRequest.UseUnsafeHeaderParsing = true;
            //config.Save(ConfigurationSaveMode.Modified);
            //ConfigurationManager.RefreshSection("system.net/settings");

            //using (var httpClient = new HttpClient() { DefaultRequestHeaders = { ConnectionClose = true}}) 
            using (var httpClient = new HttpClient())
            {
                for (var i = 0; i < 10000; i++)
                {
                    Console.WriteLine($"Connection {i}");
                    var request = new HttpRequestMessage(HttpMethod.Head, new Uri("http://127.0.0.1:5000"));
                    var response = httpClient.SendAsync(request).Result;
                }
            }

            Console.Read();
        }
    }
}
