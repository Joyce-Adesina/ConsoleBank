using ConsoleBank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBank.Services
{
    public class UserService
    {
        public  string CreateUser()
        {
            Console.WriteLine("Enter your first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your Email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter your phone number");
            string phoneNumber = Console.ReadLine();


            User user = new User()
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Address = address,
                PhoneNumber = phoneNumber
            };
            Console.WriteLine($"Account successfully created for {user.Email}");
            return user.Id;
        }
    }
}
