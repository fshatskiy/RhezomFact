using System;
using System.Collections.Generic;
using System.Text;

namespace RhezomFac.Mobile.Models
{
    public class ProfilEntrepriseModel : ProduitModel
    {
        public string Logo{ get; set; }
        public string NomCommercial { get; set; }
        public string AdrEntr { get; set; }
        public string NumTVA { get; set; }
        public string Pays { get; set; }
        public string TelEntr { get; set; }
        public string NumFax { get; set; }
        public string MailEntr { get; set; }
        public string LienWeb { get; set; }
        public string IBAN { get; set; }
        public string BIC { get; set; }
        public string BCE { get; set; }
        public IEnumerable<ProduitModel> Produits { get; set; }

        public IEnumerable<ServiceModel> Services { get; set; }

    }
}
