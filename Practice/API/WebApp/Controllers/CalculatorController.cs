using System.Net;
using System.Collections;
using Microsoft.AspNetCore.Mvc;
namespace WebApp.Controllers;

public class CalculatorController : ControllerBase
{
    [HttpGet("Add")]
    public double Sum(double a,double b){
        return a+b;
    }
}
