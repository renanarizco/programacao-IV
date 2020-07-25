using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MART_Virtus.Models
{
    public class Produto
    {
        [Key]
        [ScaffoldColumn(false)]
        public int produto_id { get; set; }

        [Display(Name = "Descrição")]
        public string produto_descricao { get; set; }

        [Display(Name = "Marca")]
        public string produto_marca { get; set; }

        [Display(Name = "Código de Barras")]
        public string produto_codbarras { get; set; }

        [Display(Name = "Preço de custo")]
        public decimal produto_precocusto { get; set; }

        [Display(Name = "Preço de venda")]
        public decimal produto_precovenda { get; set; }

        [Display(Name = "Estoque")]
        public int produto_estoque { get; set; }

    }
}
