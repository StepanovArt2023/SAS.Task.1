using System;
using System.Windows;
using System.Windows.Controls;

namespace SAS.Task._1.View.Pages.TaskPages
{
    public partial class Task20Page : Page
    {
        public Task20Page()
        {
            InitializeComponent();
        }

        private void BtnTask20_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double y = Convert.ToDouble(TbY.Text);
                double t = Convert.ToDouble(TbT.Text);
                double l = Convert.ToDouble(TbL.Text);

                MessageBox.Show($"K = {(2*Math.Pow(t,2) + 3*l + 7.2)/(Math.Log10(y) + Math.Exp(2*l))}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TbY.Text = string.Empty;
                TbT.Text = string.Empty;
                TbL.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}