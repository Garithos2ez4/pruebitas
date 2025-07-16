using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using pruebitas.Data;
using pruebitas.Models;

namespace pruebitas.Controllers
{
    public class TrabajadorController : Controller
    {
        private readonly TrabajadorRepository _repo;

        public TrabajadorController(TrabajadorRepository repo)
        {
            _repo = repo;
        }

        public async Task<IActionResult> Index(string sexoFiltro = "")
        {
            var trabajadores = await _repo.Listar();

            if (!string.IsNullOrEmpty(sexoFiltro))
            {
                trabajadores = trabajadores.Where(t => t.Sexo == sexoFiltro).ToList();
            }
            await CargarCombos();
            return View(trabajadores);
        }

        [HttpPost]
        public async Task<IActionResult> Crear(Trabajador t)
        {
            if (ModelState.IsValid)
            {
                await _repo.Insertar(t);
                return RedirectToAction("Index");
            }

            return View("Index", await _repo.Listar());
        }

        [HttpPost]
        public async Task<IActionResult> Editar(Trabajador t)
        {
            if (ModelState.IsValid)
            {
                await _repo.Actualizar(t);
                return RedirectToAction("Index");
            }

            return View("Index", await _repo.Listar());
        }

        [HttpPost]
        public async Task<IActionResult> Eliminar(int id)
        {
            await _repo.Eliminar(id);
            return RedirectToAction("Index");
        }
        private async Task CargarCombos()
        {
            ViewBag.Departamentos = new SelectList(await _repo.ListarDepartamentos(), "Id", "NombreDepartamento");
            ViewBag.Provincias = new SelectList(await _repo.ListarProvincias(), "Id", "NombreProvincia");
            ViewBag.Distritos = new SelectList(await _repo.ListarDistritos(), "Id", "NombreDistrito");
        }

    }

}
