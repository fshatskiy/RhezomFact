using RhezomFac.Mobile.Models;
using RhezomFac.Mobile.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RhezomFac.Mobile.Services
{
    public class DevisService : BaseService, IDevisService
    {
        private string baseUrl = "Devis";

        /// <summary>
        /// Save the invoice model.
        /// </summary>
        /// <param name="devisModel">The target model.</param>
        /// <returns>This fuction returns the success of operation.</returns>
        public async Task<bool> SaveDevis(DevisModel devisModel) // need to save client too
        {
            // Cal Web API.
            return await Post<bool, DevisModel>($"{baseUrl}/SaveDevis", devisModel);
        }

        /// <summary>
        /// Gets all invoices from server.
        /// </summary>
        /// <returns>The found IEnumerable.</returns>
        public async Task<IEnumerable<DevisModel>> GetDevis()
        {
            return await Get<IEnumerable<DevisModel>>($"{baseUrl}/GetDevis");

        }
    }
}
