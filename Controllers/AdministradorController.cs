using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Flotex.Data;
using Flotex.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using SQLitePCL;

namespace Flotex.Controllers
{
    public class AdministradorController : Controller
    {
        private readonly ILogger<AdministradorController> _logger;

        private readonly ApplicationDbContext _context;

        public AdministradorController(ILogger<AdministradorController> logger,ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registrar([Bind("NumeroDocumento","Nombre", "ApellidoPaterno" , "ApellidoMaterno" , "Telefono", "Email" , "Direccion" , "Genero", "FechaNacimiento")] Cliente  cliente){
            if( ModelState.IsValid){
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(cliente);
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}