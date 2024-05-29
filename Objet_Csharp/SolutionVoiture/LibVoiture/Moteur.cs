using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibVoiture
{
    public class Moteur
    {
        private readonly int couple;
        private double delta;
        private bool estDemarre;
        public double Delta { get => delta; }

        public Moteur(int _couple)
        {
            this.couple = _couple;
            this.delta = 0;
            this.estDemarre = false;
        }
        public Moteur(Moteur _moteur)
        {
            this.couple = _moteur.couple;
            this.delta = _moteur.delta;
            this.estDemarre = _moteur.estDemarre;
        }
        public Moteur() : this(200) { }

        public bool Allumer()
        {
            bool retour;
            if (!this.estDemarre)
            {
                this.estDemarre = true;
                retour = true;
            } else
            {
                retour = false;
            }
            return retour;
        }
        public bool Couper()
        {
            bool retour;
            if (this.estDemarre)
            {
                this.estDemarre = false;
                retour = true;
            }
            else
            {
                retour = false;
            }
            return retour;
        }
        public bool Accelerer(Roue _avantGauche, Roue _avantDroite)
        {
            bool retour;
            
            if (this.estDemarre)
            {
                if (this.delta < this.couple)
                {
                    this.delta++;
                    retour = true;
                }
                else
                {
                    retour = false;
                }
                if (this.delta > 0 && _avantGauche.Rotation != Rotation.Avant)
                {
                    _avantGauche.Rotation = Rotation.Avant;
                }
                if (this.delta > 0 && _avantDroite.Rotation != Rotation.Avant)
                {
                    _avantDroite.Rotation = Rotation.Avant;
                }
                if (this.delta == 0)
                {
                    _avantGauche.Rotation = Rotation.Arret;
                    _avantDroite.Rotation = Rotation.Arret;
                }
            }
            else
            {
                retour = false;
            }

            return retour;
        }
        public bool Deccelerer(Roue _avantGauche, Roue _avantDroite)
        {
            bool retour;

            if (this.estDemarre)
            {
                if (this.delta > -this.couple)
                {
                    this.delta--;
                    retour = true;
                }
                else
                {
                    retour = false;
                }
                if (this.delta < 0 && _avantGauche.Rotation != Rotation.Arriere)
                {
                    _avantGauche.Rotation = Rotation.Arriere;
                }
                if (this.delta < 0 && _avantDroite.Rotation != Rotation.Arriere)
                {
                    _avantDroite.Rotation = Rotation.Arriere;
                }
                if (this.delta == 0)
                {
                    _avantGauche.Rotation = Rotation.Arret;
                    _avantDroite.Rotation = Rotation.Arret;
                }
            }
            else
            {
                retour = false;
            }

            return retour;
        }
        public override string ToString()
        {
            return
                (
                "couple:" + this.couple + "\n" +
                "delta:" + this.delta + "\n" +
                "estDemarre:" + this.estDemarre
                );
        }
    }
}
