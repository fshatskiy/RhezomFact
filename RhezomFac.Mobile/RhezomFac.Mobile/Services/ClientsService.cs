using RhezomFac.Mobile.Models;
using RhezomFac.Mobile.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RhezomFac.Mobile.Services
{
    public class ClientsService : BaseService, IClientsService
    {
        private string baseUrl = "Clients";
        public async Task<IEnumerable<ClientModel>> GetClients()
        {
            // Cal Web API.
            return await Get<IEnumerable<ClientModel>>($"{baseUrl}/GetClients");
        }

        public async Task<bool> SaveClient(ClientModel clientModel)
        {
            return await Post<bool, ClientModel>($"{baseUrl}/SaveClient", clientModel);
        }
    }
}
