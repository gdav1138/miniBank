using System; 
using System.Collections.Generic;

namespace MiniBank
{
    class AccountStore
    {
        List<Account> accounts = new List<Account>();

        public void AddAccount(Account newAccount)
        {
            accounts.Add(newAccount);
        }

        public Account GetAccountData(string userName)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].accountUserName == userName)
                {
                    Account foundAccount = accounts[i];
                    return foundAccount;
                } 
            }

            Console.WriteLine("No account exists under that name");
            return null;
        }
        
    }
}