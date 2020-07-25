using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MART_Virtus.Models
{
    public class Cliente
    {
        [Key]
        [ScaffoldColumn(false)]
        public int cliente_id { get; set; }

        [Display(Name = "Nome")]
        public string cliente_nome { get; set; }

        [Display(Name = "Pessoa")]
        public string cliente_tipo { get; set; }

        [Display(Name = "RG")]
        public string cliente_rg { get; set; }

        [Display(Name = "CPF/CNPJ")]
        public string cliente_cnpj { get; set; }

        [Display(Name = "Logradouro")]
        public string cliente_logradouro { get; set; }

        [Display(Name = "Rua")]
        public string cliente_rua { get; set; }

        [Display(Name = "Número")]
        public string cliente_numero { get; set; }

        [Display(Name = "Bairro")]
        public string cliente_bairro { get; set; }

        [Display(Name = "Complemento")]
        public string cliente_complemento { get; set; }

        [Display(Name = "CEP")]
        public string cliente_cep { get; set; }

        [Display(Name = "E-mail")]
        public string cliente_email { get; set; }

        [Display(Name = "Tel/Cel")]
        public string cliente_telefone { get; set; }
    }
}
