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

namespace BibliotecaDigital.Telas_Internas
{
    /// <summary>
    /// Lógica interna para SystemLayout.xaml
    /// </summary>
    public partial class SystemLayout : Window
    {
        public SystemLayout()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

            //Chama tela cadastro SubItem do menu
                New_User_ADM tela_Adm_usernew = new New_User_ADM();
                     tela_Adm_usernew.ShowDialog();
            }


        //SubItem sobre o sistema 
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            sobreSistema tela_Adm_Sobre = new sobreSistema();
            tela_Adm_Sobre.ShowDialog();
        }

        //SubItem do menu que adiciona livro
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            New_Book_ADM tela_Adm_bookNew = new New_Book_ADM();
            tela_Adm_bookNew.ShowDialog();
        }
        
        private void logout_Click(object sender, RoutedEventArgs e)
        {
            //Escondo a tela e não mato processo
            this.Hide();
            MainWindow tela_Adm_logout = new MainWindow();
            tela_Adm_logout.ShowDialog();

            //Fecho a tela e mato o processo
            this.Close();
        }
    }
    }

