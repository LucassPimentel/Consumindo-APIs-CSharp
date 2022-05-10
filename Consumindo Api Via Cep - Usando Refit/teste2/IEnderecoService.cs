using Refit;
using System.Threading.Tasks;

namespace ConsumindoApiViaCep
{
    public interface IEnderecoService
    {
        [Get("/ws/{cep}/json/")]
        Task<Endereco> GetAddressAsync(string cep);
    }
}
