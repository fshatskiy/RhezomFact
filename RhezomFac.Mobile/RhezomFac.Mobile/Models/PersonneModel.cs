using System;
using System.Collections.Generic;
using System.Text;

namespace RhezomFac.Mobile.Models
{
    public class PersonneModel : BaseModel
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }
        public string NumTVA { get; set; }
    }
}
