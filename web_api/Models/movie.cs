using System.ComponentModel.DataAnnotations;

namespace web_api.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O título é obrigatório")]
        public string Title { get; set; }
        [Required(ErrorMessage = "O diretor é obrigatório")]
        public string Director { get; set; }
        [Required(ErrorMessage = "O gênero é obrigatório")]
        public string Genre { get; set; }
        [Range(30,600, ErrorMessage = "Duração deve estar entre 30 e 600 minutos")]
        public int Duration { get; set; }
    }
}
