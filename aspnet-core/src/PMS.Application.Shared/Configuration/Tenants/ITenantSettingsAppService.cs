using System.Threading.Tasks;
using Abp.Application.Services;
using PMS.Configuration.Tenants.Dto;

namespace PMS.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
