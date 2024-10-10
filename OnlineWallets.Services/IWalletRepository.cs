public interface IWalletRepository
{
    decimal GetBalance(int walletId);
    void UpdateBalance(int walletId, decimal newBalance);
}