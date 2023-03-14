using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LeitorNfe.Models
{
    public class Destinatario
    {
        [Key]
        public int IDDestinatario { get; set; }

        [Display(Name = "Nome")]
        public string nome { get; set; }

        //ForeignKey = Endereço
        [Display(Name = "Endereço")]
        [ForeignKey("IDEndereco")]
        public int IDEndereco { get; set; }

        [Display(Name = "CNPJ")]
        public int cnpj { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }
    }
}
