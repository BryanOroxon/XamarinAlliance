using System.Threading.Tasks;

namespace XamarinAllianceApp.Services
{
    public interface IAuthenticate
    {
        Task<bool> Authenticate();
    }
}
