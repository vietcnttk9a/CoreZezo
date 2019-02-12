using System.Threading.Tasks;
using PMS.Sessions.Dto;

namespace PMS.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
