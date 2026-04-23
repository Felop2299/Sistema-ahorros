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

        var account = _context.Accounts.FirstOrDefault(a=>a.AccountNumber == request.AccountNumber);
        if(account == null)
            return NotFound("Account not found");

            account.Balance = account.Balance + request.Amount;
                
                
        

        var transaction = new Transaction
        {
            AccountId=account.Id,
            Amount=request.Amount,
            Type="Deposit",
            Date=DateTime.Now
        
        };
        _context.Transactions.Add(transaction);
        _context.SaveChanges();

        return Ok($"Deposit of {request.Amount} was successful");
    }

    [HttpPost("withdraw")]
    public IActionResult Withdraw([FromBody] DepositRequest request)
    {
        if(string.IsNullOrEmpty(request.AccountNumber))
            return BadRequest("AccountNumber is required");

        if(request.Amount<=0)
        return BadRequest("Amount must be greater thant 0"); 

        var account = _context.Accounts.FirstOrDefault(a=>a.AccountNumber == request.AccountNumber) ;

        if(account == null)
            return NotFound("Account not found");

        if(account.Balance < request.Amount)
            return BadRequest("Not enough funds");

        account.Balance = account.Balance - request.Amount;

        var transaction= new Transaction
        {
            AccountId = account.Id,
            Amount= request.Amount,
            Type= "Withdraw",
            Date = DateTime.Now
        };

        _context.Transactions.Add(transaction);
        _context.SaveChanges();
           return Ok ($"Withdraw of {request.Amount} was successful");

    }

    [HttpPost("create")]
    public IActionResult CreateAccount([FromBody] CreateAccountRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.OwnerName))
            return BadRequest("OwnerName is required");
        if (request.InitialAmount < 0)
            return BadRequest("InitialAmount cannot be negative");

        var account = new Account
        {
            OwnerName = request.OwnerName,
            InitialAmount = request.InitialAmount,
            Balance = request.InitialAmount,
            AccountNumber = Guid.NewGuid().ToString()
        };

        _context.Accounts.Add(account);
        _context.SaveChanges();

        return Ok(new {message = "Account created successfully", accountNumber = account.AccountNumber});    
    } 
    [HttpGet("balance/{accountNumber}")]
    public IActionResult GetBalance(string accountNumber)

    {
        var account = _context.Accounts.FirstOrDefault(a=>a.AccountNumber == accountNumber);
        if(account == null)
            return NotFound("Account not found");

        return Ok(new
        {
            account.AccountNumber,
            account.OwnerName,
            account.Balance
        }) ;
    }
}

