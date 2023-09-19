using System.ComponentModel.DataAnnotations;

namespace Djalma.Models
{
    public class Marca
    {
        public int MarcaId { get; set; }

        [Required(ErrorMessage = "O campo {0} deve ser informado")]
        [Display(Name = "Nome da Marca")]
        public string Nome { get; set; }

        [Display(Name = "País da Marca")]
        public string Pais { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
