using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MvpPractice
{
    class Presenter
    {
        IView mView;
        public Presenter(IView view)
        {
            mView = view;
        }

        public string getUserName()
        {
            Model cModel=new Model();
            mView.UserNameText = cModel.createUserName(mView.FirstNameText, mView.LastNameText);
            return mView.UserNameText;
        }
        public string getRecursiveOutput()
        {
            Model cModel = new Model();
            try
            {
                int start = Convert.ToInt32(mView.StartNumberText);
                int end = Convert.ToInt32(mView.EndNumberText);
                if (start - end < 5000)//prevent stackoverflow
                {
                    mView.RecursiveOutputText = cModel.recursion(start, end).ToString();
                }
                else
                {
                    mView.RecursiveOutputText = (start - end).ToString();
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine(e.Message);
                MessageBox.Show("numbers must be integers");
                return null;
            }
            return mView.RecursiveOutputText;
        }
    }
}
