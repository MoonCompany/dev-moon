﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AplicacionASPCore.Models;

namespace AplicacionASPCore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var hora = DateTime.Now.Hour;
            ViewBag.Hora = hora < 12 ? "Good Morning" : "Good Afternoon";
            return View("MyView");
        }

        [HttpGet]
        public ViewResult Rsvp()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Rsvp(RespuestaInvitado respuestaInvitado)
        {
<<<<<<< HEAD

            Repository.AddResponse(respuestaInvitado);
=======
            if (ModelState.IsValid){
                Repository.AddResponse(respuestaInvitado);
>>>>>>> 9a93fd941e050adc2152796335b8c81711a95605

                return View("SubmitComplete", respuestaInvitado);
            } else
            {
                return View();
            }
        }

        [HttpGet]
        public ViewResult ListaInvitados()
        {

            return View(Repository.Responses.Where(x => x.Asistira == true));
        }
    }
}
