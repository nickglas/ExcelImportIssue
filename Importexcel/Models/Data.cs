using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Importexcel.Models
{
    public class Data
    {
        public int id { get; set; }
        public string Gereed { get; set; }
        public Double Project_Code { get; set; }
        public Double Organisatie_Code { get; set; }
        public Double Input_Bron { get; set; }
        public Double AardId { get; set; }
        public string Categorie { get; set; }
        public string Actiehouder { get; set; }
        public string Prioriteit { get; set; }
        public string Kenmerk { get; set; }
        public string Issues { get; set; }
        public string Antwoord { get; set; }
        public string Opmerking { get; set; }
        public string Aangever { get; set; }
        public Double Man_Uren { get; set; }
        public string Datum_Ingedied { get; set; }
        public string Datum_Gepland { get; set; }
        public string Datum_Gereed { get; set; }
        public string Status { get; set; }

    }
}
