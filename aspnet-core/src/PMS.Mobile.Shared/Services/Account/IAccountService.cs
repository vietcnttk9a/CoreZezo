using System.Threading.Tasks;
using PMS.ApiClient.Models;

namespace PMS.Services.Account
{
    public interface IAccountService
    {
        AbpAuthenticateModel AbpAuthenticateModel { get; set; }
        AbpAuthenticateResultModel AuthenticateResultModel { get; set; }
        Task LoginUserAsync();
    }
}
