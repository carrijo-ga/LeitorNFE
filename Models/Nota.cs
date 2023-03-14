using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace LeitorNfe.Models
{
    public partial class Nota
    {
        [Key]
        public int IDNota { get; set; }

        [Display(Name = "N° da Nota")]
        public int nNota { get; set; }

        [Display(Name = "Data de Emissão")]
        public string dEmissao { get; set; }

        //ForeignKey = Emitente
        [Display(Name = "Emitente")]
        [ForeignKey("IDEmitente")]
        public int IDEmitente { get; set; }

        //ForeignKey = Destinatario
        [Display(Name = "Destinatario")]
        [ForeignKey("IDDestinatario")]
        public int IDDestinatario { get; set; }

        [Display(Name = "N° do Pedido de Compra")]
        public int nPedidoCompra { get; set; }

        //ForeignKey = Produto
        [Display(Name = "Produto")]
        [ForeignKey("IDProduto")]
        public int IDProduto { get; set; }

        [Display(Name = "Código de Acesso")]
        public string cAcesso { get; set; }

        [Display(Name = "Comentário")]
        public string? comentario { get; set; }

        [Display(Name = "Total da Nota")]
        public int totalNota { get; set; }
    }
}
