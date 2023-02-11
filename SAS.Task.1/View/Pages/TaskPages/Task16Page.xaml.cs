using System;
using System.Windows;
using System.Windows.Controls;

namespace SAS.Task._1.View.Pages.TaskPages
{
    public partial class Task16Page : Page
    {
        public Task16Page()
        {
            InitializeComponent();
        }

        private void BtnTask16_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double y = Convert.ToDouble(TbY.Text);
                double r = Convert.ToDouble(TbR.Text);
                double t = Convert.ToDouble(TbT.Text);

                MessageBox.Show($" W= {(4*Math.Pow(t,3) + Math.Log10(r))/(Math.Exp(y + r) + 7.2*Math.Sin(r))}", "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);

                TbY.Text = string.Empty;
                TbR.Text = string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}