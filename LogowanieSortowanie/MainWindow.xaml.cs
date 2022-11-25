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
using System.Windows.Navigation;
using System.Windows.Shapes;
using LogowanieSortowanie.Model;

namespace LogowanieSortowanie
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

        private void BtnSubmit_OnClick(object sender, RoutedEventArgs e)
        {
            var loginValidator = new LoginValidator(new UserModel { Login = login.Text, Password = password.Password.ToString() });

            if (loginValidator.Validate())
            {
                var windowSorting = new WindowSorting();
                windowSorting.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Invalid login or password");
            }

        }
    }
}
