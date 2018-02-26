using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class UserDataBase : IUserDataBase
    {
        private bool disposed = false;

        public List<IUser> UsersList { get; set; }

        public UserDataBase()
        {
            UsersList = new List<IUser>();

        }

        public void Add(IUser user, UserDataBase userDataBase)
        {
            if (disposed) throw new ObjectDisposedException("UserDataBase");
            Authenticator authenticator = new Authenticator();

            if (authenticator.AuthenticateUser(user, userDataBase))
            {
                UsersList.Add(user);
            }
            else
            {
                Console.WriteLine("This username exists");
            }
        }
        public IUser Search(string name, UserDataBase userDataBase)
        {
            foreach (var item in UsersList)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }
        public void GetList(bool clean)
        {
            if (!disposed)
            {
                if (clean)
                {
                    foreach (var item in UsersList)
                    {
                        Console.WriteLine(item.Name + " " + item.Email + '\n');
                    }
                }
            }
            disposed = true;

        }


        public void Dispose()
        {
            GetList(true);
            GC.SuppressFinalize(this);
        }

        ~UserDataBase()
        {
            GetList(false);
        }

    }
}
