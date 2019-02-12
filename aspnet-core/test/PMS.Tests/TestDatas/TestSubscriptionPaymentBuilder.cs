﻿using System.Linq;
using System.Linq.Dynamic.Core;
using PMS.Editions;
using PMS.EntityFrameworkCore;
using PMS.MultiTenancy.Payments;

namespace PMS.Tests.TestDatas
{

    public class TestSubscriptionPaymentBuilder
    {
        private readonly PMSDbContext _context;
        private readonly int _tenantId;

        public TestSubscriptionPaymentBuilder(PMSDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            CreatePayments();
        }

        private void CreatePayments()
        {
            var defaultEdition = _context.Editions.FirstOrDefault(e => e.Name == EditionManager.DefaultEditionName);

            CreatePayment(1, defaultEdition.Id, _tenantId, 2, "147741");
            CreatePayment(19, defaultEdition.Id, _tenantId, 29, "1477419");
        }

        private SubscriptionPayment CreatePayment(decimal amount, int editionId, int tenantId, int dayCount, string paymentId)
        {
            var payment = _context.SubscriptionPayments.Add(new SubscriptionPayment
            {
                Amount = amount,
                EditionId = editionId,
                TenantId = tenantId,
                DayCount = dayCount,
                ExternalPaymentId = paymentId
            }).Entity;
            _context.SaveChanges();

            return payment;
        }
    }

}
