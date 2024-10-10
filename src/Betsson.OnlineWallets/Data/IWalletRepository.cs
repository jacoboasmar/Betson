public interface IWalletRepository
{
    Wallet GetWallet(int userId);
    void SaveWallet(Wallet wallet);
}