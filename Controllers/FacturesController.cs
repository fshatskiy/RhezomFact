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
    public class FacturesController : ControllerBase
    {

        [HttpGet("GetFactures")]
        public IActionResult GetFactures()
        {
            //appeler la bd
            // var produitsList = porduitsRepository.GetAll();

            var factures = new List<FactureModel>
            {
                new FactureModel
                {
                    //try data static
                    Id = 1,
                    DateEcheance = DateTime.Now,
                    Produits = new List<ProduitModel>
                    {
                        new ProduitModel
                        {
                            //try data static
                            Id = 1,
                            Description = "Produit",
                            EstActif=true,
                            Nom = "Other product",
                            PrixHT = 21,
                            QtiteRest = 1,
                            TVA = 25.0f
                        },
                        new ProduitModel
                        {
                            //try data static
                            Id = 2,
                            Description = "Produit2",
                            EstActif=true,
                            Nom = "Prod2",
                            PrixHT = 21,
                            QtiteRest = 1,
                            TVA = 25.0f
                        }
                    }
                },
                new FactureModel
                {
                    //try data static
                    Id = 2,
                    DateEcheance = DateTime.Now,
                    Produits = new List<ProduitModel>
                    {
                        new ProduitModel
                        {
                            //try data static
                            Id = 3,
                            Description = "Produit",
                            EstActif=true,
                            Nom = "Other product",
                            PrixHT = 21,
                            QtiteRest = 1,
                            TVA = 25.0f
                        }
                    }
                }
            };


            return Ok(factures);
        }

        [HttpPost("SaveFacture")]

        public IActionResult SaveFacture([FromBody] FactureModel factureModel)
        {
            bool success = false;
            // CAll DB Save Model; Commit;
            return Ok(success);
        }

    }
}
