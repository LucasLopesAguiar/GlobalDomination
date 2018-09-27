using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Emprestimos
    {
        [Key]
        public int id_emprestimo { get; set; }
        [Required]
        public int id_user { get; set; }
        [Required]
        public int id_livro { get; set; }

        //Verificar com o professor a propriedade ideal para armazenar data no banco
        [Required]
        public string emprestado { get; set; }
        [Required]
        public string devolucao { get; set; }
    }
}
/* ESTRUTURA DA TABELA
Emprestimos:  emprestimos_tb        
id_emprestimo;
id_user;
id_livro;
emprestado (data_inicial);
devolucao (data_final);
 */
