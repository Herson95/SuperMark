using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SuperMark.Data;
using SuperMark.Data.Entities;

namespace SuperMark.Controllers
{
    public class ProductosController : Controller
    {
        private readonly IProductosRepository productosRepository;
        private readonly ICategoriasRepository categoriasRepository;
        private readonly IMarcasRepository marcasRepository;

        public ProductosController(IProductosRepository productosRepository, ICategoriasRepository categoriasRepository, IMarcasRepository marcasRepository)
        {
            this.productosRepository = productosRepository;
            this.categoriasRepository = categoriasRepository;
            this.marcasRepository = marcasRepository;
        }

        // GET: Productos
        public async Task<IActionResult> Index()
        {
            return View(await productosRepository.GetAllProducts());
        }

        // GET: Productos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblProducto = await this.productosRepository.GetByIdAsync(id.Value);
            if (tblProducto == null)
            {
                return NotFound();
            }

            return View(tblProducto);
        }

        // GET: Productos/Create
        public IActionResult Create()
        {
            ViewBag.Categorias = new SelectList(this.categoriasRepository.GetAll().ToList(), "IdCategoria", "Nombre");
            ViewBag.Marcas = new SelectList(this.marcasRepository.GetAll().ToList(), "IdMarca", "Nombre");
            return View();
        }

 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TblProducto tblProducto)
        {
            if (ModelState.IsValid)
            {
                await this.productosRepository.CreateAsync(tblProducto);
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Categorias = new SelectList(this.categoriasRepository.GetAll().ToList(), "IdCategoria", "Nombre", tblProducto.IdCategoria);
            ViewBag.Marcas = new SelectList(this.marcasRepository.GetAll().ToList(), "IdMarca", "Nombre", tblProducto.IdCategoria);
            return View(tblProducto);
        }

        // GET: Productos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblProducto = await this.productosRepository.GetByIdAsync(id.Value);
            if (tblProducto == null)
            {
                return NotFound();
            }
            ViewBag.Categorias = new SelectList(this.categoriasRepository.GetAll().ToList(), "IdCategoria", "Nombre", tblProducto.IdCategoria);
            ViewBag.Marcas = new SelectList(this.marcasRepository.GetAll().ToList(), "IdMarca", "Nombre", tblProducto.IdMarca);

            return View(tblProducto);
        }

        // POST: Productos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, TblProducto tblProducto)
        {
            if (id != tblProducto.IdProducto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await this.productosRepository.UpdateAsync(tblProducto);
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (! await this.productosRepository.ExistAsync(tblProducto.IdProducto))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Categorias = new SelectList(this.categoriasRepository.GetAll().ToList(), "IdCategoria", "Nombre", tblProducto.IdCategoria);
            ViewBag.Marcas = new SelectList(this.marcasRepository.GetAll().ToList(), "IdMarca", "Nombre", tblProducto.IdMarca);
            
            return View(tblProducto);
        }

        // GET: Productos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblProducto = await this.productosRepository.GetByIdAsync(id.Value);
            if (tblProducto == null)
            {
                return NotFound();
            }

            return View(tblProducto);
        }

        // POST: Productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblProducto = await this.productosRepository.GetByIdAsync(id);
            await this.productosRepository.DeleteAsync(tblProducto);
           
            return RedirectToAction(nameof(Index));
        }

 
    }
}
