using System.ComponentModel.DataAnnotations;

namespace SGBr.Application.DTOs
{
    public class ClientCreateDTO
    {
        [Required(ErrorMessage = "É necessário informar um nome.")]
        [MinLength(3, ErrorMessage = "O nome deve ter no mínimo 4 caracteres.")]
        [MaxLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres.")]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage = "E-mail inválido")]
        public string Email { get; set; }

    }
}
