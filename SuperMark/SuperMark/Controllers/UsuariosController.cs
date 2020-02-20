
namespace SuperMark.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Helpers;

    public class UsuariosController : Controller
    {
        private readonly IUsuarioHelper userHelper;

        public UsuariosController(IUsuarioHelper userHelper)
        {
            this.userHelper = userHelper;
        }
        public async Task<IActionResult> Index()
        {
            return View(await this.userHelper.GetUsersAsync());
        }
    }
}