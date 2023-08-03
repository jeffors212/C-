using Microsoft.AspNetCore.Mvc;

namespace calculadora.Controllers;

[ApiController]
[Route("[controller]")]
public class CalculatorController : ControllerBase
{
  
    private readonly ILogger<CalculatorController> _logger;

    public CalculatorController(ILogger<CalculatorController> logger)
    {
        _logger = logger;
    }

    [HttpGet("sum/{fistNumber}/{secondNumber}")]
    public IActionResult Sum(string fistNumber, string secondNumber )
    {
        if (IsNumeric(fistNumber) && IsNumeric(secondNumber))
        {
            var sum = ConvertToDecimal(fistNumber) +  ConvertToDecimal(secondNumber);
            return Ok(sum.ToString());
        }

        return BadRequest("Invalid Input");
    }
    
    [HttpGet("subtraction/{fistNumber}/{secondNumber}")]
    public IActionResult Subtraction(string fistNumber, string secondNumber )
    {
        if (IsNumeric(fistNumber) && IsNumeric(secondNumber))
        {
            var sum = ConvertToDecimal(fistNumber) - ConvertToDecimal(secondNumber);
            return Ok(sum.ToString());
        }

        return BadRequest("Invalid Input");
    }
    private bool IsNumeric(string strNumber)
    {
        double number;
         bool IsNumber = double.TryParse(strNumber,System.Globalization.NumberStyles.Any, 
             System.Globalization.NumberFormatInfo.InvariantInfo, out number);
        return IsNumber;
    }

   

    private decimal ConvertToDecimal(string strNumber)
    {
        decimal decimalValue;
        if (decimal.TryParse(strNumber, out decimalValue))
        {
            return decimalValue;
        }
        return 0;
    }

    
}