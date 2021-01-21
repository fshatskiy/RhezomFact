using RhezomFac.Mobile.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RhezomFac.Mobile.Services.Interfaces
{
    public interface IProfilEntrepriseService
    {
        /// <summary>
        /// Save the invoice model.
        /// </summary>
        /// <param name="profilEntrepriseModel">The target model.</param>
        /// <returns>This fuction returns the success of operation.</returns>
        Task<bool> SaveProfilEntreprise(ProfilEntrepriseModel ProfilEntrepriseModel);


        /// <summary>
        /// Gets all invoices from server.
        /// </summary>
        /// <returns>The found IEnumerable.</returns>
        Task<IEnumerable<ProfilEntrepriseModel>> GetProfilEntreprise();
    }
}
