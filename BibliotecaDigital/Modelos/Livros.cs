using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Livros
    {
        [Key]
        public int id_livro { get; set; }
        [Required]
        public bool active { get; set; } //sempre recebe true
        [Required]
        public string titulo { get; set; }
        [Required]
        public string editora { get; set; }
        public string categoria { get; set; }
        [Required]
        public string autor { get; set; }
        [Required]
        public string qtd_pag { get; set; }
        public string acervo { get; set; }
        public string ano { get; set; }
        public string descricao { get; set; }
        public int quantidade { get; set; }


    }
}
/* ESTRUTURA DA TABELA
 Livros: livros_tb;   
id_livro;
active; sempre recebe true, quando excluido pelo usuario, passa a ser false, o dado não é deletado do BD
titulo;
editora;
categoria;
autor;
qtd_pag;
acervo;
ano;
descricao;
quantidade;
*/
