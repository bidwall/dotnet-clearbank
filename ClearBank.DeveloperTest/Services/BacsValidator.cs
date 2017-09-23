﻿using ClearBank.DeveloperTest.Types;

namespace ClearBank.DeveloperTest.Services
{
    public class BacsValidator : IValidator
    {
        public bool IsValid(Account account, MakePaymentRequest request)
        {
            return account != null && account.AllowedPaymentSchemes.HasFlag(AllowedPaymentSchemes.Bacs);
        }
    }
}