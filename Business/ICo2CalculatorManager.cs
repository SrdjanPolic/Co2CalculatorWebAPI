using Entities.DataTransferObjects;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public interface ICo2CalculatorManager
    {
        decimal Calculate(IEnumerable<Input> inputs);
    }
}
