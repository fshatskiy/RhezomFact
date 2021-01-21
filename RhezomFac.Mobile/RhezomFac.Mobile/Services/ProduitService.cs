using RhezomFac.Mobile.Models;
using RhezomFac.Mobile.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RhezomFac.Mobile.Services
{
    //POUR PROFILENTREPRISE
    public class ProduitService: BaseService, IProduitService
    {
        private string baseUrl = "Produits";

        /// <summary>
        /// Save the invoice model.
        /// </summary>
        /// <param name="factureModel">The target model.</param>
        /// <returns>This fuction returns the success of operation.</returns>
        public async Task<bool> SaveProduit(ProduitModel produitModel) // need to save client too
        {
            // Cal Web API.
            return await Post<bool, ProduitModel>($"{baseUrl}/SaveProduit", produitModel);
        }

        /// <summary>
        /// Gets all invoices from server.
        /// </summary>
        /// <returns>The found IEnumerable.</returns>
        public async Task<IEnumerable<ProduitModel>> GetProduits()
        {
            return await Get<IEnumerable<ProduitModel>>($"{baseUrl}/GetProduits");

        }
    }
}
