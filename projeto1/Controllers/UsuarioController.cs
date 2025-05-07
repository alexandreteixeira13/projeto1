using Microsoft.AspNetCore.Mvc;
using projeto1.Repositorio;

namespace projeto1.Controllers
{
    public class UsuarioController : Controller
    {

        //criando variavel privada somente para leitura do tipo UsuarioRepositiorio chamada _usuarioRepositorio

        private readonly UsuarioRepositorio _usuarioRepositorio;


        /* definindo o construtor da classe UsuarioController  que vai receber uma instancia de usuarioRepositorio */

        public UsuarioController(UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }


        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Contato() 
        { 
            return View();
        }
    }
}
