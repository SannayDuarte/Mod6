using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RibeirinhoViagem.Model
{
    public class Cliente
    {
        [Key]
        public int Id_cli { get; set; }
        [Required(ErrorMessage = "informe o nome")]

        [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo nome deve entre 3 a 50 caracteres")]
        public string Nome { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "O campo sobrenome deve entre 3 a 50 caracteres")]
        public string Sobrenome { get; set; }

        [StringLength(20, MinimumLength = 6, ErrorMessage = "O campo Rg deve entre 6 a 20 caracteres")]
        public string Rg { get; set; }

        [StringLength(11, MinimumLength = 11, ErrorMessage = "O campo Cpf deve entre 11 a 11 caracteres")]
        public string Cpf { get; set; }

        [StringLength(20, MinimumLength = 8, ErrorMessage = "O campo data de nascimento deve entre 8 a 20 caracteres")]
        public string DataNascimento { get; set; }

        [StringLength(11, MinimumLength = 11, ErrorMessage = "O campo Celular deve entre 11 a 11 caracteres")]
        public string Celular {get; set;}
        [StringLength(15, MinimumLength = 6, ErrorMessage = "O campo Sexualidade deve entre 1 a 15 caracteres")]
        public string Sexualidade {get; set;}

        [StringLength(15, MinimumLength = 8, ErrorMessage = "O campo Cep deve entre 8 a 15 caracteres")]
        public string Cep {get; set;}
        [StringLength(50, MinimumLength = 1, ErrorMessage = "O campo Estado deve entre 1 a 50 caracteres")]
        public string Estado {get; set;}
        [StringLength(50, MinimumLength = 1, ErrorMessage = "O campo Cidade deve entre 1 a 50 caracteres")]
        public string Cidade {get; set;}
        [StringLength(50, MinimumLength = 1, ErrorMessage = "O campo Bairro deve entre 1 a 50 caracteres")]
        public string Bairro {get; set;}
        [StringLength(50, MinimumLength = 1, ErrorMessage = "O campo Rua deve entre 1 a 50 caracteres")]
        public string Rua {get; set;}

        [StringLength(8, MinimumLength = 8, ErrorMessage = "O campo Senha deve entre 8 a 8 caracteres")]
        public string Senha { get; set; }

        [StringLength(40, MinimumLength = 1, ErrorMessage = "O campo Email deve entre 1 a 40 caracteres")]
        public string Email { get; set; }

    }
}
