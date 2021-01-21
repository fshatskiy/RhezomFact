using RhezomFac.Mobile.Models;
using RhezomFac.Mobile.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RhezomFac.Mobile.Services
{
    public class FacturesService: BaseService, IFacturesService
    {
        private string baseUrl = "Factures";

        /// <summary>
        /// Save the invoice model.
        /// </summary>
        /// <param name="factureModel">The target model.</param>
        /// <returns>This fuction returns the success of operation.</returns>
        public async Task<bool> SaveInvoice(FactureModel factureModel) // need to save client too
        {
            // Cal Web API.
            return  await Post<bool, FactureModel>($"{baseUrl}/SaveFacture", factureModel);
        }

        /// <summary>
        /// Gets all invoices from server.
        /// </summary>
        /// <returns>The found IEnumerable.</returns>
        public async Task<IEnumerable<FactureModel>> GetFactures()
        {
            return await Get<IEnumerable<FactureModel>>($"{baseUrl}/GetFactures");

        }
    }
}
