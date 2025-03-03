//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HelloGreetingApp.Services
//{
//    public class GreetingService : IGreetingService
//    {
//        public string GetGreeting()
//        {
//            return "Hello, World!";
//        }
//    }
//}
namespace HelloGreetingApp.Services
{
    public class GreetingService : IGreetingService
    {
        public string GetGreeting(string? firstName, string? lastName)
        {
            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
            {
                return $"Hello, {firstName} {lastName}!";
            }
            else if (!string.IsNullOrEmpty(firstName))
            {
                return $"Hello, {firstName}!";
            }
            else if (!string.IsNullOrEmpty(lastName))
            {
                return $"Hello, {lastName}!";
            }
            else
            {
                return "Hello, World!";
            }
        }
    }
}
