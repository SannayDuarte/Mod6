using System.ComponentModel.DataAnnotations;

namespace RibeirinhoViagem.Model
{
    public class Destino
    {
        [Key]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "O campo destino deve entre 4 a 50 caracteres")]
        public string CidadeDestino { get; set; }

        [StringLength(50, MinimumLength = 4, ErrorMessage = "O campo origem deve entre 4 a 50 caracteres")]
        public string CidadeOrigem { get; set; }

        [StringLength(20, MinimumLength = 8, ErrorMessage = "O campo nome deve entre 8 a 20 caracteres")]
        public string DataViagem { get; set; }
    }
}
