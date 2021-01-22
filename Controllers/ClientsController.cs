using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RhezomFacAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RhezomFacAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        [HttpGet("GetClients")]
        public IActionResult GetClients()
        {
            //appeler la bd
            // var produitsList = porduitsRepository.GetAll();

            var clients = new List<ClientModel>
            {
                new ClientModel
                {
                    //try data static
                    Id = 1,
                    Nom = "Nom",
                    Prenom = "Prenom",
                    Adresse = "Adr",
                    Mail = "ffrf@efr.fr",
                    Tel = "08563511",
                    NumTVA = "BE 4584511",
                    EstActif = true,
                },
                new ClientModel
                {
                    //try data static
                    Id = 2,
                    Nom = "Nom",
                    Prenom = "Prenom",
                    Adresse = "Adr",
                    Mail = "ffrf@efr.fr",
                    Tel = "08563511",
                    NumTVA = "BE 4584511",
                    EstActif = true,
                }
            };


            return Ok(clients);
        }

        [HttpPost("SaveClient")]

        public IActionResult SaveClient([FromBody] ClientModel clientModel)
        {
            bool success = false;
            // CAll DB Save Model; Commit; (à utiliser clientModel)
            return Ok(success);
        }
    }
}
