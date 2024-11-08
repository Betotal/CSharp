using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesVSCode.Modelo
{
    public class Filme
    {
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 05)]
        [Required(ErrorMessage = "Preencha o nome do Filme")]
        public string Titulo { get; set; } = string.Empty;

        [Display(Name = "Data de Lançamento")]
        [Required(ErrorMessage = "Prrencha da Data de Lançamento do Filme")]
        [DataType(DataType.Date)]
        public DateTime dataLancto { get; set; }

        [
            Display(Name = "Gênero do filme"),
            StringLength(25, MinimumLength = 04),
            Required(ErrorMessage = "Preencha o gênero do Filme")
        ]
        public string Genero { get; set; } = string.Empty;

        [DataType(DataType.Currency)]
        [Column(TypeName =  "decimal(11,2)")]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [Display(Name = "Indicação etária do filme")]
        [Required(ErrorMessage = "0 para livre e limitado a 18")]
        [Range(0, 18)]
        public int Indicacao { get; set; } = 0;
    }
}