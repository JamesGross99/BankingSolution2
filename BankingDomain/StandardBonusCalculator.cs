using System;

namespace BankingDomain
{
    public class StandardBonusCalculator : ICalculateDepositBonusesForAccounts
    {


        public decimal GetBonusFor(decimal balance, decimal amountOfDeposit)
        {
            if (balance >= 5000M)
            {
                return amountOfDeposit * .10M;
            }
            else if (balance >= 1000M & balance < 5000)
            {
                return amountOfDeposit * .05M;
            }
            else
            {
                return 0;
            }
        }
    }
}