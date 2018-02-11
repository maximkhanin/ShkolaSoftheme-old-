using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Ivan", "Ivanov", 20, "Male");
            var user2 = User.Copy(user1);
            Console.WriteLine(user2.Equals(user1));
            var user3 = User.DeepCopy(user1);
            Console.WriteLine(user3.Equals(user1));
        }
    }
}
