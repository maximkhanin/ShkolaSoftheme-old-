﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    interface IAuthenticator
    {
       
        bool AuthenticateUser(IUser user, UserDataBase userDataBase);
    }
}
