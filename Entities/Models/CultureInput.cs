using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class CultureInput
    {
        public Guid CultureId { get; set; }
        public Culture Culture { get; set; }

        public Guid InputId { get; set; }
        public Input Input { get; set; }
    }
}
