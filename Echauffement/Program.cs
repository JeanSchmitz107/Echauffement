namespace Echauffement;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */

            int usr_age, usr_portefeuille, nbr_tbl = 0, usr_euro_verif;
            string usr_prenom, usr_age_verif;
            string[] arme_nom = { "fusils d'assaut", "pistolets mitrailleurs", "fusils à pompe", "sniper" };
            int[] arme_cout = { 2000, 3000, 1200, 5000 };


        // Etape 1 : présentez-vous en écrivant votre prénom et votre jeu préféré

            Console.WriteLine("Bonjour,\n\nJe m'appelle Jean et l'un de mes jeu préférer c'est Ori.\nC'est un jeu 2d super beau où le but c'est de sauvé la forêt");

        // Etape 2 : demandez à l'utilisateur son prénom et son âge

            Console.WriteLine("\n\nVous Vous appelez comment?"); Console.Write("--> ");  usr_prenom = Console.ReadLine();

            Console.WriteLine("\nQuelle âge avez vous?"); Console.Write("--> "); usr_age = Convert.ToInt32(Console.ReadLine());

        // Etape 3 : affichez soit "Tu es majeur", soit "Tu es mineur" dépendant de l'âge fourni par l'utilisateur

        if (usr_age >= 18)
        {
            usr_age_verif = "majeur";
        } 
        else
        {
            usr_age_verif = "mineur";
        }

        Console.WriteLine("Tu es " + usr_age_verif);

        // Etape 4 : demandez maintenant à l'utilisateur combien d'euro il a (nombre décimal)

        Console.WriteLine("\nCombien avez vous d'euro?"); Console.Write("--> "); usr_portefeuille = Convert.ToInt32(Console.ReadLine());

        // Etape 5 : affichez maintenant 4 choix d'armes avec chacune un prix

        Console.WriteLine("\n");
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine( (i+1) + " -  Un " + arme_nom[i] + "\n     " + arme_cout[i] + " euro\n");
        }

        // Etape 6 : laissez l'utilisateur choisir l'une de ces 4 armes en indiquant un nombre entre 1 et 4

        Console.WriteLine("Pour choisir une arme il faut entrer le n° corespondent");
        nbr_tbl = Convert.ToInt32(Console.ReadLine());

        // Etape 7a : vérifiez si l'utilisateur a assez d'argent par rapport à la somme qu'il avait rentré à l'étape 4

        usr_euro_verif = arme_cout[nbr_tbl - 1];

        if (usr_euro_verif <= usr_portefeuille)
        {
            usr_euro_verif = 1;
        }
        else
        {
            usr_euro_verif = 0;
        }

        if (usr_euro_verif == 0 && usr_age_verif == "majeur")
        {
            Console.WriteLine("Vous n'avez pas assez d'argent pour acheter cette arme");
        }
        else if (usr_euro_verif == 1 && usr_age_verif == "mineur")
        {
            Console.WriteLine("Il faut avoir plus de 18 ans pour acheter une arme");
        }
        else if (usr_euro_verif == 0 && usr_age_verif == "mineur")
        {
            Console.WriteLine("Vous n'avez pas assez d'argent et vous devez avoir plus de 18 pour acheter cette arme");
        }
        else
        {
            Console.WriteLine("Merci pour votre achat "+ usr_prenom + " !\nVous possedez dés maintenant un" + arme_nom[nbr_tbl - 1]);
        }

        // Etape 7b : modifiez l'étape 7a pour ajouter un connecteur logique qui vérifie que l'utilisateur est majeur en plus d'avoir assez d'argent
        // Lorsque l'utilisateur respecte ces demandes, retirez le prix de l'arme de l'argent de l'utilisateur, puis confirmez à l'utilisateur que l'action a été effectuée 
        // Dans tous les autres cas, informez l'utilisateur que l'action n'a pas été possible

        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */






    }
}