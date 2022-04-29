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
    public class PlanetConfiguration : IEntityTypeConfiguration<Planet>
    {
        public void Configure(EntityTypeBuilder<Planet> builder)
        {
            builder.HasData
            (
                new Planet { Id = new Guid("9fea1bd8-f221-4856-8b0b-a8945afd352f"), Name = "Synnax" },
                new Planet { Id = new Guid("88521e15-f778-4b17-b155-2386e30b1971"), Name = "Trantor" },
                new Planet { Id = new Guid("a8576e1b-d866-40a5-9820-45d31383748a"), Name = "Terminus"},
                new Planet { Id = new Guid("45f87d18-afb5-47c5-a2a3-166cdff67c5d"), Name = "Anacreon"},
                new Planet { Id = new Guid("9d56a7df-b544-4081-9139-94aa4816563b"), Name = "Smyrno"},
                new Planet { Id = new Guid("09ae2f6c-7c43-4a91-b6ab-75dfb68d7ab0"), Name = "Konom"},
                new Planet { Id = new Guid("2078939d-b339-482f-9b80-958466b4c94f"), Name = "Daribow"},
                new Planet { Id = new Guid("a62e90a9-f3a9-4e5a-aceb-fa342aa18a3c"), Name = "Askone"},
                new Planet { Id = new Guid("fbd5937c-8641-440c-a3d1-d85230a4f1c8"), Name = "Korell"},
                new Planet { Id = new Guid("cd56c939-c820-4140-903c-2e3ec1025e8f"), Name = "Siwenna"}
            );
        }
    }
}
