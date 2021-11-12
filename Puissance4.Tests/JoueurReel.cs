using NUnit.Framework;

namespace Puissance4.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void joueurReel_peut_jouer()
        {
            Partie partie = new Partie(new JoueurReel("Toto", Grille.Joueur1), new JoueurReel("Tata", Grille.Joueur2));

            var result = grille.ajoutPion(2, getIdJoueur());

            Assert.AreEquals(true, result);

        }
    }
}