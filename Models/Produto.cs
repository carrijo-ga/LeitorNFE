using System.ComponentModel.DataAnnotations;

namespace LeitorNfe.Models
{
    public class Produto
    {
        [Key]
        public int IDProduto { get; set; }

        [Display(Name = "N° do Item")]
        public int nItem { get; set; }

        [Display(Name = "Código do Produto")]
        public string cProduto { get; set; }

        [Display(Name = "Nome do Produto")]
        public string nProduto { get; set; }

        [Display(Name = "QTD Comprada")]
        public int qtdProduto { get; set; }

        [Display(Name = "Valor Unitário")]
        public int vUnitario { get; set; }

        [Display(Name = "Valor Total do Produto")]
        public int vTotalProduto { get; set; }
    }
}
