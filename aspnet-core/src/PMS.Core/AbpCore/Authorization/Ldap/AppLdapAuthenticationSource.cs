using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using PMS.Authorization.Users;
using PMS.MultiTenancy;

namespace PMS.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}