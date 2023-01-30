using Demo.Negocio;
using Microsoft.AspNetCore.Mvc;

namespace Demo.FMVC.Controllers
{
    public class CategoriasController : Controller
    {
        private readonly CategoriasNegocio _categoriasNegocio;

        public CategoriasController(CategoriasNegocio categoriasNegocio)
        {
            _categoriasNegocio = categoriasNegocio;
        }

        public IActionResult Index()
        {
            var listaCategorias = _categoriasNegocio.ObtenerCategorias();

            return View(listaCategorias);
        }
    }
}
