namespace MiniBank
{
    public class MainDisplay()
    {
        public void MainScreen()
        {
            Console.WriteLine("Welcome to MiniBank! Please choose from the following options: ");
            Console.WriteLine("1. Create New Account");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Quit\n");
        }

        public void UserNameScreen()
        {
            Console.WriteLine("Please enter a username using letters and numbers only: ");
        }

        public void PasswordScreen()
        {
            Console.WriteLine("Please enter a password using letters and numbers only: ");
        }

        public void LoginScreen()
        {
            Console.WriteLine("Please enter your username: ");
        }

        public void Login()
        {
            Console.WriteLine("Please enter your password: ");
        }
    }
}