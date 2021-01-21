using System;
using System.Collections.Generic;
using System.Text;

namespace RhezomFac.Mobile.Models
{
    public class ProduitModel : BaseModel
    {
        public string Nom { get; set; }
        public string Description { get; set; }
        public int QtiteRest { get; set; }
        public float TVA { get; set; }
        public float PrixHT { get; set; }
        public bool EstActif { get; set; }
    }
}
