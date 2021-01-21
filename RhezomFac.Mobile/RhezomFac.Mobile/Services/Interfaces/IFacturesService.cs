using RhezomFac.Mobile.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RhezomFac.Mobile.Services.Interfaces
{
    public interface IFacturesService
    {
        /// <summary>
        /// Save the invoice model.
        /// </summary>
        /// <param name="factureModel">The target model.</param>
        /// <returns>This fuction returns the success of operation.</returns>
        Task<bool> SaveInvoice(FactureModel factureModel);


        /// <summary>
        /// Gets all invoices from server.
        /// </summary>
        /// <returns>The found IEnumerable.</returns>
        Task<IEnumerable<FactureModel>> GetFactures();
    }
}
