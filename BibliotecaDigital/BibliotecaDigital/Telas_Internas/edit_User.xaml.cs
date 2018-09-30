using BibliotecaDigital.Controllers;
using Modelos;
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

        private void new_user_cadastro_btn_ADM_Click(object sender, RoutedEventArgs e)
        {
            if (Buscar_emID.Text == null)
            {
                MessageBox.Show("Insira um dado no campo de busca!!");
            }
            else
            {
                User user = new UserControllers().BuscarPorId(int.Parse(Buscar_emID.Text));
                if (user != null)
                {
                    username_text_ADM.Text = user.login;
                    nomepessoa_text_ADM.Text = user.nome_user;
                    senha_text_ADM.Password = user.pass;
                    
                             
                    
                }
                else
                {
                    MessageBox.Show("Dados não encontrado");
                    username_text_ADM.Text = "";
                    nomepessoa_text_ADM.Text = "";
                    senha_text_ADM.Password = "";
                    
                    
                }


            }


        }

        private void Alterar_btn_Click(object sender, RoutedEventArgs e)
        {
            User u = new User
            {
                active = true,

                login = username_text_ADM.Text,
                nome_user = nomepessoa_text_ADM.Text,
                pass = senha_text_ADM.Password,

            };
                       

         
            if (username_text_ADM.Text == "" || nomepessoa_text_ADM.Text == "" || senha_text_ADM.Password == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                new UserControllers().Editar(u.login, u);
                MessageBox.Show("Usuário alterado com sucesso!");
                
                
            }

           
            }

        private void Deleta_User_Click(object sender, RoutedEventArgs e)
        {
            if (new UserControllers().BuscarPorId(int.Parse(Buscar_emID.Text)) != null)
            {
                if (MessageBox.Show("Deseja realmente excluir este usuário?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                {
                    username_text_ADM.Clear();
                    senha_text_ADM.Clear();
                    nomepessoa_text_ADM.Clear();
                    

                }
                else
                {
                    new UserControllers().Excluir(int.Parse(Buscar_emID.Text));
                    MessageBox.Show("Usuário excluído com sucesso!");
                    edit_User edit = new edit_User();
                    this.Close();
                    edit.ShowDialog();

                }
            }
            else { MessageBox.Show("Selecione um usuário"); }
        }

        private void new_user_cancela_btn_ADM_la_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }
    }
}

      
 

