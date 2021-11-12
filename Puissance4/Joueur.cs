using System;

namespace Puissance4
{
    public class Joueur
    {
    private String _nom  { get; set; }
    private int _idJoueur { get; set; }
        public Joueur(String nom, int idJoueur)
        {
            _nom = nom;
            _idJoueur = idJoueur;
        }

        public String getNom() {
            return _nom;
        }

        public int getIdJoueur() {
            return _idJoueur;
        }

        public virtual void joue(Grille grille) {}
    }
}