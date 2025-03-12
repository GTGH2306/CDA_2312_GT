using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryHanoi
{
    public class Pellet
    {
        private readonly int size;
        /// <summary>
        /// Returns the size of the pellet
        /// </summary>
        public int Size { get { return size; } }

        /// <summary>
        /// Creates a pellet for the game "Tower of Hanoï"
        /// </summary>
        /// <param name="_size">Size of the pellet</param>
        public Pellet(int _size)
        {
            this.size = _size;
        }
    }
}
