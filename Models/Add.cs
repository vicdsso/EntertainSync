using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EntertainSync.Models
{
    public class Add
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Titulo é obrigatório!", AllowEmptyStrings = false)]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Mínimo de 4 e máximo de 50 caracteres.")]
        public string Titulo { get; set; }

      
        public string Link { get; set; }



        public Add()
        {
            this.Id = 0;
            this.Titulo = string.Empty;
            this.Link = string.Empty;

        }
    }
}

