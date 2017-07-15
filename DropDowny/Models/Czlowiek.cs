using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DropDowny.Models
{
    public class Czlowiek
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public Wyksztalcenie Wyksztalcenie { get; set; }
        //TODO: TO delte?
        public IEnumerable<Wyksztalcenie> Wyszktalcenies { get; set; }
        public Zatrudnienie Zatrudnienie { get; set; }
        //TODO: TO delte?
        public IEnumerable<Zatrudnienie> Zatrudnienies { get; set; }
    }
}