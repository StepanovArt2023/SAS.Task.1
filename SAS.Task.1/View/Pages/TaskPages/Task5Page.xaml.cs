using System;
using System.Windows;
using System.Windows.Controls;

namespace SAS.Task._1.View.Pages.TaskPages
{
    public partial class Task5Page : Page
    {
        public Task5Page()
        {
            InitializeComponent();
        }

        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double y = Convert.ToDouble(TbY.Text);
                double a = Convert.ToDouble(TbA.Text);
                double t = Convert.ToDouble(TbT.Text);

                MessageBox.Show($"D = {(7.8*Math.Pow(a,2) + 3.52*t)/(Math.Log10(a + 2*y) + Math.Exp(y))}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TbY.Text = string.Empty;
                TbA.Text = string.Empty;
                TbT.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void TbA_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}