using System;
using System.Threading.Tasks;
using Genbox.WolframAlpha;
using Genbox.WolframAlpha.Enums;
using Genbox.WolframAlpha.Requests;
/*
 * Uses Genbox WolframAlpha NuGet package
 * Source: https://github.com/Genbox/WolframAlpha
 */
namespace WolframCalc
{
    public static class Program
    {
        // AppId: API key provided from WolframAlpha
        private const string AppId = "LQY2YY-AL69V9YHVA";

        private static async Task Main()
        {
            // Initialize client with AppId
            var client = new WolframAlphaClient(AppId);

            Console.WriteLine("Query to search WolframAlpha:");
            
            // Get query input from user
            var inputQuery = Console.ReadLine();
            
            // Convert output to decimal by appending "decimal" keyword to the query
            if (inputQuery.Contains("/"))
            {
                inputQuery += "decimal";
            }
            // Create ShortAnswerRequest with given query
            var request = new ShortAnswerRequest(inputQuery) {OutputUnit = Unit.Metric};
            
            // Store response string into the data and print
            var data = await client.ShortAnswerAsync(request).ConfigureAwait(false);
            Console.WriteLine(data);
        }
    }
}