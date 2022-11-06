using System.ComponentModel.DataAnnotations;

namespace RibeirinhoViagem.Model
{
    public class Passagem
    {
        [Key]
        public int Id_Pass { get; set; }
        [Required(ErrorMessage = "Id_Pass")]

        public int Valor { get; set; }
        [Required(ErrorMessage = "Aguarde o valor")]

        [StringLength(50, MinimumLength = 10, ErrorMessage = "O campo modo de viagem deve entre 10 a 50 caracteres")]
        public string ModoDeViagem { get; set; }

    }
}
