using System;
using System.Collections.Generic;

namespace RhezomFac.Mobile.Models
{
    public class FactureModel: DocumentModel
    {
        public DateTime DateEcheance { get; set; }
        public IEnumerable<ClientModel> Clients { get; set; }
        public IEnumerable<ProduitModel> Produits { get; set; }
        public IEnumerable<ServiceModel> Services { get; set; }
    }
}
