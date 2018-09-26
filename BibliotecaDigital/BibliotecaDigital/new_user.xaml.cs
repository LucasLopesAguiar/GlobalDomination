﻿using Modelos;
using Modelos.DAL;
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
            if (senha_text.Password == senha_check_text.Password)
            {
                u.pass = senha_text.Password;

                contexto.Usuarios.Add(u);
                contexto.SaveChanges();

                MessageBox.Show("Deu certo");
            }
            else {
                check_pass_label.Content = "senhas não conferem";
            }



        }
    }
}
/* ESTRUTURA DA TABELA
Usuário: user_tb    
id_user;
active;
nome_user;
login;
pass;
type_user(bool); false = usuario normal e true = adm
 */