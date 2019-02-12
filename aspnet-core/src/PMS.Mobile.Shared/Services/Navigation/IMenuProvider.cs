using System.Collections.Generic;
using MvvmHelpers;
using PMS.Models.NavigationMenu;

namespace PMS.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}