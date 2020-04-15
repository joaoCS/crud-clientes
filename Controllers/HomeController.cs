using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using asp19.Models;


namespace asp19.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListaClientes()
        {
            return View(Dados.TodosOsClientes());
        }

        public IActionResult AdicionarClientes()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdicionarClientes(Cliente cliente)
        {
            Dados.AdicionarCliente(cliente);
            return RedirectToAction("AdicionarClientes");
        }

        public IActionResult EditarCliente(int id)
        { 
            return View(Dados.DadosCliente(id));
        }

        [HttpPost]
        public IActionResult EditarCliente(Cliente c)
        {
            Dados.EditarCliente(c);
            return RedirectToAction("ListaClientes") ;
        }

        public IActionResult EliminarCliente(int id)
        {
            Dados.EliminarCliente(id);

            return RedirectToAction("ListaClientes");
        }
    }
}