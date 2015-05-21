using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvpPractice
{
    interface IView
    {
        String FirstNameText { get; set; }
        String LastNameText { get; set; }
        String UserNameText { get; set; }
        String StartNumberText { get; set; }
        String EndNumberText { get; set; }
        String RecursiveOutputText { get; set; }
    }
}
