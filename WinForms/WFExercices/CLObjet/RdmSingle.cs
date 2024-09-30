using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLObjet
{
    public class RdmSingle : Random
    {
        private static RdmSingle instance;

        public static RdmSingle GetInstance()
        {
            if (instance == null)
            {
                instance = new RdmSingle();
            }
            return instance;
        }
    }
}
