using Modelos;
using Modelos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDigital.Controllers
{
    public class EmprestimosControllers
    {
        Contexto contexto = new Contexto();
        public void Inserir(Emprestimos e)//Insert
        {
            contexto.Emprestimos.Add(e);
            contexto.SaveChanges();
        }

        public List<Emprestimos> ListarEmpestimos()//Emprestimos é necessário verificar pois fará a listagem por data e por usuário
        {
            
            return contexto.Emprestimos.ToList();
        }

        public Emprestimos BuscarPorId(int id)//Busca por id_user
        {

            return contexto.Emprestimos.Find(id);
        }

        public void Excluir(int id)//Deletar registro da base de dados através do id_user
        {
            Emprestimos pExcluir = BuscarPorId(id);
            if (pExcluir != null)
            {

                contexto.Emprestimos.Remove(pExcluir);
                contexto.SaveChanges();
            }
        }

    }//Fim da Emprestimos Controllers
}
