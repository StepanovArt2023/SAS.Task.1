using System;
using System.Windows;
using System.Windows.Controls;

namespace SAS.Task._1.View.Pages.TaskPages
{
    public partial class Task25Page : Page
    {
        public Task25Page()
        {
            InitializeComponent();
        }

        private void BtnTask25_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double t = Convert.ToDouble(TbT.Text);
                double c = Convert.ToDouble(TbC.Text);

                MessageBox.Show($"L = {Math.Pow(Math.Cos(c),2) + (3*Math.Pow(t,2) + 4)/Math.Sqrt(c + t)}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TbT.Text = string.Empty;
                TbC.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}