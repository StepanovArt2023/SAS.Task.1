using SAS.Task._1.Core;
using SAS.Task._1.View.Pages;
using System.ComponentModel;
using System.Windows;

namespace SAS.Task._1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CoreNavigate.MyConnection = MainFrame;
            MainFrame.Navigate(new MainPage());

        }

}

