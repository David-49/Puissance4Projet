using System;

namespace Puissance4
{
    public class GestionnaireJeu
    {
        public GestionnaireJeu()
        {
            bool nbJoueurOk = false;
            do
            {
            Console.WriteLine("Nombre de joueurs :");

            int nbJoueurs = Convert.ToInt32(Console.ReadLine());

            if(nbJoueurs == 2) 
            {
                nbJoueurOk = true;
                Partie p = new Partie(new JoueurReel("Toto", Grille.Joueur1), new JoueurReel("Tata", Grille.Joueur2));
                p.joue();
            } else if(nbJoueurs == 1)
            {
                nbJoueurOk = true;
                Partie p = new Partie(new Ordinateur(Grille.Joueur1), new JoueurReel("Toto", Grille.Joueur2));
                p.joue();
            }
            Console.WriteLine("Nombre de joueurs sélectionnés incorrect ! Réessayer");

            
                
            } while (!nbJoueurOk);
        }
    }
}