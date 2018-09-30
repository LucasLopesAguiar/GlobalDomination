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
        

            //INSERIR NOVO USUÁRIO
            public void Inserir(User u)
            {
                contexto.Usuarios.Add(u);
                contexto.SaveChanges();
            }

            //LISTAS USUÁRIOS
            List<User> ListarTodosUsuarios()
            {
                return contexto.Usuarios.ToList();
            }

            //BUSCA USUÁRIOS POR Login
            public User BuscarPorLogin(string Login)

        {  
            List<User> users = new UserControllers().ListarTodosUsuarios();
            foreach (User login in users)
            {
                if (login.login == Login)
                {
                    return login;
                }
}
            return null;
        }


            public User BuscarPorId(int id)//Busca por id_user
            {
                return contexto.Usuarios.Find(id);
            }

        public User ValidarLogin(string login, string senha)
            {
                if (new UserControllers().BuscarPorLogin(login) == null)
                {
                    return null;
                }
                else
                {
                    User u = new User();
                    u = BuscarPorLogin(login);
                    if (u.pass == senha)
                    {
                        return u;
                    }
                    else
                    {
                        return null;
                    }
                }

            }
            //EXLUIR USUÁRIOS
           public void Excluir(int id)
            {
                User pExcluir = BuscarPorId(id);

                if (pExcluir != null)
                {

                    contexto.Usuarios.Remove(pExcluir);
                    contexto.SaveChanges();
                }
            }

            //EDITAR USUÁRIOS
            public void Editar(string Login, User novoDadosUsuario)
            {
                User usuarioAntigo = BuscarPorLogin(Login);

                if (usuarioAntigo != null)
                {
                    usuarioAntigo.nome_user = novoDadosUsuario.nome_user;
                    usuarioAntigo.login = novoDadosUsuario.login;


                    contexto.Entry(usuarioAntigo).State =
                    System.Data.Entity.EntityState.Modified;
                    contexto.SaveChanges();
                }
            }

            //PESQUISAR USUÁRIOS POR NOME
            List<User> PesquisarPorNome(string Login)
            {
                var lista = from u in contexto.Usuarios where u.login == Login select u;
                return lista.ToList();
            }
        }
    }

