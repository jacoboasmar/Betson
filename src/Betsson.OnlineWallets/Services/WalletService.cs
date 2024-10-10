public class WalletService
{
    private readonly IWalletRepository _repository;

    public WalletService(IWalletRepository repository)
    {
        _repository = repository;
    }

    public Wallet GetWallet(int userId)
    {
        return _repository.GetWallet(userId);
    }

    public void Deposit(int userId, decimal amount)
    {
        var wallet = GetWallet(userId);
        if (wallet == null)
        {
            throw new Exception("Wallet not found");
        }

        wallet.Balance += amount;
        _repository.SaveWallet(wallet);
    }

    public void Withdraw(int userId, decimal amount)
    {
        var wallet = GetWallet(userId);
        if (wallet == null)
        {
            throw new Exception("Wallet not found");
        }

        if (wallet.Balance < amount)
        {
            throw new Exception("Insufficient balance");
        }

        wallet.Balance -= amount;
        _repository.SaveWallet(wallet);
    }
}