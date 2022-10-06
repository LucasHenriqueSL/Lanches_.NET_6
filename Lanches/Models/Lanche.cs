using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lanches.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }
        [Required(ErrorMessage ="O nome do lanche deve ser informado")]
        [Display(Name ="Nome do Lanche")]
        [StringLength(80, MinimumLength =10,ErrorMessage ="O {0} deve ter no mínimo {1} e no máximo {2}")]

        public string Nome { get; set; }
        [Required(ErrorMessage = "O nome do lanche deve ser informado")]
        [Display(Name = "Nome do Lanche")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1}")]
        [MaxLength(200, ErrorMessage = "Descrição pode exceder {1} caracteres")]

        public string DescricaoCurta { get; set; }
        public string DescricaoDetalhada { get; set; }
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
        public string ImagemThumbnailUrl { get; set; }
        public bool IsLanchePreferido { get; set; }
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}

