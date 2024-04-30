using ClassLibraryBouteille;

namespace TestProjectBouteille
{
    [TestClass]
    public class UnitTestBouteille
    {
        [TestMethod]
        public void Bouteille_Constructeur_ParDefaut_Reussite()
        {
            //Arrange
            Bouteille testBottle = new Bouteille();

            //Assert
            Assert.IsNotNull(testBottle);
            Assert.AreEqual(1000, testBottle.getCapaciteMaxEnMl());
            Assert.AreEqual(1000, testBottle.getQuantiteLiquideEnMl());
            Assert.IsFalse(testBottle.getEstOuverte());

        }

        public void Bouteille_Constructeur_Parametre_Reussite()
        {
            //Arrange
            Bouteille testBottle = new Bouteille(2333);

            //Assert
            Assert.IsNotNull(testBottle);
            Assert.AreEqual(2333, testBottle.getCapaciteMaxEnMl());
            Assert.AreEqual(2333, testBottle.getQuantiteLiquideEnMl());
            Assert.IsFalse(testBottle.getEstOuverte());

        }

        [TestMethod]
        public void Bouteille_Ouvrir_OuvertureQuandouteilleFermee_Reussite()
        {
            //Arrange
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setEstOuverte(false);

            //Act
            bool retour = testBottle.Ouvrir();

            //Assert
            Assert.IsTrue(testBottle.getEstOuverte());
            Assert.IsTrue(retour);
        }

        [TestMethod]
        public void Bouteille_Ouvrir_OuvertureQuandBouteilleOuverte_Echec()
        {
            //Arrange
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setEstOuverte(true);

            //Act
            bool retour = testBottle.Ouvrir();

            //Assert
            Assert.IsFalse(retour);
            Assert.IsTrue(testBottle.getEstOuverte());
        }

        [TestMethod]
        public void Bouteille_Fermer_FermerQuandBouteilleFermee_Echec()
        {
            //Arrange
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setEstOuverte(false);
            
            //Act
            bool retour = testBottle.Fermer();

            //Assert
            Assert.IsFalse(retour);
            Assert.IsFalse(testBottle.getEstOuverte());
        }

        [TestMethod]
        public void Bouteille_Fermer_FermerQuandBouteilleOuverte_Reussite()
        {
            //Arrange
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setEstOuverte(true);

            //Act
            bool retour = testBottle.Fermer();
            
            //Assert
            Assert.IsTrue(retour);
            Assert.IsFalse(testBottle.getEstOuverte());
        }

        [TestMethod]
        public void Bouteille_Remplir_RemplirQuandBouteilleVideEtOuverte_Reussite()
        {
            //Arrange
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(0);
            testBottle.setEstOuverte(true);

            //Act
            bool retour = testBottle.Remplir(testBottle.getCapaciteMaxEnMl() / 2);

            //Assert
            Assert.IsTrue(retour);
            Assert.AreEqual(1500, testBottle.getQuantiteLiquideEnMl());
        }

        [TestMethod]
        public void Bouteille_Remplir_RemplirQuandBouteilleVideEtFermee_Echec()
        {
            //Arrange
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(0);
            testBottle.setEstOuverte(false);

            //Act
            bool retour = testBottle.Remplir(testBottle.getCapaciteMaxEnMl() / 2);

            //Assert
            Assert.IsFalse(retour);
            Assert.AreEqual(0, testBottle.getQuantiteLiquideEnMl());
        }

        [TestMethod]
        public void Bouteille_Remplir_RemplirQuandBouteillePleineEtOuverte_Echec()
        {
            //Arrange
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(testBottle.getCapaciteMaxEnMl());
            testBottle.setEstOuverte(true);

            //Act
            bool retour = testBottle.Remplir(testBottle.getCapaciteMaxEnMl() / 2);
            
            //Assert
            Assert.IsFalse(retour);
            Assert.AreEqual(3000, testBottle.getQuantiteLiquideEnMl());
        }

        [TestMethod]
        public void Bouteille_RemplirTout_RemplirToutQuandBouteilleOuverte_Reussite()
        {
            //Arrange
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(0);
            testBottle.setEstOuverte(true);

            //Act
            bool retour = testBottle.RemplirTout();
            
            //Assert
            Assert.IsTrue(retour);
            Assert.AreEqual(3000, testBottle.getQuantiteLiquideEnMl());
        }

        [TestMethod]
        public void Bouteille_RemplirTout_RemplirToutQuandBouteilleFermee_Echec()
        {
            //Arrange
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(0);
            testBottle.setEstOuverte(false);

            //Act
            bool retour = testBottle.RemplirTout();
            
            //Assert
            Assert.IsFalse(retour);
            Assert.AreEqual(0, testBottle.getQuantiteLiquideEnMl());
        }

        [TestMethod]
        public void Bouteille_RemplirTout_RemplirToutQuandBouteilleOuverteEtMiPleine_Reussite()
        {
            //Arrange
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(testBottle.getCapaciteMaxEnMl() / 2);
            testBottle.setEstOuverte(true);

            //Act
            bool retour = testBottle.RemplirTout();
            
            //Assert
            Assert.IsTrue(retour);
            Assert.AreEqual(3000, testBottle.getQuantiteLiquideEnMl());
        }

