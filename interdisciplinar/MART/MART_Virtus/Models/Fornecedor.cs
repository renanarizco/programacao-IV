using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MART_Virtus.Models
{
    public class Fornecedor
    {
        [Key]
        [ScaffoldColumn(false)]
        public int fornecedor_id { get; set; }

        [Display(Name = "Nome Fantasia")]
        public string fornecedor_nomefantasia { get; set; }

        [Display(Name = "CNPJ")]
        public string fornecedor_cnpj { get; set; }

        [Display(Name = "Rua")]
        public string fornecedor_rua { get; set; }

        [Display(Name = "Número")]
        public string fornecedor_numero { get; set; }

        [Display(Name = "Bairro")]
        public string fornecedor_bairro { get; set; }

        [Display(Name = "Cidade")]
        public string fornecedor_cidade { get; set; }

        [Display(Name = "UF")]
        public string fornecedor_uf { get; set; }

        [Display(Name = "E-mail")]
        public string fornecedor_email { get; set; }

        [Display(Name = "Telefone")]
        public string fornecedor_telefone { get; set; }
    }
}
