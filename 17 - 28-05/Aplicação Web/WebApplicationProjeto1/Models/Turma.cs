using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationProjeto1.Models
{
    public class Turma
    {
        [Key]
        [ScaffoldColumn(false)]
        public int turma_id { get; set; }

        [Display(Name = "Nome")]
        public string turma_nome { get; set; }

        [Display(Name = "Codigo")]
        public string turma_cod { get; set; }
    }
}
