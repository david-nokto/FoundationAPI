using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Core.Entities
{
    public class Planet
    {
        [Column("PlanetId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Planet name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximun length for the Planet name is 30 characters.")]
        public string? Name { get; set; }

        public ICollection<Character> Characters { get; set; } = new List<Character>();
    }
}
