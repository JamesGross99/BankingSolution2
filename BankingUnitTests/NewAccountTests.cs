
using BankingDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BankingUnitTests
{
    public class NewAccountTests
    {
        [Fact]
        public void HaveCorrectStartingBalance()
        {
            // WTCYWYH
            // Given
            var account = new BankAccount(null);

            // When
            decimal balance = account.GetBalance();

            // Then
            Assert.Equal(1000M, balance);
        }
    }
}
