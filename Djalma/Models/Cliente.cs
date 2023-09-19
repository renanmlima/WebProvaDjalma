using System.ComponentModel.DataAnnotations;

namespace Djalma.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "O campo {0} deve ser informado")]
        [Display(Name = "Nome do Cliente")]
        public string Nome { get; set; }

        [Display(Name = "Telefone do Cliente")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O campo {0} deve ser informado")]
        [Display(Name = "Email Cliente")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} deve ser informado")]
        [MaxLength(16, ErrorMessage = "Maximo de caracteres ultrapassado")]
        [Display(Name = "CNPJ/CPF")]
        public string CpfCnpj { get; set; }

        public int VendedorId { get; set; }
        public virtual Vendedor Vendedores { get; set; }
    }
}
