public class WalletService
{
    private readonly IWalletRepository _walletRepository;

    public WalletService(IWalletRepository walletRepository)

    {
        _walletRepository = walletRepository;

    }

    public decimal GetBalance(int walletId)
    {
        return _walletRepository.GetBalance(walletId);
    }

    public void Deposit(int walletId, decimal amount)
    {
        var currentBalance = _walletRepository.GetBalance(walletId);
        var newBalance = currentBalance + amount;
        _walletRepository.UpdateBalance(walletId, newBalance);
    }
}