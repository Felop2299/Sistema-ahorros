namespace SistemaAhorros.Models;
public class Account
{
    public int Id {get;set;}
    public string OwnerName {get; set;}
    public string AccountNumber {get;set;}
    public decimal Balance {get;set;}
    public decimal InitialAmount{get;set;}

}