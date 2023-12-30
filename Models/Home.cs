using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntertainSync.Models
{
    [Table("Adicionar")]
    public class Home
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Título é obrigatório!", AllowEmptyStrings = false)]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Mínimo de 3 e máximo de 100 caracteres.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Campo link é obrigatório!", AllowEmptyStrings = false)]
        [StringLength(100, ErrorMessage = "Máximo de 100 caracteres.")]
        public string Link { get; set; }

        [Required(ErrorMessage = "Campo link é obrigatório!", AllowEmptyStrings = false)]
        public string LinkImagem { get; set; }

        
        [Required(ErrorMessage = "Campo Categoria é obrigatório!", AllowEmptyStrings = false)]
        public string Category { get; set; }

        public Home()
        {
            this.Id = 0;
            this.Titulo = string.Empty;
            this.Link = string.Empty;
            this.LinkImagem = string.Empty;
            this.Category = string.Empty;
        }
    }
}
