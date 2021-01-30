using System.Threading.Tasks;

namespace PMSystem.Domain.Interfaces
{
    public interface ITokenClaimsService
    {
        Task<string> GetTokenAsync(string userName);
    }
}
