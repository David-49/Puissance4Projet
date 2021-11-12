using System;

namespace Puissance4
{
    public class JoueurReel : Joueur
    {
        public JoueurReel(String nom, int idJoueur) : base(nom, idJoueur)
        {

        }

        public override void joue(Grille grille) 
        {
            
            grille.afficherGrille();

            bool valide;

            do {
                Console.WriteLine($"Joueur {getNom()}, entrez un numéro de colonne (entre 1 et {grille.getTaille()})");

                int col = Convert.ToInt32(Console.ReadLine());

                col--;

                valide = grille.ajoutPion(col, getIdJoueur());

                if (!valide) {
                    Console.WriteLine("Coup non valide.");
                }

            } while (!valide);
            
        }
    }
}