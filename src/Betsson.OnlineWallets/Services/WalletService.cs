using System;
using Betson.Models;
using Betson.Repositories;

namespace Betson.Services
{
    public class WalletService
    {
        private readonly IWalletRepository _repository;

        public WalletService(IWalletRepository repository)
        {
            _repository = repository;
        }

        public Wallet GetWallet(int id)
        {
            return _repository.GetWallet(id);
        }
    }
}