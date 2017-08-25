 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemSmartHouse
{
    public interface IUser
    {
        string Password { get; set; }
        string SUPassword { get; set; }

    }
}
