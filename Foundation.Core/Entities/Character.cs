using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Core.Entities
{
    public class Character
    {
        [Column("CharacterId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Character name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximun length for the Character name is 30 characters.")]
        public string? Name { get; set; }

        //Faction/Organization?
        //Character can belong to several planets?
        //Title?

        [ForeignKey(nameof(Planet))]
        public Guid PlanetId { get; set; }
        public Planet? Planet { get; set; }

    }
}
