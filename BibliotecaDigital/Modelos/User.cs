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

    }
}
