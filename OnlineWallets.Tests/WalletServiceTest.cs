using NUnit.Framework;
using OnlineWallets.Services;

namespace OnlineWallets.Tests
{
    [TestFixture]
    public class WalletServiceTests
    {
        private WalletService _walletService;

        [SetUp]
        public void Setup()
        {
            _walletService = new WalletService(); // Replace with dependency injection
        }

        [Test]
        public void Deposit_ValidAmount_IncreasesBalance()
        {
            // Arrange
            var walletId = 1;
            var amount = 100;

            // Act
            _walletService.Deposit(walletId, amount);

            // Assert
            var balance = _walletService.GetBalance(walletId);
            Assert.Equals(amount, balance);
        }

        // Add more tests for different scenarios
    }
}