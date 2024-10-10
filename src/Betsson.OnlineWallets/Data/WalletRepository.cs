public class WalletRepository : IWalletRepository
{
    private readonly List<Wallet> _wallets = new List<Wallet>();

    public Wallet GetWallet(int userId)
    {
        return _wallets.FirstOrDefault(w => w.Id == userId);
    }

    public void SaveWallet(Wallet wallet)
    {
        var existingWallet = GetWallet(wallet.Id);
        if (existingWallet != null)
        {
            existingWallet.Balance = wallet.Balance;
        }
        else
        {
            _wallets.Add(wallet);
        }
    }
}