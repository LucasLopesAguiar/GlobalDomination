using Modelos;
using Modelos.DAL;
using BibliotecaDigital.Controllers;
using System;
using System.Windows;

namespace BibliotecaDigital
{
    /// <summary>
    /// Lógica interna para new_user.xaml
    /// </summary>
    public partial class New_user : Window
    {
        Contexto contexto = new Contexto();
        public New_user()
        {
            InitializeComponent();


        }

        private void new_user_btn_Click(object sender, RoutedEventArgs e)
        {
            User u = new User
            {
                active = true,
                nome_user = username_text_nome.Text,
                login = username_text.Text,
                type_user = false,//false = usuario normal e true = adm
            };

            if (senha_text.Password != senha_check_text.Password)
            {
                senha_text.Clear();
                senha_check_text.Clear();
                MessageBox.Show("Senhas não conferem");
            }
            else
            {
                u.pass = senha_text.Password;
            }
            if (username_text.Text == "" || username_text_nome.Text == "" || senha_text.Password == "" || senha_check_text.Password == "" )
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                contexto.Usuarios.Add(u);
                contexto.SaveChanges();
                MessageBox.Show("Usuário Cadastrado");
                username_text.Clear();
                username_text_nome.Clear();
                senha_check_text.Clear();
                senha_text.Clear();
            }

        }

        private void new_user_btn_cancela_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow VoltaTelaLogin = new MainWindow();
            VoltaTelaLogin.ShowDialog();
        }
    }
}

     