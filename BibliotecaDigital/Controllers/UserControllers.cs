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

            //BUSCA USUÁRIOS POR ID
            public User BuscarPorLogin(string Login)
            {
            var lista = from u in contexto.Usuarios
                        where u.login == Login
                        select u;
            return contexto.Usuarios.FirstOrDefault();
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
            void Excluir(string Login)
            {
                User pExcluir = BuscarPorLogin(Login);

                if (pExcluir != null)
                {

                    contexto.Usuarios.Remove(pExcluir);
                    contexto.SaveChanges();
                }
            }

            //EDITAR USUÁRIOS
            void Editar(string Login, User novoDadosUsuario)
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

