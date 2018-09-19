using Modelos;
using Modelos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDigital.Controllers
{
    class UserControllers
    {
        void Inserir(User u)//Insert
        {
            Contexto contexto = new Contexto();
            contexto.Usuarios.Add(u);
            contexto.SaveChanges();
        }

        List<User> ListarUsuarios()//Select * all
        {
            Contexto contexto = new Contexto();
            return contexto.Usuarios.ToList();
        }



    }
}
