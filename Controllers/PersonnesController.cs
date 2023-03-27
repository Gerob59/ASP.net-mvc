using Microsoft.AspNetCore.Mvc;
using GoWeb.Models;
using GoWeb.Utils;

namespace GoWeb.Controllers
{
    public class PersonnesController : Controller
    {

        /// Permet de passer la liste des personnes à la vue
        public IActionResult Index()
        {
            // Créez une liste de personnes
            List<Personne> personnes = new List<Personne>();

            // Remplis la liste des personnes
            for (int i = 0; i < 8; i++)
            {
                // Créé une personne aléatoirement
                var personne = new Personne
                {
                    Nom = Aleatoire.StringAleatoire(),
                    Prenom = Aleatoire.StringAleatoire(),
                    Telephone = Aleatoire.TelephoneAleatoire()
                };

                // Ajoute la personne créé à la liste
                personnes.Add(personne);
            }

            // Passez la liste des personnes à la vue Index
            return View(personnes);
        }
    }
}