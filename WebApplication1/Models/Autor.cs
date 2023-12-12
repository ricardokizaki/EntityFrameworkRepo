using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Autor
    {
        public int AutorId { get; set; }
        [Display(Name = "Nome do Autor")]
        public string Nome { get; set; }
        [Display(Name = "Data de Nascimento")]
        public string DataNascimento { get; set; }
        public string Nacionalidade { get; set; }
        public virtual ICollection<Livro> Livros { get; set; }
    }
}
