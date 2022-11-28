using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NordicDoor.Models
{
    public class Forslag
    {
        public int ForslagId { get; set; }
        public string AnsattId { get; set; }
        public string Tittel { get; set; }
        public string Årsak { get; set; }
        public string Mål { get; set; }
        public string Løsning { get; set; }
        public DateTime DatoRegistrert { get; set; } = DateTime.Now;
        public DateTime Frist { get; set; }
        
        public string ImageUrl { get; set; }
        public int Team { get; set; }
        public string Ansvarlig { get; set; }




    }
}
