using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GameClassification.MVC.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(250, ErrorMessage = "Máximo de {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        public string Nome { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal),"0","999999999999")]
        [Required(ErrorMessage ="Preencha Valor")]
        public string Valor { get; set; }

        [DisplayName("Disponível?")]
        public bool Disponivel { get; set; }
    }
}