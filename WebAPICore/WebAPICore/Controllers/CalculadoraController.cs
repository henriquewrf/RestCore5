using Microsoft.AspNetCore.Mvc;
using System;

namespace WebAPICore.Controllers
{
    [ApiController]
    [Route("controller")]
    public class CalculadoraController : Controller
    {
        [HttpGet("soma/{val1}/{val2}")]
        public IActionResult soma(decimal val1, decimal val2)
        {
            if(IsNumeric(val1.ToString()) && IsNumeric(val2.ToString()))
            {
                var calculo = val1 + val2;
                return Ok($"A soma de {val1} + {val2} = {calculo}");
            }

            return BadRequest("Input Inválido");
        }

        [HttpGet("subtracao/{val1}/{val2}")]
        public IActionResult subtracao(decimal val1, decimal val2)
        {
            if (IsNumeric(val1.ToString()) && IsNumeric(val2.ToString()))
            {
                var calculo = val1 - val2;
                return Ok($"A subtração de {val1} - {val2} = {calculo}");
            }

            return BadRequest("Input Inválido");
        }

        [HttpGet("multiplicacao/{val1}/{val2}")]
        public IActionResult multiplicacao(decimal val1, decimal val2)
        {
            if (IsNumeric(val1.ToString()) && IsNumeric(val2.ToString()))
            {
                var calculo = val1 * val2;
                return Ok($"A multiplicação de {val1} * {val2} = {calculo}");
            }

            return BadRequest("Input Inválido");
        }

        [HttpGet("divisao/{val1}/{val2}")]
        public IActionResult divisao(decimal val1, decimal val2)
        {
            if (IsNumeric(val1.ToString()) && IsNumeric(val2.ToString()))
            {
                var calculo = val1 / val2;
                return Ok($"A divisão de {val1} / {val2} = {calculo}");
            }

            return BadRequest("Input Inválido");
        }

        [HttpGet("media/{val1}/{val2}")]
        public IActionResult media(decimal val1, decimal val2)
        {
            if (IsNumeric(val1.ToString()) && IsNumeric(val2.ToString()))
            {
                var calculo = (val1 + val2) / 2;
                return Ok($"A média de {val1} e {val2} = {calculo}");
            }

            return BadRequest("Input Inválido");
        }

        [HttpGet("raiz/{val1}")]
        public IActionResult raiz(decimal val1)
        {
            if (IsNumeric(val1.ToString()))
            {
                var calculo = Convert.ToSingle(Math.Sqrt((double)val1));
                return Ok($"A raiz de {val1} é {calculo}");
            }

            return BadRequest("Input Inválido");
        }

        private bool IsNumeric(string val)
        {
            return double.TryParse(val, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out double number);
           
        }
    }
}
