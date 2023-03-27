using Microsoft.AspNetCore.Mvc;

namespace GoWeb.Controllers
{
    public class MonControleur : Controller
    {
        public ActionResult MonAction()
        {
            // Instanciation du proxy client
            PersonnesController proxy = new PersonnesController();

            // Appel de la méthode du service distant
            var resultat = proxy.Index();

            return View(resultat);
        }
    }
}