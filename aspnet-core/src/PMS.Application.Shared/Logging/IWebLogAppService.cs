using Abp.Application.Services;
using PMS.Dto;
using PMS.Logging.Dto;

namespace PMS.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
