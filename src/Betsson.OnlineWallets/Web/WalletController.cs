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
        try
        {
            var wallet = _walletService.GetWallet(userId);
            if (wallet == null)
            {
                return NotFound();
            }

            return Ok(wallet);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    [HttpPost("{userId}/deposit")]
    public IActionResult Deposit(int userId, [FromBody] decimal amount)
    {
        try
        {
            _walletService.Deposit(userId, amount);
            return Ok();
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

    [HttpPost("{userId}/withdraw")]
    public IActionResult Withdraw(int userId, [FromBody] decimal amount)
    {
        try
        {
            _walletService.Withdraw(userId, amount);
            return Ok();
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}