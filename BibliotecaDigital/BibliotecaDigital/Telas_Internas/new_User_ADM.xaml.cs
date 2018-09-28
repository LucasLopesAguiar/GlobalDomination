using Modelos;
using Modelos.DAL;
using System;
using BibliotecaDigital.Controllers;
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

namespace BibliotecaDigital
{
    /// <summary>
    /// Lógica interna para New_User_ADM.xaml
    /// </summary>
    public partial class New_User_ADM : Window
    {

        Contexto contexto = new Contexto();
        public New_User_ADM()
        {
            InitializeComponent();
        }

        private void new_user_cadastro_btn_ADM_Click(object sender, RoutedEventArgs e)
        {
            {
                User u = new User
                {
                    active = true,
                    nome_user = nomepessoa_text_ADM.Text,
                    login = username_text_ADM.Text,

                    type_user = false,//false = usuario normal e true = adm
                };

                if (senha_text_ADM.Password != senha_check_text_ADM.Password)
                {
                    senha_text_ADM.Clear();
                    senha_check_text_ADM.Clear();
                    MessageBox.Show("Senhas não conferem");
                }
                else
                {
                    u.pass = senha_text_ADM.Password;
                }
                if (nomepessoa_text_ADM.Text == "" || username_text_ADM.Text == "" || senha_text_ADM.Password == "" || senha_check_text_ADM.Password == "")
                {
                    MessageBox.Show("Preencha todos os campos");
                }
                else
                {
                    if (new UserControllers().BuscarPorLogin(u.login) != null)
                    {
                        username_text_ADM.Clear();
                        MessageBox.Show("Usuário já existe");
                    }
                    else
                    {
                        new UserControllers().Inserir(u);
                        MessageBox.Show("Usuário cadastrado com sucesso!");
                        MainWindow login = new MainWindow();
                        this.Close();
                        login.ShowDialog();
                    }
                }

            }

        }

    }
}