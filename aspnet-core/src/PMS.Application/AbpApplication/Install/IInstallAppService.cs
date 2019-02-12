using System.Threading.Tasks;
using Abp.Application.Services;
using PMS.Install.Dto;

namespace PMS.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}