using Microsoft.AspNetCore.Mvc;
using demomvc.Models;
using demomvc.Data;
using System.Linq;


namespace demomvc.Controllers
{
    public class ProductoController:Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductoController(ApplicationDbContext context)
        {
            _context = context;
        }

    public IActionResult Index()
    {
        return View();
    }

     public IActionResult Create( Producto objProducto)
    {
       _context.Add(objProducto);
       _context.SaveChanges();
       ViewData["Message"] = "Producto registrado satisfactoriamente";
       return View("Index");
    }

  

    
       
    }

}