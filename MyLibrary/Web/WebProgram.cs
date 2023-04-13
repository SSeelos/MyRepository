using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace MyLibrary_DotNETstd_2_1.Web
{
    public class WebProgram : IProgram
    {
        //HttpClient is intended to be instantiated once per application, rather than per-use.
        static readonly HttpClient client = new HttpClient();
        public void Run()
        {
            WebCLient_Example();

            HttpClient_Example();


        }

        private static void WebCLient_Example()
        {
            //We don't recommend that you use the WebClient class for new development.
            //Instead, use the System.Net.Http.HttpClient class.
            //https://docs.microsoft.com/en-us/dotnet/api/system.net.webclient?view=net-5.0
            using (var client = new WebClient())
            {
                string result = client.DownloadString("https://stackoverflow.com/questions/6656451/c-sharp-read-webpage-content-streamreader");

                Console.WriteLine(result);
            }

            Console.Clear();
        }

        //https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=net-5.0
        static async Task HttpClient_Example()
        {
            try
            {

                string uri = "https://www.purediablo.com/diablo-2/runewords/";
                string response = await client.GetStringAsync(uri);

                Console.WriteLine(response);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
