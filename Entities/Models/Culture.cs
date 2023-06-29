using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Culture
    {
        [Column("CultureId")]
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
