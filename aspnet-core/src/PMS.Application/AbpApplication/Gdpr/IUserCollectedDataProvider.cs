using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using PMS.Dto;

namespace PMS.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
