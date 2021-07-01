using ConvertCoin.Domain.Entities;

namespace ConvertCoin.Domain.Interfaces
{
    public interface IConvertCoinService
    {
        CoinValueEntity GetCoinValueFromApi(string source, string coinFor, string UriBase, string AcessKey);
    }
}
