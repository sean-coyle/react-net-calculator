using Calculator.Backend.Models;
using calculator_backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace Calculator.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private CalculatorService _calculatorService = new CalculatorService();

        [HttpPost]
        [Route("/api/add")]
        public ActionResult<double> Add([FromBody] CalculatorModel request)
        {
            var result = _calculatorService.Add(request.NumberOne, request.NumberTwo);
            return Ok(result);
        }

        [HttpPost]
        [Route("/api/subtract")]
        public ActionResult<double> Subtract([FromBody] CalculatorModel request)
        {
            var result = _calculatorService.Subtract(request.NumberOne, request.NumberTwo);
            return Ok(result);
        }

        [HttpPost]
        [Route("/api/divide")]
        public ActionResult<double> Divide([FromBody] CalculatorModel request)
        {
            try
            {
                var result = _calculatorService.Divide(request.NumberOne, request.NumberTwo);
                return Ok(result);
            }
            catch (Exception ex)
            {           
                return BadRequest(ex.Message);
            }
            
        }

        [HttpPost]
        [Route("/api/multiply")]
        public ActionResult<double> Multiply([FromBody] CalculatorModel request)
        {       
            var result = _calculatorService.Multiply(request.NumberOne, request.NumberTwo);
            return Ok(result);
        }
    }
}
