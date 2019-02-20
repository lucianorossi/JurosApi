using Juros.Servico.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Juros.WebApi.Controllers
{
    [ApiController]
    public class JurosController : ControllerBase
    {
        private readonly IJurosServico jurosServico;

        public JurosController(IJurosServico jurosServico) =>
            this.jurosServico = jurosServico;

        // GET /calculajuros
        [HttpGet]
        [Route("calculajuros")]
        public ActionResult<string> Get(decimal valorInicial, int meses) =>
            jurosServico.CalculaJurosCompostos(valorInicial, meses).ToString("F2");
    }
}
