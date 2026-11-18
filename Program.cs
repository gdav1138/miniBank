namespace MiniBank
{
    public class Program
    {
        static void Main()
        {
            MiniBankLog miniBankLog = new MiniBankLog();
            // Account account = new Account();
            // Console.WriteLine($"Current Balance is: {account.GetBalance()}");
            // Console.WriteLine("Depositing $200.00...");
            // account.Deposit(200);
            // Console.WriteLine($"Current Balance is: {account.GetBalance()}");
            // Console.WriteLine("Withdrawing $200.00...");
            // account.Withdraw(200);
            // Console.WriteLine($"Current Balance is: {account.GetBalance()}");
            // Console.WriteLine("Withdrawing $10.00...");
            // account.Withdraw(10);
                Console.WriteLine("Welcome to your new account with MiniBank!");
                Console.WriteLine("Please select from the following options: ");
                miniBankLog.Entry();
        }
    }
}