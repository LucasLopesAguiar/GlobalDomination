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
    /// Lógica interna para edit_Book.xaml
    /// </summary>
    public partial class edit_Book : Window
    {
        public edit_Book()
        {
            InitializeComponent();
        }

        private void Buscar_id_livro_Click(object sender, RoutedEventArgs e)
        {
            if(id_livro_text.Text == null)
            {
                MessageBox.Show("Insira um dado no campo de busca!!");
            }
            else
            {
                Livros livro = new LivrosControllers().BuscarPorId(int.Parse(id_livro_text.Text));
                if(livro != null)
                {
                    Nome_Book_ADM_Text.Text = livro.titulo;
                    Editora_Book_ADM_Text.Text = livro.editora;
                    Autor_Book_ADM_Text.Text = livro.autor;
                    Pagina_Book_ADM_Text.Text = livro.qtd_pag;
                    Ano_Book_ADM_Text.Text = livro.ano;
                    Descricao_Book_ADM_Text.Text = livro.descricao;
                }
                else
                {
                    MessageBox.Show("Livro não encontrado");
                    Nome_Book_ADM_Text.Text = "";
                    Editora_Book_ADM_Text.Text = "";
                    Autor_Book_ADM_Text.Text = "";
                    Pagina_Book_ADM_Text.Text = "";
                    Ano_Book_ADM_Text.Text = "";
                    Descricao_Book_ADM_Text.Text = "";
                }
                
                
            }


        }

        private void Alterar_book_user_btn_ADM_Click(object sender, RoutedEventArgs e)
        {
            Livros li = new Livros {
                active = true,
                titulo = Nome_Book_ADM_Text.Text,
                editora = Editora_Book_ADM_Text.Text,
                categoria = categoria_box.Text,
                autor = Autor_Book_ADM_Text.Text,
                qtd_pag = Pagina_Book_ADM_Text.Text,
                acervo = acervo_box.Text,
                ano = Ano_Book_ADM_Text.Text,
                descricao = Descricao_Book_ADM_Text.Text
            };
            Livros livro = new LivrosControllers().Editar(int.Parse(id_livro_text.Text), li);
            if (livro != null)
            {
                MessageBox.Show("Registro Alterado");
            }

        }

        private void Cancelar_book_btn_ADM_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            BibliotecaDigital.Telas_Internas.SystemLayout VoltaAdeme =  new  BibliotecaDigital.Telas_Internas.SystemLayout();
            VoltaAdeme.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            {
                if (new LivrosControllers().BuscarPorId(int.Parse(id_livro_text.Text)) != null)
                {
                    if (MessageBox.Show("Deseja realmente excluir?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
                    {

                        Nome_Book_ADM_Text.Clear();
                        Editora_Book_ADM_Text.Clear();
                        Autor_Book_ADM_Text.Clear();
                        Pagina_Book_ADM_Text.Clear();
                        Ano_Book_ADM_Text.Clear();
                        Descricao_Book_ADM_Text.Clear();

                    }
                    else
                    {
                        new LivrosControllers().Excluir(id_livro_text.Text);
                        MessageBox.Show("Usuário excluído com sucesso!");
                        edit_Book editbook = new edit_Book();
                        this.Close();
                        editbook.ShowDialog();

                    }
                }
                else { MessageBox.Show("Selecione um Livro"); }
            }

        }
    }
}
