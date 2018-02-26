using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Task1
{
    interface IUser
    {
        string Name { get; set; }
        string Password { get; set; }
        MailAddress Email { get; set; }
        DateTime Time { get; set; }
        string GetFullInfo();
    }
}
