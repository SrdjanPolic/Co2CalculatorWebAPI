using AutoMapper;
using Business;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Co2CalculatorWebAPI.Controllers
{
    [Route("api/v1/Calculation")]
    [ApiController]
    public class CalculationController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IRepositoryManager _repository;
        private readonly ICo2CalculatorManager _co2CalculatorManager;

        public CalculationController(IMapper mapper, IRepositoryManager repository, ICo2CalculatorManager co2CalculatorManager)
        {
            _mapper = mapper;
            _repository = repository;
            _co2CalculatorManager = co2CalculatorManager;
        }

        [HttpGet("Test")]
        public virtual string Test()
        {
            return "Hello world";
        }

        [HttpGet("InputTypes")]
        public ActionResult<InputTypeDto[]> GetInputTypes()
        {
            var inputTypes = _repository.InputType.GetAllInputTypes(false);

            var inputTypesDto = _mapper.Map<IEnumerable<InputTypeDto>>(inputTypes);

            return Ok(inputTypesDto);
        }

        [HttpGet("Calculate")]
        public ActionResult<decimal> Calculate([FromBody] IEnumerable<InputDto> inputDtos)
        {
            var inputs = _mapper.Map<IEnumerable<Input>>(inputDtos);

            var result = _co2CalculatorManager.Calculate(inputs);

            return Ok(result);
        }

        [HttpGet("GetInputs/{id}")]
        public ActionResult<Input[]> GetInputsForInputTypeId(Guid id)
        {
            var inputs = _repository.Input.GetAllInputsForInputTypeId(false, id);

            var inputsDto = _mapper.Map<IEnumerable<InputDto>>(inputs);

            return Ok(inputsDto);
        }

    }
}
