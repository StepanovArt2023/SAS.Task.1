using System;
using System.Windows;
using System.Windows.Controls;

namespace SAS.Task._1.View.Pages.TaskPages
{
    public partial class Task21Page : Page
    {
        public Task21Page()
        {
            InitializeComponent();
        }

        private void BtnTask21_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TbX.Text);
                double k = Convert.ToDouble(TbK.Text);
                double p = Convert.ToDouble(TbP.Text);
                double d = Convert.ToDouble(TbD.Text);

                MessageBox.Show($"Q = {Math.Sqrt(k + 2.6*p*Math.Sin(k))/(x - Math.Pow(d,3))}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TbX.Text = string.Empty;
                TbK.Text = string.Empty;
                TbP.Text = string.Empty;
                TbD.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}