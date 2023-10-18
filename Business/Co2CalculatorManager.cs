using Entities.DataTransferObjects;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Co2CalculatorManager : ICo2CalculatorManager
    {
        public decimal Calculate(IEnumerable<Input> inputs)
        {
            decimal result = 0;

            foreach (Input input in inputs)
            {
                result += input.Co2EqPerKgCoefficient * input.KgOfInput +
                    input.Co2KgPerHa * input.NumberOfHa;
            }

            return result;
        }
    }
}
