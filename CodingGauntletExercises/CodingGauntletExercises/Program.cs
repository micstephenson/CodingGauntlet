public class BankAccount
{
    public string Name { get; set; }
    public double Balance { get; set; }
    public string Email { get; set; }

    public BankAccount(string name, double balance, string email)
    {
        Name = name;
        Balance = balance;
        Email = email;
    }

    public void AccountDetails()
    {
        Console.WriteLine($"Account Holder: {Name}, Balance: {Balance}, Email: {Email}");
    }

}

class Program
{
    static void Main(string[] args)
    {
        BankAccount account1 = new BankAccount("Mic", 1234.0, "Mic@email.com");
        BankAccount account2 = new BankAccount("Oli", 2345.0, "Oli@email.com");
        BankAccount account3 = new BankAccount("Ben", 3456.0, "Ben@email.com");

        var accounts = new List<BankAccount> { account1, account2, account3 };

        for (int i = 0; i < accounts.Count; i++)
        {
            accounts[i].AccountDetails();
        }
    }
}