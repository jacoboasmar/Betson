using System;
using Microsoft.AspNetCore.Mvc;
using Betson.Models;
using Betson.Services;
using System.Runtime.InteropServices;

namespace Betson.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WalletController : ControllerBase
    {
        private readonly WalletService _service;

        public WalletController(WalletService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public IActionResult GetWallet(int id)
        {
            var wallet = _service.GetWallet(id);
            if (wallet == null)
            {
                return NotFound();
            }
            return Ok(wallet);
        }
    }
}