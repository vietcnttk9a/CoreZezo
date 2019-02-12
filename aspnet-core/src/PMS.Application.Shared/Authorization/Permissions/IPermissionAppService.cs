using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PMS.Authorization.Permissions.Dto;

namespace PMS.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
