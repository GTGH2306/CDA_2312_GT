using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLEcf
{
    public class Inscription
    {
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public DateTime TrainingBegin { get; set; }
        public DateTime TrainingEnd { get; set; }
        public Training TrainingSelected { get; set; }

        public Inscription()
        {
            Lastname = string.Empty;
            Firstname = string.Empty;
            TrainingBegin = DateTime.Now;
            TrainingEnd = DateTime.Now;
            TrainingSelected = Training.None;
        }
        public enum Training
        {
            None,
            ABCDEV,
            DWWM,
            CDA
        }
    }


}
