using Foundation.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Data.Configuration
{
    public class CharacterConfiguration : IEntityTypeConfiguration<Character>
    {
        public void Configure(EntityTypeBuilder<Character> builder)
        {
            builder.HasData
            (
                new Character 
                { 
                    Id = Guid.NewGuid(),
                    Name = "Hari Seldon",
                    PlanetId = new Guid("88521e15-f778-4b17-b155-2386e30b1971"),
                },
                new Character
                {
                    Id = Guid.NewGuid(),
                    Name = "Gaal Dornick",
                    PlanetId = new Guid("9fea1bd8-f221-4856-8b0b-a8945afd352f"),
                },
                new Character
                {
                    Id = Guid.NewGuid(),
                    Name = "Anselm Haut Rodric",
                    PlanetId = new Guid("45f87d18-afb5-47c5-a2a3-166cdff67c5d"),
                }
            );
        }
    }
}
