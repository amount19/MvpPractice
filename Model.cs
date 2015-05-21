using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MvpPractice
{
    class Model:IPersonModel
    {
        int x;
        int y;

        public string createUserName(string _firstName,string _lastName)
        {
            return _firstName + " " + _lastName;
        }

        public int recursion(int start, int end)
        {
                if (start > end)
                {
                    x++;
                    return recursion(--start, end);
                }
                else if (end > start)
                {
                    x--;
                    return recursion(start, --end);
                }
                else
                {
                    return x;
                }
        }
    }
}
