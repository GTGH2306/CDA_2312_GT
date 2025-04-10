namespace ClassLibraryHanoi
{
    public class Game
    {
        private int move = 0;

        private readonly List<List<Pellet>> towers;

        /// <summary>
        /// Create a game of the game "Tower of Hanoï"
        /// </summary>
        /// <param name="_pelletNb">The number of pellets you'd like to use for the game</param>
        /// <exception cref="ArgumentException">Occurs when the number of pellets is lower than 2</exception>
        public Game(int _pelletNb)
        {
            List<Pellet> tower1 = new List<Pellet>();
            List<Pellet> tower2 = new List<Pellet>();
            List<Pellet> tower3 = new List<Pellet>();
            this.towers = new List<List<Pellet>>();
            if (_pelletNb < 2)
            {
                throw new ArgumentException("Invalid pellet number, hanoi tower puzzle must have at least 2 pellets");
            }

            this.towers.Add(tower1);
            this.towers.Add(tower2);
            this.towers.Add(tower3);

            for (int i = 0; i < _pelletNb; i++)
            {
                tower1.Add(new Pellet(_pelletNb - i));
            }
        }

        /// <summary>
        /// Pile all pellets from first tower to last tower
        /// </summary>
        public void Pile()
        {
            Pile(GetPelletTotal(), 1, 2, 3);
        }

        /// <summary>
        /// Choose an existing pile of at least two to put into another tower
        /// Also needs an intermediate tower to help with the transfer
        /// </summary>
        /// <param name="_pileSize">The size of the existing pile to move</param>
        /// <param name="_startingTower">The tower to take the pile from</param>
        /// <param name="_intermediateTower">The tower that is used to help for the transfer</param>
        /// <param name="_objectiveTower">The tower that is the final destination</param>
        /// <exception cref="ArgumentException">Occurs when a pile size is lower than 2, a tower that doesn't exist is selected, or a tower appear twice in arguments</exception>
        private void Pile(int _pileSize,int _startingTower , int _intermediateTower, int _objectiveTower)
        {
            if (_pileSize < 2 || _pileSize > GetPelletTotal())
            {
                throw new ArgumentException("Invalid pilesize", nameof(_pileSize));
            }
            if (_startingTower < 1 || _startingTower > 3)
            {
                throw new ArgumentException("Invalid starting tower, must be between 1 and 3", nameof(_startingTower));
            }
            if (_intermediateTower < 1 || _intermediateTower > 3)
            {
                throw new ArgumentException("Invalid intermediate tower, must be between 1 and 3", nameof(_intermediateTower));
            }
            if (_objectiveTower < 1 || _objectiveTower > 3)
            {
                throw new ArgumentException("Invalid objective tower, must be between 1 and 3", nameof(_objectiveTower));
            }
            if (_startingTower == _intermediateTower || _startingTower == _objectiveTower || _intermediateTower == _objectiveTower)
            {
                throw new ArgumentException("Invalid towers as parameters, must all be different towers");
            }

            if (_pileSize == 2)
            {
                Move(_startingTower, _intermediateTower);
                Move(_startingTower, _objectiveTower);
                Move(_intermediateTower, _objectiveTower);
            }
            else
            {
                Pile(_pileSize - 1, _startingTower, _objectiveTower, _intermediateTower);
                Move(_startingTower, _objectiveTower);
                Pile(_pileSize - 1, _intermediateTower, _startingTower, _objectiveTower);
            }
        }

        /// <summary>
        /// Returns the total of pellets on all three towers
        /// </summary>
        /// <returns>The total of pellets</returns>
        private int GetPelletTotal()
        {
            int totalPellet = 0;
            for (int i = 0; i < this.towers.Count; i++)
            {
                totalPellet += this.towers[i].Count;
            }
            return totalPellet;
        }

        /// <summary>
        /// Move the pellet on top of a tower to the top of another tower
        /// </summary>
        /// <param name="_towerStart">The tower number to take the pellet from</param>
        /// <param name="_towerEnd">The tower number to put the pellet on</param>
        /// <exception cref="Exception">Occurs when there isn't any pellet to move from the _towerStart</exception>
        /// <exception cref="ArgumentException">Occurs on an illegal move, towers that doesn't exist or if the towers are the same</exception>
        private void Move(int _towerStart, int _towerEnd)
        {
            if (_towerStart < 1 || _towerStart > 3)
            {
                throw new ArgumentException("Invalid starting tower, must be between 1 and 3", nameof(_towerStart));
            }
            if (_towerEnd < 1 || _towerEnd > 3)
            {
                throw new ArgumentException("Invalid ending tower, must be between 1 and 3", nameof(_towerEnd));
            }
            if (_towerStart == _towerEnd)
            {
                throw new ArgumentException("Invalid towers, starting tower and ending tower cannot be the same");
            }

                Pellet? pellet = this.towers[_towerStart - 1].LastOrDefault();
            if (pellet == null)
            {
                throw new Exception("Invalid movement, no pellet to move");
            }
            else
            {
                if (this.towers[_towerEnd - 1].LastOrDefault()?.Size < pellet.Size)
                {
                    throw new ArgumentException("Invalid movement, not allowed to move onto smaller pellet");
                }

                this.towers[_towerEnd - 1].Add(pellet);
                this.towers[_towerStart - 1].Remove(pellet);
                move ++;
            }
        }

        /// <summary>
        /// Summarize the game current state into a String
        /// </summary>
        /// <returns>The number of moves played as well as the pellets and their order on the 3 towers</returns>
        public override string ToString()
        {
            string result = "Move: " + move;

            for(int i = 0; i < towers.Count; i++)
            {
                result += "\n";
                result += "Tower " + (i + 1) + ": [";
                for(int j = 0; j < this.towers[i].Count; j++)
                {
                    result += this.towers[i][j].Size;
                    if (j < this.towers[i].Count - 1)
                    {
                        result += ", ";
                    }
                }
                result += "]";
            }

            return result;
        }
        
    }
}
