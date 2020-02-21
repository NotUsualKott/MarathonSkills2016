﻿using System;
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
    /// Логика взаимодействия для FindOutMoreInfo.xaml
    /// </summary>
    public partial class FindOutMoreInfo : Window
    {
        public FindOutMoreInfo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();

            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AboutMarathonSkills2016 aboutMarathonSkills2016 = new AboutMarathonSkills2016();

            aboutMarathonSkills2016.Show();
            this.Close();
        }
    }
}
