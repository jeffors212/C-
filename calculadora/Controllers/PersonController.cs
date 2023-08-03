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
        

        return BadRequest("Invalid Input");
    }
    
  
   

    
}