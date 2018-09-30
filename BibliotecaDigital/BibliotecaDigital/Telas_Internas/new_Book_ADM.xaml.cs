using Modelos;
using Modelos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BibliotecaDigital.Controllers;
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
    /// Lógica interna para New_Book_ADM.xaml
    /// </summary>
    public partial class New_Book_ADM : Window
    {

        Contexto contexto = new Contexto();

        public New_Book_ADM()
        {
            InitializeComponent();
        }

        private void Adicionar_book_user_btn_ADM_Click(object sender, RoutedEventArgs e)
        {
            
            Livros li = new Livros
            {

                active = true,
                titulo = Nome_Book_ADM_Text.Text,
                editora = Editora_Book_ADM_Text.Text,
                categoria = categoria_box.Text,
                autor = Autor_Book_ADM_Text.Text,
                qtd_pag = Pagina_Book_ADM_Text.Text,
                acervo = acervo_box.Text,

                ano = Ano_Book_ADM_Text.Text,
                descricao = Descricao_Book_ADM_Text.Text,
            };
            //if(Quant_Book_ADM_Text_ != null)
            //{
            //    li.quantidade = int.Parse(Quant_Book_ADM_Text_.Text);
            //}

            if (Nome_Book_ADM_Text.Text == "" || Autor_Book_ADM_Text.Text == "" || Ano_Book_ADM_Text.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                if (new LivrosControllers().BuscarPorTitulo(li.titulo) != null)
                {
                    Nome_Book_ADM_Text.Clear();
                    MessageBox.Show("O Livro já Existe!");
                }
                else
                {
                    new LivrosControllers().Inserir(li);
                    MessageBox.Show("Cadastrado!");
                    
                }
            }

        }

        private void Cancelar_book_btn_ADM_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}










   