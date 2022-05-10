using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsumindoApiTimesNba
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                // Instanciando o httpclient e criando a url base da api
                HttpClient client = new HttpClient { BaseAddress = new Uri("https://www.balldontlie.io/api/v1/") };
                // acessando o a rota específica 
                var response = await client.GetAsync("teams");
                // atribuindo o valor do conteúdo da requisicao
                var content = await response.Content.ReadAsStringAsync();

                // NOTA: - Início - Essa parte precisei pegar do stackoverflow pois estava com o erro: Error when deserializing JSON to Object. E após muitas tentativas e pesquisas, essa foi a única forma que eu encontrei para lançar ao console as informações adquiridas da api. 

                var teams = JsonConvert.DeserializeObject<RootObject>(content).Data;

                foreach (var team in teams)
                {
                    foreach (var infos in team)
                    {
                        Console.WriteLine(infos.Key + ":" + infos.Value);
                    }
                    Console.WriteLine();
                }

                // NOTA: - Fim -

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();

            }

        }
    }
}
