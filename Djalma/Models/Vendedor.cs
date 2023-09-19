using System.ComponentModel.DataAnnotations;

namespace Djalma.Models
{
    public class Vendedor
    {
        public int VendedorId { get; set; }

        [Required(ErrorMessage = "O campo {0} deve ser informado")]
        [Display(Name = "Nome do Vendedor")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} deve ser informado")]
        [Display(Name = "Email Vendedor")]
        public string Email { get; set; }
        public List<Cliente> Clientes { get; set; }
    }
}
