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

namespace MarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            App.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RegisterAsARunner registerAsARunner = new RegisterAsARunner();
            registerAsARunner.Owner = this;

            registerAsARunner.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SponsorARunner sponsorARunner = new SponsorARunner();
            sponsorARunner.Owner = this;

            sponsorARunner.Show();
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FindOutMoreInfo findOutMoreInfo = new FindOutMoreInfo();
            findOutMoreInfo.Owner = this;

            findOutMoreInfo.Show();
            this.Hide();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Owner = this;

            login.Show();
            this.Hide();
        }
    }
}
