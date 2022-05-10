using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumindoApiDogFacts
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var dogsFactsApi = RestService.For<IFatos>("https://dog-api.kinduff.com/");
                var randomFacts = await dogsFactsApi.GetRandomFacts();
                Console.WriteLine("Random fact: " + randomFacts.Facts[0]);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu um erro: {e.Message}");
                Console.ReadLine();
            }
        }
    }
}
