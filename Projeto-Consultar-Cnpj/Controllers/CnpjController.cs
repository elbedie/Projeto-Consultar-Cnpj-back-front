﻿using Microsoft.AspNetCore.Mvc;
using Projeto_Consultar_Cnpj.Services;

namespace Projeto_Consultar_Cnpj.Controllers
{
    public class CnpjController : Controller
    {  
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Consultar(string cnpj)
        {
            if (string.IsNullOrEmpty(cnpj))
            {
                ViewBag.ErrorMessage = "Por favor, insira um CNPJ válido.";
                return View("Index");
            }

            var consulta = await CnpjConsultaService.ConsultarCnpj(cnpj);

            if (consulta != null)
            {
                CnpjConsultaStorage.AdicionarConsulta(consulta);
                return View("Resultado", consulta);
            }

            ViewBag.ErrorMessage = "CNPJ não encontrado ou erro na consulta.";
            return View("Index");
        }

        public IActionResult ConsultasRealizadas()
        {
            var consultas = CnpjConsultaStorage.ObterConsultas();
            return View(consultas);
        }

    }
}
