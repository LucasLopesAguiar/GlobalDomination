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
    /// Lógica interna para edit_User.xaml
    /// </summary>
    public partial class edit_User : Window
    {
        public edit_User()
        {
            InitializeComponent();
        }

        private void Button_new_User_Click(object sender, RoutedEventArgs e)
        {
            New_User_ADM AdicionaUserWinEdit = new New_User_ADM();
            AdicionaUserWinEdit.ShowDialog();
        }

        private void Button_Alter_Click(object sender, RoutedEventArgs e)
        {
            New_User_ADM EditaUserWinEdit = new New_User_ADM();
            EditaUserWinEdit.ShowDialog();
        }
    }
}
