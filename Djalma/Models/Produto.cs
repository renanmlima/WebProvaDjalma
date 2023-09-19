using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Djalma.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "O campo {0} deve ser informado")]
        [Display(Name = "Nome do Produto")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} deve ser informado")]
        [Display(Name = "Descricao Produto")]
        public string Descricao { get; set;}

        [Required(ErrorMessage = "O campo {0} deve ser informado")]
        [Display(Name = "Preço do produto")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O {0} deve estar entre {1} e {2}")]
        public decimal Preco { get; set; }

        public int MarcaId { get; set; }
        public virtual Marca Marcas { get; set; }
    }
}
