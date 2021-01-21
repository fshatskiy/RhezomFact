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
    public class ProduitsController : ControllerBase
    {

        [HttpGet("GetProduits")]
        public IActionResult GetProduits()
        {
            //appeler la bd
            // var produitsList = porduitsRepository.GetAll();

            var Produits = new List<ProduitModel>
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
            };


            return Ok(Produits);
        }
    }
}
