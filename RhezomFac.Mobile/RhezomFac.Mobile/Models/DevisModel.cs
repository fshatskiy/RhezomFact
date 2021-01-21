using System;
using System.Collections.Generic;
using System.Text;

namespace RhezomFac.Mobile.Models
{
    public class DevisModel : DocumentModel
    {
        public DateTime DateValidite { get; set; }
        public IEnumerable<ProduitModel> Produits { get; set; }
        public IEnumerable<ServiceModel> Services { get; set; }
    }
}
