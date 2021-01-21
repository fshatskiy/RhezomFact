using RhezomFac.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RhezomFac.Mobile.Services.Interfaces
{
    public interface IProduitService
    {
        /// <summary>
        /// Save the invoice model.
        /// </summary>
        /// <param name="factureModel">The target model.</param>
        /// <returns>This fuction returns the success of operation.</returns>
        Task<bool> SaveProduit(ProduitModel produitModel);


        /// <summary>
        /// Gets all invoices from server.
        /// </summary>
        /// <returns>The found IEnumerable.</returns>
        Task<IEnumerable<ProduitModel>> GetProduits();
    }
}
