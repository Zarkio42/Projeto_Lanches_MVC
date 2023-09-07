using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac_ProjMVC_Gauss.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage = "Informe o nome do lanche")]
        [StringLength(80, MinimumLength = 5, ErrorMessage = "O nome deve ter no mínimo 5 caracteres e no máximo 80.")]
        [Display(Name = "Nome do Lanche")]
        public string NameLanche { get; set; }

        [Required(ErrorMessage = "Informe a descrição curta do lanche")]
        [StringLength(200, MinimumLength = 15, ErrorMessage = "A descrição curta deve ter no mínimo 15 caracteres e no máximo 200.")]
        [Display(Name = "Descrição do Lanche")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "A descrição detalhada do lanche precisa ser informada")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "A descrição detalhada deve ter no mínimo 20 caracteres e no máximo 200.")]
        [Display(Name = "Descrição detalhada do lanche")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "O preço do lanche precisa ser informado")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999.99 reais")]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [StringLength(200, MinimumLength = 5, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        [Display(Name = "Caminho da sua imagem")]
        public string ImagemUrl { get; set; }

        [StringLength(200, MinimumLength = 5, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        [Display(Name = "Caminho da sua Miniatura")]
        public string ImagemTumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

    }
}
