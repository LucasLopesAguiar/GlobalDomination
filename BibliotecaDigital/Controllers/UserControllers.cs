using Modelos;
using Modelos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDigital.Controllers
{
    public class UserControllers
    {
        Contexto contexto = new Contexto();
        public void Inserir(User u)//Insert
        {
            contexto.Usuarios.Add(u);
            contexto.SaveChanges();
        }

        public List<User> ListarUsuarios()//Select *
        {
            return contexto.Usuarios.ToList();
        }

        public User BuscarPorId(int id)//Busca por id_user
        {
            return contexto.Usuarios.Find(id);
        }

        public User BuscarPorLogin(string login)
        {
            return contexto.Usuarios.Find(login);// busca por login
        }

        public void Excluir(int id)//Deletar registro da base de dados através do id_user
        {
            User pExcluir = BuscarPorId(id);
            if(pExcluir != null){
               
                contexto.Usuarios.Remove(pExcluir);
                contexto.SaveChanges();
            }
        }

        //Invativar registro para não aparecer na view para o usuario,true é visivel, false é invisivel
        public void InativarRegistro(int id, User novoDadoUser)
        {
            User userAntigo = BuscarPorId(id);
            if(userAntigo != null)
            {
                userAntigo.active = false;
                
                contexto.Entry(userAntigo).State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }
        }



    }//Fim da User Controller
}
