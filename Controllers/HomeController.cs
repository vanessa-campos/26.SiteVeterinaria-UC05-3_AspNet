using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Atividade03.Models;

namespace Atividade_03.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(){
            return View();
        }
        
        public IActionResult Servicos(){
            return View();
        }

        public IActionResult Agendamento(){
            return View();
        }

        public IActionResult Agendar(Agendar novo){
            BaseDados.Inlcuir(novo);
            List<Agendar> lista = BaseDados.Listar(); 
            return View(lista);
        } 
           
    }
}
