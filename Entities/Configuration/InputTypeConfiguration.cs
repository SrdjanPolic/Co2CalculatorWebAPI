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
                   Id = new Guid("72574EA7-47C4-4248-9A49-DDE040AC47C1"),
                   Name = "Soil"
               },
               new InputType
               {
                   Id = new Guid("B9DC67B4-DF69-41FE-B06B-3294A939A0E0"),
                   Name = "Fuel"
               },
               new InputType
               {
                   Id = new Guid("9B572FC7-4E71-400B-B66E-528B5DC90106"),
                   Name = "Pesticide"
               },
               new InputType
               {
                   Id = new Guid("242E5514-CE39-4647-AD4D-A81516BE7DEF"),
                   Name = "Fertilizer"
               }
           );
        }
    }
}
