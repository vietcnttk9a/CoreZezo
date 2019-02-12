﻿using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using PMS.MultiTenancy.Accounting.Dto;

namespace PMS.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
