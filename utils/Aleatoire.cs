namespace GoWeb.Utils;

public static class Aleatoire
{

    /// Génère une string avec des lettres aléatoires de longueur entre 1 et 15
    /// Commence par une majuscule, puis que des minuscules
    public static string StringAleatoire()
    {
        Random aleatoire = new Random();

        // taille du string aléatoire entre 1 et 15
        int length = aleatoire.Next(1, 15);

        // met une majuscule pour la premiere lettre
        string name = ((char)aleatoire.Next('A', 'Z' + 1)).ToString();

        for (int i = 1; i < length; i++)
        {
            // met une minuscules
            name += ((char)aleatoire.Next('a', 'z' + 1)).ToString();
        }

        return name;
    }

    /// Génère un numéro de téléphone aléatoire au format français séparé avec des '.'
    public static string TelephoneAleatoire()
    {
        Random aleatoire = new Random();

        // début de numéro de téléphone au format français
        string telephone = "0";

        // ajoute un chiffre sous format string au numéro
        for (int i = 0; i < 9; i++)
            telephone += aleatoire.Next(10).ToString();

        // ajoute les séparateur '.' du numéro de téléphone avant de le renvoyer
        return telephone.Insert(2, ".")
                         .Insert(5, ".")
                         .Insert(8, ".")
                         .Insert(11, ".");
    }
}