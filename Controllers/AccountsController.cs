using Microsoft.AspNetCore.Mvc;
using SistemaAhorros.Models;
using SistemaAhorros.Data;

namespace SistemaAhorros.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AccountsController: ControllerBase
{ private readonly AppDbContext _context;

    public AccountsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost("deposit")]
    public IActionResult Deposit([FromBody] DepositRequest request)
    {
        if (string.IsNullOrEmpty(request.AccountNumber))
            return BadRequest("AccountNumber is required");

        if(request.Amount<=0)
            return BadRequest("Amount must be greater than 0");
                
        return Ok("Endpoint de deposito listo");
    }
}

