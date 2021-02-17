using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hora = DateTime.Now.Hour;

            ViewBag.Saludos = hora < 12 ? "Buenos Dias" : "Buenas tarde";

            return View("MyView");
        }

        //Si no tiene nada como firma se retorna la vista
        //Por Default con el mismo nombre del action method
        public ViewResult RsvpForm()
        {
            return View();
        }
    }
}
