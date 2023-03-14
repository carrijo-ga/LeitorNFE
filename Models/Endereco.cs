using System.ComponentModel.DataAnnotations;

namespace LeitorNfe.Models
{
    public class Endereco
    {
        [Key]
        public int IDEndereco { get; set; }

        [Display(Name ="Logadouro")]
        public string logadouro { get; set; }

        [Display(Name = "Numero")]
        public int numero { get; set; }

        [Display(Name = "Bairro")]
        public string bairro { get; set; }

        [Display(Name = "Munícipio")]
        public string municipio { get; set; }

        [Display(Name = "UF")]
        public string uf { get; set; }

        [Display(Name = "CEP")]
        public int cep { get; set; }
    }
}
