using System.Text;

namespace LibVoiture
{
    public class Bagnole
    {
        private readonly int nbPlaces;
        private Dictionary<string, Roue> roues;
        private readonly Moteur moteur;

        public Bagnole(Moteur _moteur,
            Roue _roueAvantGauche,
            Roue _roueAvantDroite,
            Roue _roueArriereGauche,
            Roue _roueArriereDroite,
            int _nbPlaces)
        {
            this.moteur = _moteur;
            this.roues = new Dictionary<string, Roue>();
            this.roues.Add("Roue Avant Gauche", _roueAvantGauche);
            this.roues.Add("Roue Avant Droite", _roueAvantDroite);
            this.roues.Add("Roue Arriere Gauche", _roueArriereGauche);
            this.roues.Add("Roue Arriere Droite", _roueArriereDroite);
            this.nbPlaces = _nbPlaces;
        }
        public Bagnole(Moteur _moteur, int _nbPlaces) :
            this(_moteur, new Roue(), new Roue(), new Roue(), new Roue(), _nbPlaces) { }
        public Bagnole(Moteur _moteur) : this(_moteur, 4) { }
        public Bagnole(int _nbPlaces) : this(new Moteur(), _nbPlaces) { }
        public Bagnole() : this(4) { }
        public Bagnole(Bagnole _bagnole) :
            this(new Moteur(_bagnole.moteur),
                new Roue(_bagnole.roues["Roue Avant Gauche"]),
                new Roue(_bagnole.roues["Roue Avant Droite"]),
                new Roue(_bagnole.roues["Roue Arriere Gauche"]),
                new Roue(_bagnole.roues["Roue Arriere Droite"]),
                _bagnole.nbPlaces
                ) { }

        public bool Demarrer()
        {
            return this.moteur.Allumer();
        }
        public bool Arreter()
        {
            return this.moteur.Couper();
        }
        public bool Avancer()
        {
            bool retour;
            retour = this.moteur.Accelerer(this.roues["Roue Avant Gauche"], this.roues["Roue Avant Droite"]) &&
                this.roues["Roue Avant Gauche"].Rotation == Rotation.Avant &&
                this.roues["Roue Avant Droite"].Rotation == Rotation.Avant;
            if (retour)
            {
                this.roues["Roue Arriere Gauche"].Rotation = this.roues["Roue Avant Gauche"].Rotation;
                this.roues["Roue Arriere Droite"].Rotation = this.roues["Roue Avant Droite"].Rotation;
            }
            return retour;
        }
        public bool Reculer()
        {
            bool retour;
            retour = this.moteur.Deccelerer(this.roues["Roue Avant Gauche"], this.roues["Roue Avant Droite"]) &&
                this.roues["Roue Avant Gauche"].Rotation == Rotation.Arriere &&
                this.roues["Roue Avant Droite"].Rotation == Rotation.Arriere;
            if (retour)
            {
                this.roues["Roue Arriere Gauche"].Rotation = this.roues["Roue Avant Gauche"].Rotation;
                this.roues["Roue Arriere Droite"].Rotation = this.roues["Roue Avant Droite"].Rotation;
            }
            return retour;
        }
        public void Freiner()
        {
            if (this.roues["Roue Avant Gauche"].Rotation != Rotation.Freinage &&
                this.roues["Roue Avant Droite"].Rotation != Rotation.Freinage)
            {
                this.roues["Roue Avant Gauche"].Rotation = Rotation.Freinage;
                this.roues["Roue Avant Droite"].Rotation = Rotation.Freinage;
            }
            if (this.moteur.Delta > 0)
            {
                Reculer();
            } else if (this.moteur.Delta < 0)
            {
                Avancer();
            } else
            {
                this.roues["Roue Avant Gauche"].Rotation = Rotation.Arret;
                this.roues["Roue Avant Droite"].Rotation = Rotation.Arret;
            }
            if (this.moteur.Delta == 0)
            {
                this.roues["Roue Arriere Gauche"].Rotation = Rotation.Arret;
                this.roues["Roue Arriere Droite"].Rotation = Rotation.Arret;
            }
        }
        public override string ToString()
        {
            StringBuilder retour = new StringBuilder();
            retour.Append(this.moteur + "\n" + "nbPlaces:" + this.nbPlaces);
            foreach (KeyValuePair<string, Roue> _roue in roues)
            {
                retour.Append("\n<" + _roue.Key + ">\n" + _roue.Value);
            }
            return retour.ToString();
        }
    }
}