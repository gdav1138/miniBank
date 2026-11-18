using System.ComponentModel.DataAnnotations;

namespace MiniBank
{
    public class MiniBankLog
    {
        public void Entry()
        {
            bool Continue = true;
            AccountStore accountStore = new AccountStore();
            AccountServices accountServices = new AccountServices();
            MainDisplay mainDisplay = new MainDisplay();

            do
            {
                mainDisplay.MainScreen();
                string input = Console.ReadLine();
                bool result = int.TryParse(input, out int selection);

                switch (selection)
                {
                    case 1:
                        Account userAccount = new Account();
                        mainDisplay.UserNameScreen();
                        userAccount.CreateUserName();
                        mainDisplay.PasswordScreen();
                        userAccount.CreateUserPassword();
                        accountStore.AddAccount(userAccount);
                    break;
                    case 2:
                        mainDisplay.LoginScreen();
                        string userName = accountServices.GetUser();
                        
                        userAccount = accountStore.GetAccountData(userName);

                        if (userAccount != null)
                        {
                            mainDisplay.Login();
                            userAccount.PasswordVerify();

                        }
                    break;
                // Console.WriteLine("2. Check Balance");
                // Console.WriteLine("3. Deposit Funds");
                // Console.WriteLine("4. Withdraw Funds");
                // Console.WriteLine("5. Quit");
                    case 3: 
                        Continue = false;
                        // if (currAccount == null)
                        // {
                        //     Console.WriteLine("Invalid option. You currently don't have an account with MiniBank.");
                        // } 
                        // else 
                        // {
                        //     Console.WriteLine("How much would you like to deposit? Enter dollars and cents.");
                        //     string deposit = Console.ReadLine();
                        //     if (double.TryParse(deposit, out double userDeposit))
                        //     {
                        //         currAccount.Deposit(userDeposit);
                        //     } 
                        //     else
                        //     {
                        //         Console.WriteLine("Invalid amount entered, returning to menu...");
                        //     }
                        // }
                    break;
                    default: 
                        Console.WriteLine("Invalid Selection. Please try again.");
                    break;
                }
            } while (Continue == true);
        }
    }
}