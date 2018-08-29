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

            //Chama tela cadastro
                New_User_ADM tela_Adm_usernew = new New_User_ADM();
                     tela_Adm_usernew.ShowDialog();
            }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            SobreSistema tela_Adm_Sobre = new SobreSistema();
            tela_Adm_Sobre.ShowDialog();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            New_Book_ADM tela_Adm_bookNew = new New_Book_ADM();
            tela_Adm_bookNew.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            New_User_ADM tela_Adm_usernew = new New_User_ADM();
            tela_Adm_usernew.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            New_Book_ADM tela_Adm_BookNew = new New_Book_ADM();
            tela_Adm_BookNew.ShowDialog();
        }
    }
    }

