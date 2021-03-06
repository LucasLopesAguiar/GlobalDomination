﻿using BibliotecaDigital.Controllers;
using Modelos.DAL;
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
using BibliotecaDigital;


namespace BibliotecaDigital
/// Interação lógica para MainWindow.xam
/// </summary>
{ 
    public partial class MainWindow : Window
    {

        Contexto contexto = new Contexto();

        public MainWindow()
        {
            InitializeComponent();

        }

        private void help_btn_Click(object sender, RoutedEventArgs e)
        {
            sobreSistema window = new sobreSistema();
            window.ShowDialog();

        }

        private void new_user_btn_Click(object sender, RoutedEventArgs e)
        {
            New_user window2 = new New_user();
            window2.ShowDialog();
        }

        private void login_btn_Click(object sender, RoutedEventArgs e)
        {
            {
                if (new UserControllers().ValidarLogin(Login_Text.Text, Pass_txt.Password) != null)
                {
                    Telas_Internas.SystemLayout home = new Telas_Internas.SystemLayout();
                    home.ShowDialog();
            }
            else
                {
                    Login_Text.Clear();
                    Pass_txt.Clear();
                    MessageBox.Show("Usuário ou Senha INVÁLIDO");
                }
            }

        }
    }
}
