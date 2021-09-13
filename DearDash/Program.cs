using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace DearDash
{

    class Program
    {
        Uri baseAddress = new Uri("https://private-anon-f5a4d30fc4-dearinventory.apiary-mock.com/ExternalApi/v2/");

        static async Task Main()
        {
            string s = "https://inventory.dearsystems.com/ExternalApi/v2/saleList?Page=1&Limit=100&CombinedPickStatus=NOT PICKED";
            await GetData(s);

            
        }
        static async Task GetData(string args)
        {
            
            using var client = new HttpClient();
           
           //client.DefaultRequestHeaders.Authorization = new  System.Net.Http.Headers.AuthenticationHeaderValue("api-auth-accountid", "250e84bd-5654-4e23-81ff-89ee7cfd272a");

            client.DefaultRequestHeaders.Add("api-auth-accountid", "250e84bd-5654-4e23-81ff-89ee7cfd272a");
            client.DefaultRequestHeaders.Add("api-auth-applicationkey", "246191c9-cbf5-5e9a-9b8e-a67e7c333ee1");


            var content = await client.GetStringAsync(args);
            Console.WriteLine(content);

            
        }

        static void M(string[] args)
        {

            //static async Task Main(string[] args)
            //{
            //    using var client = new HttpClient();

            //    var content = await client.GetStringAsync("https://private-anon-f5a4d30fc4-dearinventory.apiary-mock.com/ExternalApi/v2/sale/fulfilment/pick?TaskID=TaskID&IncludeProductInfo=IncludeProductInfo");

            //    Console.WriteLine(content);
            //}

            


            //            HttpMessageHandler handler = new HttpMessageHandler("https://private-anon-f5a4d30fc4-dearinventory.apiary-mock.com/ExternalApi/v2/");


            //HttpClient.DefaultRequestHeaders.TryAddWithoutValidation("api-auth-accountid", "704ef231-cd93-49c9-a201-26b4b5d0d35b");

            //    Console.WriteLine("Hello World!");
        }
    }
}




//using (var httpClient = new HttpClient { BaseAddress = baseAddress })
//{


//    httpClient.DefaultRequestHeaders.TryAddWithoutValidation("api-auth-accountid", "704ef231-cd93-49c9-a201-26b4b5d0d35b");

//    httpClient.DefaultRequestHeaders.TryAddWithoutValidation("api-auth-applicationkey", "0342a546-e0c2-0dff-f0be-6a5e17154033");

//    using (var response = await httpClient.GetAsync("ref/attributeset"))
//    {

//        string responseData = await response.Content.ReadAsStringAsync();
//    }
//}
