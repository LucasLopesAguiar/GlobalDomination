using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class User
    {
        [Key]
        public int id_user { get; set; }
        [Required]
        public string nome_user { get; set; }
        [Required]
        public string login { get; set; }
        [Required]
        public string pass { get; set; }
        public bool type_user { get; set; }
        public bool active { get; set; } //usuario ativo ou não

    }
}
/* ESTRUTURA DA TABELA
Usuário: user_tb    
id_user;
active;
nome_user;
login;
pass;
type_user(bool);
 */
