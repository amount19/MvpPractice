using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvpPractice
{
    interface IPersonModel
    {
        String createUserName(string _firstName, string _lastName);
    }
}
