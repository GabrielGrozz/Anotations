using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anotations.Models
{
    [Table("Anotation")]
    public class Anotation

    {
        [Required]
        [Display(Name="AnotationId")]
        [StringLength(100, ErrorMessage ="o tamanho máximo de caracteres para o AnotationId é 100.")]
        public int AnotationId { get; set; }

        [Required(ErrorMessage ="O Campo nome precisa ser preenchido.")]
        [Display(Name ="AnotationName")]        
        [StringLength(25, MinimumLength =3, ErrorMessage ="O minimo de caracteres do nome é 3 e o máximo é de 25.")]
        public string Name { get; set; }

        [Required(ErrorMessage ="O Campo Conteúdo precisa ser preenchido.")]
        [Display(Name="Content")]
        [StringLength(800, MinimumLength =20, ErrorMessage ="o minimo de caracteres no conteúdo é de 20 e o maximo é de 800.")]
        public string Content { get; set; }
    }
}
