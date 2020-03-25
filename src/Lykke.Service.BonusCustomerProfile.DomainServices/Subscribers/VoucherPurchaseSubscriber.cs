﻿using System;
using System.Threading.Tasks;
using Lykke.Common.Log;
using Lykke.Service.BonusCustomerProfile.Domain.Models.Vouchers;
using Lykke.Service.BonusCustomerProfile.Domain.Services;
using Lykke.Service.Vouchers.Contract;

namespace Lykke.Service.BonusCustomerProfile.DomainServices.Subscribers
{
    public class VoucherPurchaseSubscriber : RabbitSubscriber<VoucherTokensUsedEvent>
    {
        private readonly IVoucherOperationsService _voucherOperationsService;
        private readonly string _tokenSymbol;

        public VoucherPurchaseSubscriber(
            string tokenSymbol,
            string connectionString,
            string exchangeName,
            IVoucherOperationsService voucherOperationsService,
            ILogFactory logFactory)
            : base(connectionString, exchangeName, logFactory)
        {
            _voucherOperationsService = voucherOperationsService 
                                       ?? throw new ArgumentNullException(nameof(voucherOperationsService));
            _tokenSymbol = tokenSymbol;

            GuidsFieldsToValidate.Add(nameof(VoucherTokensUsedEvent.CustomerId));
        }

        public override async Task<(bool isSuccessful, string errorMessage)> ProcessMessageAsync(VoucherTokensUsedEvent message)
        {
            if (message.Amount < 0)
                return (false, $"Amount has invalid value in voucher purchase event: '{message.Amount}'.");

            return await _voucherOperationsService.ProcessVoucherPurchaseEvent(new VoucherPurchaseModel
            {
                Currency = _tokenSymbol,
                Amount = (decimal)message.Amount,
                CustomerId = message.CustomerId,
            });
        }
    }
}
