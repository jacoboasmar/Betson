using System;
using Betson.Models;

namespace Betson.Repositories
{
    public interface IWalletRepository
    {
        Wallet GetWallet(int id);
    }
}