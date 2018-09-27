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
        public void Inserir (Livros l)//Insert
        {
            contexto.Livros.Add(l);
            contexto.SaveChanges();
        }

        public List<Livros> ListarLivros()//Select * 
        {
            return contexto.Livros.ToList();
        }

        public Livros BuscarPorId(int id)//Busca por id_livro
        {

            return contexto.Livros.Find(id);
        }

        public void Excluir(int id)//Deletar registro da base de dados através do id_livro
        {
            Livros pExcluir = BuscarPorId(id);
            if (pExcluir != null)
            {

                contexto.Livros.Remove(pExcluir);
                contexto.SaveChanges();
            }
        }

        //Invativar registro para não aparecer na view para o usuario,true é visivel, false é invisivel
        public void InativarRegistro(int id, Livros novoDadoLivros)
        {
            Livros livroAntigo = BuscarPorId(id);
            if (livroAntigo != null)
            {
                livroAntigo.active = false;

                contexto.Entry(livroAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }




    }//Fim da public LivrosController
}
