using ClassLibraryBouteille;

namespace TestProjectBouteille
{
    [TestClass]
    public class UnitTestBouteille
    {
        [TestMethod]
        public void OuvertureQuandouteilleFermee()
        {
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(testBottle.getCapaciteMaxEnMl());
            testBottle.setEstOuverte(false);

            bool retour = testBottle.Ouvrir();
            Assert.AreEqual(true, retour);
        }

        [TestMethod]
        public void OuvertureQuandouteilleOuverte()
        {
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(testBottle.getCapaciteMaxEnMl());
            testBottle.setEstOuverte(true);

            bool retour = testBottle.Ouvrir();
            Assert.AreEqual(false, retour);
        }

        [TestMethod]
        public void FermerQuandBouteilleFermee()
        {
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(testBottle.getCapaciteMaxEnMl());
            testBottle.setEstOuverte(false);

            bool retour = testBottle.Fermer();
            Assert.AreEqual(false, retour);
        }

        [TestMethod]
        public void FermerQuandBouteilleOuverte()
        {
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(testBottle.getCapaciteMaxEnMl());
            testBottle.setEstOuverte(true);

            bool retour = testBottle.Fermer();
            Assert.AreEqual(true, retour);
        }

        [TestMethod]
        public void RemplirQuandBouteilleVideEtOuverte()
        {
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(0);
            testBottle.setEstOuverte(true);

            bool retour = testBottle.Remplir(testBottle.getCapaciteMaxEnMl() / 2);
            Assert.AreEqual(true, retour);
        }

        [TestMethod]
        public void RemplirQuandBouteilleVideEtFermee()
        {
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(0);
            testBottle.setEstOuverte(false);

            bool retour = testBottle.Remplir(testBottle.getCapaciteMaxEnMl() / 2);
            Assert.AreEqual(false, retour);
        }

        [TestMethod]
        public void RemplirQuandBouteillePleineEtOuverte()
        {
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(testBottle.getCapaciteMaxEnMl());
            testBottle.setEstOuverte(true);

            bool retour = testBottle.Remplir(testBottle.getCapaciteMaxEnMl() / 2);
            Assert.AreEqual(false, retour);
        }

        [TestMethod]
        public void RemplirToutQuandBouteilleOuverte()
        {
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(0);
            testBottle.setEstOuverte(true);

            bool retour = testBottle.RemplirTout();
            Assert.AreEqual(true, retour);
        }

        [TestMethod]
        public void RemplirToutQuandBouteilleFermee()
        {
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(0);
            testBottle.setEstOuverte(false);

            bool retour = testBottle.RemplirTout();
            Assert.AreEqual(false, retour);
        }

        [TestMethod]
        public void RemplirToutQuandBouteilleOuverteEtMiPleine()
        {
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(testBottle.getCapaciteMaxEnMl() / 2);
            testBottle.setEstOuverte(true);

            bool retour = testBottle.RemplirTout();
            Assert.AreEqual(true, retour);
        }

        [TestMethod]
        public void RemplirToutQuandBouteilleOuverteEtPleine()
        {
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(testBottle.getCapaciteMaxEnMl());
            testBottle.setEstOuverte(true);

            bool retour = testBottle.RemplirTout();
            Assert.AreEqual(false, retour);
        }

        [TestMethod]
        public void SurRemplissageBouteille()
        {
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(testBottle.getCapaciteMaxEnMl() / 2);
            testBottle.setEstOuverte(true);

            bool retour = testBottle.Remplir(testBottle.getCapaciteMaxEnMl() + 1);
            Assert.AreEqual(true, retour);
        }

        [TestMethod]
        public void RemplissageNegatifBouteille()
        {
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(testBottle.getCapaciteMaxEnMl() / 2);
            testBottle.setEstOuverte(true);

            bool retour = testBottle.Remplir(-1);
            Assert.AreEqual(false, retour);
        }

        [TestMethod]
        public void ViderPartiellementBouteilleOuverteEtMiPleine()
        {
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(testBottle.getCapaciteMaxEnMl() / 2);
            testBottle.setEstOuverte(true);

            bool retour = testBottle.Vider(testBottle.getQuantiteLiquideEnMl() / 2);
            Assert.AreEqual(true, retour);
        }

        [TestMethod]
        public void ViderPartiellementBouteilleFermeeEtMiPleine()
        {
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(testBottle.getCapaciteMaxEnMl() / 2);
            testBottle.setEstOuverte(false);

            bool retour = testBottle.Vider(testBottle.getQuantiteLiquideEnMl() / 2);
            Assert.AreEqual(false, retour);
        }

        [TestMethod]
        public void SurvidageBouteille()
        {
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(testBottle.getCapaciteMaxEnMl() / 2);
            testBottle.setEstOuverte(true);

            bool retour = testBottle.Vider(testBottle.getQuantiteLiquideEnMl() + 1);
            Assert.AreEqual(true, retour);
        }

        [TestMethod]
        public void VidageNegatifBouteille()
        {
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(testBottle.getCapaciteMaxEnMl() / 2);
            testBottle.setEstOuverte(true);

            bool retour = testBottle.Vider(-1);
            Assert.AreEqual(false, retour);
        }

        [TestMethod]
        public void ViderEntierementBouteilleOuverteEtMiPleine()
        {
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(testBottle.getCapaciteMaxEnMl() / 2);
            testBottle.setEstOuverte(true);

            bool retour = testBottle.ViderTout();
            Assert.AreEqual(true, retour);
        }

        [TestMethod]
        public void ViderEntierementBouteilleOuverteEtVide()
        {
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(0);
            testBottle.setEstOuverte(true);

            bool retour = testBottle.ViderTout();
            Assert.AreEqual(false, retour);
        }

        [TestMethod]
        public void RemplirBouteilleApresVidage()
        {
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(testBottle.getCapaciteMaxEnMl());
            testBottle.setEstOuverte(true);

            testBottle.ViderTout();
            bool retour = testBottle.RemplirTout();
            Assert.AreEqual(true, retour);
        }

        [TestMethod]
        public void RemplirBouteilleLaMetAuMax()
        {
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(testBottle.getCapaciteMaxEnMl());
            testBottle.setEstOuverte(false);

            bool retour = testBottle.getQuantiteLiquideEnMl() == testBottle.getCapaciteMaxEnMl();
            Assert.AreEqual(true, retour);
        }
        public void ViderBouteilleLaMetAZero()
        {
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(testBottle.getCapaciteMaxEnMl());
            testBottle.setEstOuverte(false);

            bool retour = testBottle.getQuantiteLiquideEnMl() == 0;
            Assert.AreEqual(true, retour);
        }

    }
}