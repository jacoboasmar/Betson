using System;
using System.Collections.Generic;
using System.Linq;
using Betson.Models;

namespace Betson.Repositories
{
    public class WalletRepository : IWalletRepository
    {
        private readonly List<Wallet> _wallets = new List<Wallet>();

        public Wallet GetWallet(int id)
        {
            return _wallets.FirstOrDefault(w => w.Id == id);
        }

        public void SaveWallet(Wallet wallet)
        {
            _wallets.Add(wallet);
        }
    }
}