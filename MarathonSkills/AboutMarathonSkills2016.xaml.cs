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
using System.Windows.Shapes;

namespace MarathonSkills
{
    /// <summary>
    /// Логика взаимодействия для AboutMarathonSkills2016.xaml
    /// </summary>
    public partial class AboutMarathonSkills2016 : Window
    {
        public AboutMarathonSkills2016()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InteractiveMap interactiveMap = new InteractiveMap();
            interactiveMap.Show();
            this.Close();
        }
    }
}
