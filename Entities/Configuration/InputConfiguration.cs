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
                    InputTypeId = new Guid("242E5514-CE39-4647-AD4D-A81516BE7DEF")
                },
                 new Input
                 {
                     Id = Guid.NewGuid(),
                     Name = "Urea",
                     Co2EqPerKgCoefficient = 0.73m,
                     InputTypeId = new Guid("242E5514-CE39-4647-AD4D-A81516BE7DEF")
                 },
                 new Input
                 {
                     Id = Guid.NewGuid(),
                     Name = "KaliumFertilizer",
                     Co2EqPerKgCoefficient = 0.16m,
                     InputTypeId = new Guid("242E5514-CE39-4647-AD4D-A81516BE7DEF")
                 },
                 new Input
                 {
                     Id = Guid.NewGuid(),
                     Name = "PhosphorusFertilizer",
                     Co2EqPerKgCoefficient = 4.5m,
                     InputTypeId = new Guid("242E5514-CE39-4647-AD4D-A81516BE7DEF")
                 },
                 new Input
                 {
                     Id = Guid.NewGuid(),
                     Name = "Soil1",
                     Co2KgPerHa = 4000m,
                     InputTypeId = new Guid("72574EA7-47C4-4248-9A49-DDE040AC47C1")
                 }

            );
        }
    }
}
