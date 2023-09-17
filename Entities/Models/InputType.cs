using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class InputType
    {
        public InputType()
        {
            Inputs = new HashSet<Input>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("InputTypeId")]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<Input> Inputs { get; set; }
    }
}
