using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class User
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public User(string name, string lastName, int age, string gender)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            Gender = gender;
        }
        public static User Copy(User user)
        {
            return user;
        }
        public static User DeepCopy(User user)
        {
            return new User(user.Name,user.LastName,user.Age,user.Gender);
        }
    }
}
