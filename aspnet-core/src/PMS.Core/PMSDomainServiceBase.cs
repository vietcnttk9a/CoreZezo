using Abp.Domain.Services;

namespace PMS
{
    public abstract class PMSDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected PMSDomainServiceBase()
        {
            LocalizationSourceName = PMSConsts.LocalizationSourceName;
        }
    }
}