        [TestMethod]
        public void Bouteille_RemplirTout_RemplirToutQuandBouteilleOuverteEtPleine_Echec()
        {
            //Arrange
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(testBottle.getCapaciteMaxEnMl());
            testBottle.setEstOuverte(true);

            //Act
            bool retour = testBottle.RemplirTout();
            
            //Assert
            Assert.IsFalse(retour);
            Assert.AreEqual(3000, testBottle.getQuantiteLiquideEnMl());
        }

        [TestMethod]
        public void Bouteille_Remplir_SurRemplissageBouteille_Reussite()
        {
            //Arrange
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(testBottle.getCapaciteMaxEnMl() / 2);
            testBottle.setEstOuverte(true);

            //Act
            bool retour = testBottle.Remplir(testBottle.getCapaciteMaxEnMl() + 1);

            //Assert
            Assert.IsTrue(retour);
            Assert.AreEqual(3000, testBottle.getQuantiteLiquideEnMl());
        }

        [TestMethod]
        public void Bouteille_Remplir_RemplissageNegatifBouteille_Echec()
        {
            //Arrange
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(testBottle.getCapaciteMaxEnMl() / 2);
            testBottle.setEstOuverte(true);

            //Act
            bool retour = testBottle.Remplir(-1);

            //Assert
            Assert.IsFalse(retour);
            Assert.AreEqual(1500, testBottle.getQuantiteLiquideEnMl());
        }

        [TestMethod]
        public void Bouteille_Vider_ViderPartiellementBouteilleOuverteEtMiPleine_Reussite()
        {
            //Arrange
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(1500);
            testBottle.setEstOuverte(true);

            //Act
            bool retour = testBottle.Vider(500);

            //Assert
            Assert.IsTrue(retour);
            Assert.AreEqual(1000, testBottle.getQuantiteLiquideEnMl());
        }

        [TestMethod]
        public void Bouteille_Vider_ViderPartiellementBouteilleFermeeEtMiPleine_Echec()
        {
            //Arrange
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(testBottle.getCapaciteMaxEnMl() / 2);
            testBottle.setEstOuverte(false);

            //Act
            bool retour = testBottle.Vider(testBottle.getQuantiteLiquideEnMl() / 2);

            //Assert
            Assert.AreEqual(1500, testBottle.getQuantiteLiquideEnMl());
            Assert.IsFalse(retour);
        }

        [TestMethod]
        public void Bouteille_Vider_SurvidageBouteille_Reussite()
        {
            //Arrange
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(testBottle.getCapaciteMaxEnMl() / 2);
            testBottle.setEstOuverte(true);

            //Act
            bool retour = testBottle.Vider(testBottle.getQuantiteLiquideEnMl() + 1);

            //Assert
            Assert.AreEqual(0, testBottle.getQuantiteLiquideEnMl());
            Assert.IsTrue(retour);
        }

        [TestMethod]
        public void Bouteille_Vider_VidageNegatifBouteille_Echec()
        {
            //Arrange
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(testBottle.getCapaciteMaxEnMl() / 2);
            testBottle.setEstOuverte(true);

            //Act
            bool retour = testBottle.Vider(-1);

            //Assert
            Assert.AreEqual(1500, testBottle.getQuantiteLiquideEnMl());
            Assert.IsFalse(retour);
        }

        [TestMethod]
        public void Bouteille_Vider_ViderEntierementBouteilleOuverteEtMiPleine_Reussite()
        {
            //Arrange
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(testBottle.getCapaciteMaxEnMl() / 2);
            testBottle.setEstOuverte(true);

            //Act
            bool retour = testBottle.ViderTout();

            //Assert
            Assert.AreEqual(0, testBottle.getQuantiteLiquideEnMl());
            Assert.IsTrue(retour);
        }

        [TestMethod]
        public void Bouteille_ViderTout_ViderEntierementBouteilleOuverteEtVide_Echec()
        {
            //Arrange
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(0);
            testBottle.setEstOuverte(true);

            //Act
            bool retour = testBottle.ViderTout();

            //Assert
            Assert.AreEqual(0, testBottle.getQuantiteLiquideEnMl());
            Assert.IsFalse(retour);
        }

        [TestMethod]
        public void Bouteille_RemplirTout_RemplirBouteilleApresVidage_Reussite()
        {
            //Arrange
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(testBottle.getCapaciteMaxEnMl());
            testBottle.setEstOuverte(true);

            //Act
            testBottle.ViderTout();
            bool retour = testBottle.RemplirTout();

            //Assert
            Assert.AreEqual(3000, testBottle.getQuantiteLiquideEnMl());
            Assert.IsTrue(retour);
        }

        [TestMethod]
        public void Bouteille_RemplirTout_RemplirBouteilleLaMetAuMax_Reussite()
        {
            //Arrange
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(0);
            testBottle.setEstOuverte(true);

            //Act
            testBottle.RemplirTout();
            bool retour = testBottle.getQuantiteLiquideEnMl() == testBottle.getCapaciteMaxEnMl();

            //Assert
            Assert.AreEqual(3000, testBottle.getQuantiteLiquideEnMl());
            Assert.IsTrue(retour);
        }

        [TestMethod]
        public void Bouteille_ViderTout_ViderBouteilleLaMetAZero_Reussite()
        {
            //Arrange
            Bouteille testBottle = new Bouteille(3000);
            testBottle.setQuantiteLiquideEnMl(testBottle.getCapaciteMaxEnMl());
            testBottle.setEstOuverte(true);

            //Act
            testBottle.ViderTout();

            //Assert
            Assert.AreEqual(0, testBottle.getQuantiteLiquideEnMl());
        }

    }
}