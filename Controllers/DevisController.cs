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
    public class DevisController : ControllerBase
    {

        [HttpGet("GetDevis")]
        public IActionResult GetDevis()
        {
            //appeler la bd
            // var produitsList = porduitsRepository.GetAll();

            var devis = new List<DevisModel>
            {
                new DevisModel
                {
                    //try data static
                    Id = 1,
                    DateValidite = DateTime.Now,
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
                new DevisModel
                {
                    //try data static
                    Id = 2,
                    DateValidite = DateTime.Now,
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


            return Ok(devis);
        }

        [HttpPost("SaveDevis")]

        public IActionResult SaveDevis([FromBody] DevisModel devisModel)
        {
            bool success = false;
            // CAll DB Save Model; Commit; (utiliser devisModel)
            return Ok(success);
        }

    }
}
