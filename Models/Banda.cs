using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MusicZone2.Models
{
    public class Banda
    {
        [Required(ErrorMessage = "Digitar o nome da banda.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digitar o número de elementos da banda.")]
        public int? Elementos { get; set; }

        public string Genero { get; set; }

        public bool TOP { get; set; }

    }
}
