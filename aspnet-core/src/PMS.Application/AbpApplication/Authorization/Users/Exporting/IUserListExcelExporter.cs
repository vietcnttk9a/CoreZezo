using System.Collections.Generic;
using PMS.Authorization.Users.Dto;
using PMS.Dto;

namespace PMS.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}