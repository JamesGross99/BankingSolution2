using BankingDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingUnitTests
{
   public class MakingDepositTests
    {
        [Fact]
        public void DepositIncreasesBalance()
        {
            var account = new BankAccount(new DummyBonusCalculator());
            var openingBalance = account.GetBalance();
            var amountToDeposit = 100M;

            account.Deposit(amountToDeposit) ;

            Assert.Equal(openingBalance + amountToDeposit, account.GetBalance());
        }
    }

    public class DummyBonusCalculator : ICalculateDepositBonusesForAccounts
    {
        public decimal GetBonusFor(decimal balance, decimal amountOfDeposit)
        {
            return 0;
        }
    }
}
