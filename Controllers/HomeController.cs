﻿using EntertainSync.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace EntertainSync.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EntertainSync.Repositories.ADO.SQLServer.HomeDAO repository;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            repository = new EntertainSync.Repositories.ADO.SQLServer.HomeDAO(configuration.GetConnectionString(EntertainSync.Configurations.Appsettings.getKeyConnectionString()));
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(repository.getAll());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(repository.getByIdAdicionar(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Home adicionar)
        {
            try
            {
                repository.update(id, adicionar);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Home publicacao)
        {
            try
            {
                repository.add(publicacao);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            repository.delete(id);
            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}