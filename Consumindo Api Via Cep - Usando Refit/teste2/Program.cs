using Refit;
using System;
using System.Threading.Tasks;

namespace ConsumindoApiViaCep
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var cep = RestService.For<IEnderecoService>("http://viacep.com.br");
                Console.Write("Informe o CEP desejado: ");
                string cepInformado = Console.ReadLine().ToString();

                var endereco = await cep.GetAddressAsync(cepInformado);
                Console.WriteLine($"CEP informado: {endereco.Cep}\nCidade: {endereco.Localidade}\nUF: {endereco.Uf}\nLogradouro: {endereco.Logradouro}\nBairro: {endereco.Bairro}");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro na consulta: {e.Message}");
                Console.ReadLine();

            }
        }
    }
}
