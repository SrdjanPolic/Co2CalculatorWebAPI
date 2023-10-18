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

        public decimal Co2EqPerKgCoefficient { get; set; }

        public decimal Co2KgPerHa { get; set; }

        public IList<CultureInput> CultureInputs { get; set; }

        public InputType InputType { get; set; }

        public Guid InputTypeId { get; set; }

        [NotMapped]
        public decimal NumberOfHa { get; set; }

        [NotMapped]
        public decimal KgOfInput { get; set; }
    }
}
