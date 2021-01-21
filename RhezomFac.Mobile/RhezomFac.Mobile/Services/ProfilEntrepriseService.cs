using RhezomFac.Mobile.Models;
using RhezomFac.Mobile.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RhezomFac.Mobile.Services
{
    public class ProfilEntrepriseService : BaseService, IProfilEntrepriseService
    {
        private string baseUrl = "ProfilEntreprise";
        /// <summary>
        /// Gets the profil of the company from server.
        /// </summary>
        /// <returns>The found IEnumerable.</returns>
        public async Task<IEnumerable<ProfilEntrepriseModel>> GetProfilEntreprise()
        {
            return await Get<IEnumerable<ProfilEntrepriseModel>>($"{baseUrl}/GetProfilEntreprise");
        }

        /// /// <summary>
        /// Save the profil of the company.
        /// </summary>
        /// <param name="profilEntrepriseModel">The target model.</param>
        /// <returns>This fuction returns the success of operation.</returns>
        public async Task<bool> SaveProfilEntreprise(ProfilEntrepriseModel profilEntrepriseModel)
        {
            // Cal Web API.
            return await Post<bool, ProfilEntrepriseModel>($"{baseUrl}/SaveProfilEntreprise", profilEntrepriseModel);
        }
    }
}
