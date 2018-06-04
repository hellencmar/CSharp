using System.Windows;
using System.Windows.Controls;

namespace WpfView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            btnSalvar.Content = "aaaa";
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            if(chk.IsChecked.HasValue && chk.IsChecked.Value == true)
            {
                btnSalvar.Visibility = Visibility.Hidden;
            }
            else
                btnSalvar.Visibility = Visibility.Visible;
        }
    }
}
