using Refit;
using System.Threading.Tasks;

namespace ConsumindoApiDogFacts
{
    public interface IFatos
    {
        [Get("/api/facts?number=1")]
        Task<Fatos> GetRandomFacts();
    }
}
