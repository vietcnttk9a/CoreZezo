using System.Threading.Tasks;
using Abp;
using PMS.Configuration.Dto;
using PMS.UiCustomization;
using PMS.UiCustomization.Dto;

namespace PMS.Tests.UiCustomization
{
    public class NullThemeUiCustomizer : IUiCustomizer
    {
        public async Task<UiCustomizationSettingsDto> GetUiSettings()
        {
            return new UiCustomizationSettingsDto();
        }

        public Task UpdateUserUiManagementSettingsAsync(UserIdentifier user, ThemeSettingsDto settings)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateTenantUiManagementSettingsAsync(int tenantId, ThemeSettingsDto settings)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateApplicationUiManagementSettingsAsync(ThemeSettingsDto settings)
        {
            throw new System.NotImplementedException();
        }

        public Task<ThemeSettingsDto> GetHostUiManagementSettings()
        {
            throw new System.NotImplementedException();
        }

        public Task<ThemeSettingsDto> GetTenantUiCustomizationSettings(int tenantId)
        {
            throw new System.NotImplementedException();
        }
    }
}