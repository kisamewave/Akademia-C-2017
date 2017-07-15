using DropDowny.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropDowny.Controllers
{
    public class CzlowiekController : Controller
    {
        private ApplicationDbContext _context;

        public CzlowiekController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Czlowiek

        public ActionResult Index()
        {
            var viewModel = new CzlowiekFormViewModel.CzlowiekFormViewModel
            {
                Wyksztalcenies = _context.Wyksztalcenies.ToList(),
                Zatrudnienies = _context.Zatrudnienies.ToList()

            };


            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Index(CzlowiekFormViewModel.CzlowiekFormViewModel viewModel)
        {
            var wyksztalcenie = _context.Wyksztalcenies.Single(w => w.Id == viewModel.Wyksztalcenie);
            var zatrudnienie = _context.Zatrudnienies.Single(w => w.Id == viewModel.Zatrudnienie);

            var czlowiek = new Czlowiek
            {
                Imie = viewModel.Imie,
                Nazwisko = viewModel.Nazwisko,
                Wyksztalcenie = wyksztalcenie,
                Zatrudnienie = zatrudnienie

            };

            _context.Czlowieks.Add(czlowiek);
            _context.SaveChanges();

            string temp = "";
            return RedirectToAction("Wyswietl", czlowiek);
        }


        public ActionResult Wyswietl(Czlowiek czlowiek)
        {
            //int id = int.Parse(liczba);
            //ApplicationDbContext context = new ApplicationDbContext();
            //context.Configuration.LazyLoadingEnabled = true;
            //Czlowiek lastCzlowiek = context.Czlowieks.FirstOrDefault();

            return View(czlowiek);
        }
        //public ActionResult ZwrocWidok()
        //{
        //    var app = _context.Czlowieks.ToList();
        //    var vmCzlowiek = new List<Czlowiek>();

        //    var lista = _context.Czlowieks.OrderBy(m => m.Wyksztalcenie.Id).ToList();
        //    ViewBag.Dane = lista;

        //    return View();
        //}

    }
}