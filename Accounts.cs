using System;

namespace MiniBank
{
    public class Account
    {
        // Account Variables
        private Guid _accId = Guid.NewGuid();
        private string? _accountPass = null;
        private double _balance = 0.0;
        public string? accountUserName = null;

        // Set username for DB storage
        private void SetUserName(string userName)
        {
            accountUserName = userName;
        }

        // User Created password, hashed
        private void SetPassword(string userPassword)
        {
            _accountPass = Security.Hash(userPassword);
            Console.WriteLine($"{_accountPass}");
        }

        public void CreateUserName()
        {
            bool isOnlyLettersNumbers = false;

            do
            {
                string userName = Console.ReadLine();

                isOnlyLettersNumbers = !string.IsNullOrEmpty(userName) && userName.All(char.IsLetterOrDigit);

                if (!isOnlyLettersNumbers)
                {
                    Console.WriteLine("Invalid entry\n");
                }
                else
                {
                    SetUserName(userName);
                } 
            } while (isOnlyLettersNumbers == false);
        }

        public void CreateUserPassword()
        {
            bool isOnlyLettersNumbers = false;

            do
            {
                string userPassword = Console.ReadLine();

                isOnlyLettersNumbers = !string.IsNullOrEmpty(userPassword) && userPassword.All(char.IsLetterOrDigit);

                if (!isOnlyLettersNumbers)
                {
                    Console.WriteLine("Invalid entry\n");
                }
                else
                {
                    SetPassword(userPassword);
                } 
            } while (isOnlyLettersNumbers == false);
        }

        public void PasswordVerify()
        {
            string userPass = Console.ReadLine();
            string storedHash = _accountPass;
            bool passwordVerified = Security.VerifyPassword(userPass, storedHash);

        }

        public double GetBalance()
        {
            return _balance;
        }

        public void Deposit(double deposit)
        {
            _balance += deposit;
        }

        public void Withdraw(double withdrawAmount)
        {
            if (_balance - withdrawAmount < 0)
            {
                Console.WriteLine("Unable to complete withdrawal. Insufficient Funds.");   
            } else
            {
                _balance -= withdrawAmount;
            }
        }
    }
}
