using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DataTransferObjects
{
    public class InputDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid InputTypeId { get; set; }

        public decimal NumberOfHa { get; set; }

        public decimal KgOfInput { get; set; }

    }
}
