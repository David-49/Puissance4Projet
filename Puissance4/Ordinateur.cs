using System;

namespace Puissance4
{
    public class Ordinateur : Joueur
    {
        public Ordinateur(int idJoueur) : base("L'ordinateur", idJoueur)
        {}

        public override void joue(Grille grille) {
            Random rnd = new Random();
            int randomCol = rnd.Next(0, 6);
            if (grille.ajoutPion(randomCol, getIdJoueur())) {
                    Console.WriteLine($"{getNom()} a joué dans la colonne {randomCol + 1}");
                    return;
                }             
        }
        
    }
}