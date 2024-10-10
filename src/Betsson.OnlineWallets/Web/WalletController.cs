using System.Runtime.InteropServices;

[ApiController]
[Route("api/[controller]")]
public class WalletController : ControllerBase
{
    private readonly WalletService _walletService;

    public WalletController(WalletService walletService)
    {
        _walletService = walletService;
    }

    [HttpGet("{userId}")]
    public IActionResult GetWallet(int userId)
    {
        var wallet = _walletService.GetWallet(userId);
        if (wallet == null)
        {
            return NotFound();
        }

        return Ok(wallet);
    }

    [HttpPost("{userId}/deposit")]
    public IActionResult Deposit(int userId, [FromBody] decimal amount)
    {
        _walletService.Deposit(userId, amount);
        return Ok();
    }

    [HttpPost("{userId}/withdraw")]
    public IActionResult Withdraw(int userId, [FromBody] decimal amount)
    {
        _walletService.Withdraw(userId, amount);
        return Ok();
    }
}