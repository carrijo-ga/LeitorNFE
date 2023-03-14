using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace LeitorNfe.Models
{
    [Serializable]
    [XmlRoot("Nota")]
    public class NotaImportMetaData
    {
        [XmlElement("nNF")]
        public int nNota { get; set; }

        [XmlElement("dhEmi")]
        public string dEmissao { get; set; }

        [XmlElement("chNFe")]
        public string cAcesso { get; set; }

        [XmlElement("vNF")]
        public int totalNota { get; set; }

        [XmlElement("xLgr")]
        public string logadouro { get; set; }

        [XmlElement("nro")]
        public int numero { get; set; }

        [XmlElement("xBairro")]
        public string bairro { get; set; }

        [XmlElement("xMun")]
        public string municipio { get; set; }

        [XmlElement("UF")]
        public string uf { get; set; }

        [XmlElement("CEP")]
        public int cep { get; set; }

        //Emitente

        [XmlElement("xNome")]
        public string nome { get; set; }

        [XmlElement("CNPJ")]
        public int cnpj { get; set; }

        [XmlElement("email")]
        public string? email { get; set; }

        //Destinatario

        [XmlElement("xNome")]
        public string nomeDest { get; set; }

        [XmlElement("CNPJ")]
        public int cnpjDest { get; set; }

        [XmlElement("email")]
        public string emailDest { get; set; }
    }

    [MetadataType(typeof(NotaImportMetaData))]
    public partial class Nota
    {

    }
}
