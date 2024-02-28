using Microsoft.AspNetCore.Mvc;

namespace ProyectoServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ControladorJuego : ControllerBase
    {
        private string[] choices = { "Piedra", "Papel", "Tijeras" };
        private string[] resultado = { "Se debe elegir un valor", "Empate", "Jugador 1 gana la ronda!", "Jugador 2 gana la ronda!", "Información incorrecta" };
        [HttpPost]

        public ActionResult<string> Play(string p1, string p2)
        {
            if (!choices.Contains(p1) || !choices.Contains(p2))
                return resultado[4];

            if (p1 == null || p2 == null)
                return resultado[0];
            if (p1.Equals(p2))
                return resultado[1];

            if ((p1.Equals(choices[0]) && p2.Equals(choices[2])) ||
               (p1.Equals(choices[1]) && p2.Equals(choices[0])) ||
               (p1.Equals(choices[2]) && p2.Equals(choices[1])))
                return resultado[2];
            else
                return resultado[3];
        }
    }
}
