using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplicationProjeto1.Models
{
    public class Usuario
    {
        [Key]
        [ScaffoldColumn(false)]
        public int usu_codigo { get; set; }

        [Display(Name = "Nome")]
        public string usu_nome { get; set; }

        [Display(Name = "CPF")]
        public string usu_cpf { get; set; }

        [Display(Name = "RG")]
        public string usu_rg { get; set; }

        [Display(Name = "Endereço")]
        public string usu_endereco { get; set; }

        [Display(Name = "Cidade")]
        public string usu_cidade { get; set; }

        [Display(Name = "UF")]
        public string usu_estado { get; set; }

        [Display(Name = "Nascimento")]
        public DateTime usu_nascimento { get; set; }

        [Display(Name = "Telefone")]
        public string usu_telefone { get; set; }
    }
}
