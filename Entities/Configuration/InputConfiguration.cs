using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Configuration
{
    public class InputConfiguration : IEntityTypeConfiguration<Input>
    {
        public void Configure(EntityTypeBuilder<Input> builder)
        {

            builder.HasData
            (
                new Input
                {
                    Id = Guid.NewGuid(),
                    Name = "NitrogenFertilizer",
                    Co2EqPerKgCoefficient = 9.78m,
                    InputTypeId = new Guid("4d80714f-8bda-4e8b-82cd-af9c5be709ec")
                },
                 new Input
                 {
                     Id = Guid.NewGuid(),
                     Name = "Urea",
                     Co2EqPerKgCoefficient = 0.73m,
                     InputTypeId = new Guid("4d80714f-8bda-4e8b-82cd-af9c5be709ec")
                 },
                 new Input
                 {
                     Id = Guid.NewGuid(),
                     Name = "KaliumFertilizer",
                     Co2EqPerKgCoefficient = 0.16m,
                     InputTypeId = new Guid("4d80714f-8bda-4e8b-82cd-af9c5be709ec")
                 },
                 new Input
                 {
                     Id = Guid.NewGuid(),
                     Name = "PhosphorusFertilizer",
                     Co2EqPerKgCoefficient = 4.5m,
                     InputTypeId = new Guid("4d80714f-8bda-4e8b-82cd-af9c5be709ec")
                 }
            );
        }
    }
}
