using DropDowny.Models;
using System.Collections.Generic;

namespace DropDowny.CzlowiekFormViewModel
{
    public class CzlowiekFormViewModel
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wyksztalcenie { get; set; }
        public IEnumerable<Wyksztalcenie> Wyksztalcenies { get; set; }

        public int Zatrudnienie { get; set; }
        public IEnumerable<Zatrudnienie> Zatrudnienies { get; set; }

    }
}