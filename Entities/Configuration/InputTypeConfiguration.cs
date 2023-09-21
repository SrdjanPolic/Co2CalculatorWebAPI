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
    public class InputTypeConfiguration : IEntityTypeConfiguration<InputType>
    {
        public void Configure(EntityTypeBuilder<InputType> builder)
        {
            builder.HasData
           (
               new InputType
               {
                   Id = Guid.NewGuid(),
                   Name = "Soil"
               },
               new InputType
               {
                   Id = Guid.NewGuid(),
                   Name = "Fuel"
               },
               new InputType
               {
                   Id = Guid.NewGuid(),
                   Name = "Pesticide"
               },
               new InputType
               {
                   Id = Guid.NewGuid(),
                   Name = "Fertilizer"
               }
           );
        }
    }
}
