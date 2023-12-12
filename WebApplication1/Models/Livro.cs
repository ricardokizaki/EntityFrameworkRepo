using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Livro
    {
        public int LivroId { get; set; }
        [Display(Name = "Título do Livro")]
        public string Título { get; set; }
        [Display(Name = "Ano de Publicação")]
        public int AnoPublicacao { get; set; }
        [Display(Name = "Gênero")]
        public string Genero { get; set; }
        public int AutorId { get; set; }
        public virtual Autor Autor { get; set; }
    }
}
