using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicadocMais.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ConsultasController : ControllerBase
    {
        [Route("[controller]")]
        [ApiController]
        public class ConsultaController : ControllerBase
        {
            [HttpGet("atendidosHoje")]
            public List<string> pacientesAtendidosHoje()
            {
                List<string> pacientesAtendidosHoje = new List<string>();
                pacientesAtendidosHoje = ["Giovanni", "Ricardo", "Sergio"];
                return pacientesAtendidosHoje;
            }
        }
    }
}
