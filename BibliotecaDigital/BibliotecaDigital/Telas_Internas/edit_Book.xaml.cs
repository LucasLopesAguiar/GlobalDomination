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
    /// Lógica interna para edit_Book.xaml
    /// </summary>
    public partial class edit_Book : Window
    {
        public edit_Book()
        {
            InitializeComponent();
        }

        private void Button_new_User_Click(object sender, RoutedEventArgs e)
        {
            New_Book_ADM AdicionaNovoLivroWinEdit = new New_Book_ADM();
            AdicionaNovoLivroWinEdit.ShowDialog();
        }

        private void Button_Alter_book_Click(object sender, RoutedEventArgs e)
        {
            New_Book_ADM EditaLivroWinEdit = new New_Book_ADM();
            EditaLivroWinEdit.ShowDialog();
        }
    }
}
