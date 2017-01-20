using System;
using System.ComponentModel.DataAnnotations;

namespace CadastroCaelum.Data
{
    public class Curso
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }      
    }
}
