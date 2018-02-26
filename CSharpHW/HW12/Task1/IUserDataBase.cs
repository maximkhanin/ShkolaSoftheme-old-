using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    interface IUserDataBase: IDisposable
    {
        List<IUser> UsersList { get; set; }
        void Add(IUser user, UserDataBase userDataBase);
        void GetList(bool clean);
        IUser Search(string Name, UserDataBase userDataBase);

    }
}
