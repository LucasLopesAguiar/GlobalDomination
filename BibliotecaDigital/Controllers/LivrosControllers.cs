using Modelos;
using Modelos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDigital.Controllers
{
    public class LivrosControllers
    {
        Contexto contexto = new Contexto();
      


        //INSERIR NOVO LIVRO
        public void Inserir(Livros li)
        {
            contexto.Livros.Add(li);
            contexto.SaveChanges();
        }

        //LISTAS LIVROS
        List<Livros> ListarTodosLivros()
        {
            return contexto.Livros.ToList();
        }

        //BUSCA LIVROS POR TItulo
        public Livros BuscarPorTitulo(string Titulo)
        {
            var lista = from li in contexto.Livros
                        where li.titulo == Titulo
                        select li;
            return contexto.Livros.FirstOrDefault();
        }

        public Livros BuscarPorId(int id)//Busca por id
        {
            return contexto.Livros.Find(id);
        }

        public Livros ValidarLivro(string titulo, string Autor)
        {
            if (new LivrosControllers().BuscarPorTitulo(titulo) == null)
            {
                return null;
            }
            else
            {
                Livros li = new Livros();
                li = BuscarPorTitulo(titulo);
                if (li.autor == Autor)
                {
                    return li;
                }
                else
                {
                    return null;
                }
            }

        }
        //EXLUIR LIVROS
        void Excluir(string Titulo)
        {
            Livros pExcluir = BuscarPorTitulo(Titulo);

            if (pExcluir != null)
            {

                contexto.Livros.Remove(pExcluir);
                contexto.SaveChanges();
            }
        }

        //EDITAR
        public Livros Editar(int id_livro, Livros novoDadosLivro)
        {
            Livros LivroAntigo = BuscarPorId(id_livro);

            if (LivroAntigo != null)
            {
                LivroAntigo.titulo = novoDadosLivro.titulo;
                LivroAntigo.editora = novoDadosLivro.editora;
                LivroAntigo.categoria = novoDadosLivro.categoria;
                LivroAntigo.autor = novoDadosLivro.autor;
                LivroAntigo.qtd_pag = novoDadosLivro.qtd_pag;
                LivroAntigo.acervo = novoDadosLivro.acervo;
                LivroAntigo.ano = novoDadosLivro.ano;
                LivroAntigo.descricao = novoDadosLivro.descricao;
                LivroAntigo.quantidade = novoDadosLivro.quantidade;


                contexto.Entry(LivroAntigo).State =
                System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
                
            }
            return novoDadosLivro;
        }

        //PESQUISAR LIVRO POR NOME
        List<Livros> PesquisarPorNome(string Titulo)
        {
            var lista = from li in contexto.Livros where li.titulo == Titulo select li;
            return lista.ToList();
        }
    }
}
