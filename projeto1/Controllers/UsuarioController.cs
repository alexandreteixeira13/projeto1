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

        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            /* chama o método obterusuario do _usuarioRepositorio, passando o email fornecido pelo usuario
             * isso buscara o usuario no banco de dados com o email correspondente */

            var usuario = _usuarioRepositorio.ObterUsuario(email);

            //verifica se o usuario encontrado for diferente de vazio e se a senha
            //corresponde a senha fornecida

            if (usuario != null && usuario.Senha == senha)
            {

                return RedirectToAction("Index", "Cliente");
            }

            //se a autenticação falahar, adiciona o erro ao ModelState, ele armazena
            //o estado do modelo e erros de validação

            ModelState.AddModelError("", "Email ou senha inválidos");
            return View();
        }

        public IActionResult Contato() 
        { 
            return View();
        }
    }
}
