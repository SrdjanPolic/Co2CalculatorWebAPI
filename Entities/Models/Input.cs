using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Input
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("InputId")]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public decimal Co2EqPerKgAppliance { get; set; }

        public decimal Co2EqPerKgProduction { get; set; }

        public decimal Co2EqPerUnit { get; set; }

        public IList<CultureInput> CultureInputs { get; set; }

        public InputType InputType { get; set; }

        public Guid InputTypeId { get; set; }
    }
}
