using ConsoleBank;
using ConsoleBank.Entities;
using ConsoleBank.Services;
using System;
List<Account> accounts = new();
List<User> users = new();
AccountService accountService = new AccountService();
UserService userService = new UserService();

while (true)
{
    string id = Login();
    Banking(id);
}

void Banking(string id)
{
    while (true)
    {
        if (string.IsNullOrEmpty(id))
        {
            Console.WriteLine("Could not find the user");
            return;
        }
        Account[] userAccounts = accounts.Where(a => a.UserId == id).ToArray();
        int i = 0;
        while (i < userAccounts.Length)
        {
            Console.WriteLine($"{i + 1}. {userAccounts[i]}");
            i++;
        }
        Console.WriteLine($"{i + 1}. Create new account");
        bool isValid = byte.TryParse(Console.ReadLine(), out byte option);
        if (!isValid)
        {
            Console.WriteLine("Invalid input.");
        }
        else if (option == i)
        {
            accountService.CreateAccount(id);
        }
        else
        {
            BankTransactions(userAccounts, option + 1);
        }
    }
}

void BankTransactions(Account[] userAccounts, int v)
{
    throw new NotImplementedException();
}

string Login()
{
    Console.WriteLine("Enter your email address");
    string email = Console.ReadLine().Trim();
    string id = users.Where(u => u.Email == email).FirstOrDefault().Id;
    return id;
}