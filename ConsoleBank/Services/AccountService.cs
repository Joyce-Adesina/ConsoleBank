using ConsoleBank.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleBank.Services
{
    public class AccountService
    {
        public List<Account> accounts;
        public AccountService()
        {
            accounts = new List<Account>();
        }
        public void Deposit(int accountNumber, decimal amount, string message)
        {
            Account account = accounts.Where(a => a.AccountNumber == accountNumber).FirstOrDefault();
            account.AccountBalance = account.AccountBalance + amount;
            Console.WriteLine($" Successfully deposited {amount} to your Account");
        }
        public void WithDrawal(int accountNumber, decimal amount, string message)
        {
            Account account = accounts.Where(a => a.AccountNumber == accountNumber).FirstOrDefault();
            Console.WriteLine("Enter your pin");
            bool isValidPIN = uint.TryParse(Console.ReadLine(), out uint pin);
            if (!isValidPIN)
            {
                Console.WriteLine("Invalid PIN");
                return;
            }
            if (account.PIN != pin)
            {
                Console.WriteLine("Wrong PIN");
                return;
            }
            account.AccountBalance -= amount;
            Console.WriteLine($"Successfully withdraw {amount} from your Account");
        }
        public void Transfer(int accountNumber1, int  accountNumber2, decimal amount, string message)

        {
            Console.WriteLine("Enter your pin");
            bool isValidPIN = uint.TryParse(Console.ReadLine(), out uint pin);
            if(!isValidPIN)
            {
                Console.WriteLine("Invalid PIN");
                return;
            }
            Account account1 = accounts.Where(a =>a.AccountNumber ==accountNumber1).FirstOrDefault();
            Account account2 = accounts.Where(a =>a.AccountNumber  > accountNumber2).FirstOrDefault();
            if (account1.PIN != pin)
            {
                Console.WriteLine("Wrong PIN");
                return;
            }
            account1.AccountBalance -= amount;
            account2.AccountBalance += amount;
            Console.WriteLine($"Successfully transferred from your {amount} to recipient's account");

        }
        public void CreateAccount(string userId)
        {
            Console.WriteLine("Enter User Id");
            Console.WriteLine("Enter your first name");
            string firstName = Console.ReadLine ();
            Console.WriteLine("Enter your last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your Account type. Format: saving or current");
            string accounttype = Console.ReadLine ();
            if (!(accounttype == "savings") || !(accounttype == "current"))
            {
                Console.WriteLine("Invaild Response");
                return;
            }
            Console.WriteLine("Enter your new pin");
            bool isValidPIN = uint.TryParse(Console.ReadLine(), out uint pin);
            if (!isValidPIN)
            {
                Console.WriteLine("Invalid PIN");
                return;
            }
            int accountNumber = new Random().Next(1111111111, 1999909999);
            Account account = new Account()
            {
                PIN = pin,
                UserId = userId,
                FirstName=firstName,
                LastName = lastName,
                AccountType = accounttype,
                AccountNumber = accountNumber
            };

            Console.WriteLine($"Successfully created Account, your account number is: {accountNumber} ");

        }

        
    }


}
