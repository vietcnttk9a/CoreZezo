using System.Threading.Tasks;
using Abp.Application.Services;
using PMS.Editions.Dto;
using PMS.MultiTenancy.Dto;

namespace PMS.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}