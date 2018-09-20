﻿using BibliotecaDigital.Controllers;
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

namespace BibliotecaDigital
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void help_btn_Click(object sender, RoutedEventArgs e)
        {
            sobreSistema window = new sobreSistema();
            window.ShowDialog();

            UserControllers user = new UserControllers();
            user.ListarUsuarios();
        }

        private void new_user_btn_Click(object sender, RoutedEventArgs e)
        {
            new_user window2 = new new_user();
            window2.ShowDialog();
        }
    }
}
