using RhezomFac.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RhezomFac.Mobile.Services.Interfaces
{
    public interface IClientsService
    {
        /// <summary>
        /// Save the invoice model.
        /// </summary>
        /// <param name="clientModel">The target model.</param>
        /// <returns>This fuction returns the success of operation.</returns>
        Task<bool> SaveClient(ClientModel clientModel);


        /// <summary>
        /// Gets all invoices from server.
        /// </summary>
        /// <returns>The found IEnumerable.</returns>
        Task<IEnumerable<ClientModel>> GetClients(); //pr faire appels asynchrones
    }
}
