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
    public class CultureConfiguration : IEntityTypeConfiguration<Culture>
    {
        public void Configure(EntityTypeBuilder<Culture> builder)
        {
            builder.HasData
            (
                new Culture
                {
                    Name = "Corn"
                },
                new Culture
                {
                    Name = "Wheat"
                },
                new Culture
                {
                    Name = "Ray"
                }
            );
        }

    }
}
