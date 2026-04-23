namespace SistemaAhorros.Models;

public class CreateAccountRequest
{
    public string OwnerName {get;set;}="";
    public decimal InitialAmount {get;set;}
}