public class BankaAccount
{
    public string AccountHolder  { get; set; }
    public decimal Balance { get; private set; }

    public BankaAccount(string accountHolder, decimal initialBalance)
    {
       if(Balance < 0)
        {
            throw new ArgumentException("Initial balance cannot be negative.");
        }
        AccountHolder = accountHolder;
        Balance = initialBalance;
    }
    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive.");
        }
        Balance += amount;
    }
    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive.");
        }
        if (amount > Balance)
        {
            throw new InvalidOperationException("Insufficient funds.");
        }
        Balance -= amount;
    }
    public void ShowAccountDetails()
    {
        Console.WriteLine($"Account Holder: {AccountHolder}, Balance: {Balance}");
    }
    public class program
    {
        public static void Main(string[] args)
        {
            BankaAccount account = new BankaAccount("John Doe", 1000m);
            account.ShowAccountDetails();
            account.Deposit(500m);
            account.ShowAccountDetails();
            account.Withdraw(200m);
            account.ShowAccountDetails();
        }
    }

}
