using System;
using System.Text;

namespace Puissance4
{
    public class Grille
    {
        public static int VIDE = 0;
        public static int Joueur1 = 1;
        public static int Joueur2 = 2;
        private static int[,] _grille = new int[7, 7];
        private int _taille{ get; set; }

        public Grille()
        {
            initGrille(7);
        }

        private void initGrille(int taille) {
            _taille = taille;
            _grille = new int[taille,taille];
            for (int col = 0; col < taille ; col++) {
                for (int row = 0; row < taille - 1; row++) {
                    _grille[col,row] = 0;
                }
            }
        }

        public bool ajoutPion(int col, int joueur) {
            if ((col < 0) || (col >= _taille)) {
                return false;
            }
        
            for (int ligne = 0; ligne < _taille - 1; ligne++) {
                if (_grille[col,ligne] == VIDE) {
                    _grille[col,ligne] = joueur;
                    return true;
                }
            }
        
            return false;
        }

        public bool verifie4PionsIdentiqueAlignes() {

            for (int ligne = 0; ligne < _taille; ligne++) {
                if (cherche4PionsAlignes(0, ligne, 1, 0)) {
                    return true;
                }
            }
        
            for (int col = 0; col < _taille; col++) {
                if (cherche4PionsAlignes(col, 0, 0, 1)) {
                    return true;
                }
            }
        
            for (int col = 0; col < _taille; col++) {

                if (cherche4PionsAlignes(col, 0, 1, 1)) {
                    return true;
                }

                if (cherche4PionsAlignes(col, 0, -1, 1)) {
                    return true;
                }
            }
        
            for (int ligne = 0; ligne < _taille; ligne++) {

                if (cherche4PionsAlignes(0, ligne, 1, 1)) {
                    return true;
                }

                if (cherche4PionsAlignes(_taille - 1, ligne, -1, 1)) {
                    return true;
                }
            }
        
            return false;
        }

        public bool cherche4PionsAlignes(int colOrigine, int ligneOrigine, int colDelta, int ligneDelta) {
            int idJoueur = VIDE;
            int compteur = 0;
        
            int currentCol = colOrigine;
            int currentRow = ligneOrigine;
        
            while ((currentCol >= 0) && (currentCol < _taille) && (currentRow >= 0) && (currentRow < _taille)) {
                if (_grille[currentRow,currentCol] != idJoueur) {
                    idJoueur = _grille[currentRow,currentCol];
                    compteur = 1;
                } else {
                    compteur++;
                }
            
                if ((idJoueur != VIDE) && (compteur == 4)) {
                    return true;
                }
            
                currentCol += colDelta;
                currentRow += ligneDelta;
            }

            return false;
        }

        public bool grilleEstPleine() {
            for (int col = 0; col < _taille; col++) {
                for (int ligne = 0; ligne < _taille - 1; ligne++) {
                    if (_grille[col,ligne] == VIDE) {
                        return false;
                    }
                }
            }  
            return true;
        }
 
        public int getTaille() {
            return _taille;
        }

        public void afficherGrille() {
            Console.WriteLine(" 1 2 3 4 5 6 7 ");
            Console.WriteLine("┌─┬─┬─┬─┬─┬─┬─┐");
            for (int ligne = _taille - 2; ligne >= 0; --ligne) 
            {
                var line = new StringBuilder("│");

                for (int col = 0; col < _taille; col++) 
                {
                    if (_grille[col,ligne] == 0) line.Append(' ');
                    else if (_grille[col,ligne] == 1) line.Append('X');
                    else line.Append('O');
                    line.Append('│');
                }
                Console.WriteLine(line.ToString());

                if (ligne != 6) Console.WriteLine("├─┼─┼─┼─┼─┼─┼─┤");
            }
            Console.WriteLine("└─┴─┴─┴─┴─┴─┴─┘");
        }
    }
}