using System;

namespace Puissance4
{
    public class Partie
    {
        private Joueur[] _joueurs = new Joueur[2];
        private Grille _grille;

        public Partie(Joueur joueur1, Joueur joueur2)
        {
            _joueurs[0] = joueur1;
            _joueurs[1] = joueur2;
            _grille = new Grille();
        }

        public void joue() {
            int vainqueur = -1;
            int currentJoueur = 0;
        
            while (vainqueur == -1) {
                _joueurs[currentJoueur].joue(_grille);
                if (_grille.grilleEstPleine()) {
                    vainqueur = -1;
                }
            
                if (_grille.verifie4PionsIdentiqueAlignes()) {
                    vainqueur = currentJoueur;
                }
                currentJoueur++;
                currentJoueur %= 2;     

            }
        
            Console.WriteLine("La partie est finie.");

            _grille.afficherGrille();

            if (vainqueur == -1) {
                Console.WriteLine("Match nul.");
            } else {
                Console.WriteLine($"Le vainqueur est {_joueurs[vainqueur].getNom()}");
            }
        }
    }
}
