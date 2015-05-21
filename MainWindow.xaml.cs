using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MvpPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,IView
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Presenter cPresenter = new Presenter(this);
            cPresenter.getUserName();
            cPresenter.getRecursiveOutput();
        }
        public string FirstNameText
        {
            get { return FirstNameTextBox.Text; }
            set { FirstNameTextBox.Text = value; }
        }
        public string LastNameText
        {
            get { return LastNameTextBox.Text; }
            set { LastNameTextBox.Text = value; }
        }
        public string UserNameText
        {
            get { return NameOutputTextBlock.Text; }
            set { NameOutputTextBlock.Text = value; }
        }
        public string StartNumberText
        {
            get { return StartTextBox.Text; }
            set { StartTextBox.Text = value; }
        }
        public string EndNumberText
        {
            get { return EndTextBox.Text; }
            set { EndTextBox.Text = value; }
        }
        public string RecursiveOutputText
        {
            get { return RecOutputTextBlock.Text; }
            set { RecOutputTextBlock.Text = value; }
        }
    }
}
