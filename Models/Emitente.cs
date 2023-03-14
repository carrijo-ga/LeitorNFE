using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeitorNfe.Models
{
    public class Emitente
    {
        [Key]
        public int IDEmitente { get; set; }

        [Display(Name = "Nome")]
        public string nome { get; set; }

        //ForeignKey = Endereço
        [Display(Name = "Endereço")]
        [ForeignKey("IDEndereco")]
        public int IDEndereco { get; set; }

        [Display(Name = "CNPJ")]
        public int cnpj { get; set; }

        [Display(Name = "E-mail")]
        public string? email { get; set; }
    }
}
