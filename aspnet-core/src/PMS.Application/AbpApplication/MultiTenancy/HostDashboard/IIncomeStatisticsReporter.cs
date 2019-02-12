using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PMS.MultiTenancy.HostDashboard.Dto;

namespace PMS.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}