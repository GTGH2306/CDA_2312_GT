using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibVoiture
{
    public class Roue
    {
        private Rotation rotation;
        private float pressionPneu;
        public Rotation Rotation { get => this.rotation; set => this.rotation = value; }
        public Roue(float _pression)
        {
            this.pressionPneu = _pression;
            this.rotation = Rotation.Arret;
        }
        public Roue() : this(3) { }
        public Roue(Roue _roue)
        {
            this.pressionPneu = _roue.pressionPneu;
            this.rotation = _roue.rotation;
        }
        public override string ToString()
        {
            return
                (
                "rotation:" + this.rotation + "\n" +
                "pressionPneu:" + this.pressionPneu
                );
        }

    }

    public enum Rotation
    {
        Avant,
        Arriere,
        Arret,
        Freinage
    }
}
