using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CLObjet
{
    public class Production
    {
        public delegate void ProductionProducedCratesHandler(Production _sender);
        public delegate void ProductionStateChangeHandler(Production _sender);
        public event ProductionProducedCratesHandler ProductionProducedCrates;
        public event ProductionStateChangeHandler ProductionStateChange;

        private readonly Thread productionThread;
        private readonly int prodThreadInterval = 100;

        private readonly int cratesPerHour;
        private readonly double flawedCrateChancePercentage;
        private readonly int crateGoal;
        private int msUntilNextCrate;
        private readonly List<Crate> cratesProduced;
        private ProductionStates productionState;
        
        public Production() : this(1, 0, 100) { }
        public Production(Production _prodToClone) : this(_prodToClone.cratesPerHour, _prodToClone.flawedCrateChancePercentage, _prodToClone.crateGoal) { }
        public Production(int _cratesPerHour, double _flawedCrateChancePercentage, int _crateGoal)
        {
            this.cratesPerHour = _cratesPerHour;
            this.flawedCrateChancePercentage = _flawedCrateChancePercentage;
            this.msUntilNextCrate = GetMsForEachCrates();
            this.cratesProduced = new List<Crate>();
            this.productionState = ProductionStates.Initialized;
            this.crateGoal = _crateGoal;
            this.productionThread = new Thread(new ThreadStart(StartProduction));
        }

        ~Production()
        {
            this.productionThread.Abort();
        }

        public int GetNbOfCrates()
        {
            return cratesProduced.Count;
        }
        public int GetMsForEachCrates()
        {
            int result;

            result = 3600000 / this.cratesPerHour;

            return result;
        }
        public static int GetFlawedCratesNb(List<Crate> _crateList)
        {
            int result = 0;
            foreach (Crate _crate in _crateList)
            {
                if (_crate.IsFlawed())
                {
                    result++;
                }
            }
            return result;
        }
        public static int GetValidCratesNb(List<Crate> _crateList)
        {
            return _crateList.Count - GetFlawedCratesNb(_crateList);
        }
        public double GetFlawedCrateSinceBeginningRate()
        {
            if (this.cratesProduced.Count > 0)
            {
                return (GetFlawedCratesNb(this.cratesProduced) / (double)this.cratesProduced.Count) * 100;
            } else
            {
                return 0;
            }
        }
        public List<Crate> GetCratesOfLastHour()
        {
            DateTime anHourAgo = DateTime.Now;
            anHourAgo -= new TimeSpan(1, 0, 0);
            int i = this.cratesProduced.Count -1;
            List<Crate> result = new List<Crate>();
            if (this.cratesProduced.Count > 0)
            {
                while (i >= 0 && DateTime.Compare(this.cratesProduced[i].GetDateOfCreation(), anHourAgo) >= 0)
                {
                    result.Add(this.cratesProduced[i]);
                    i--;
                }
            }
            return result;
        }
        public double GetFlawedCrateOfLastHourPercent()
        {
            List<Crate> cratesOfLastHour = this.GetCratesOfLastHour();
            if (cratesOfLastHour.Count > 0)
            {
                return (GetFlawedCratesNb(cratesOfLastHour) / (double)cratesOfLastHour.Count) * 100;
            } else
            {
                return 0;
            }
        }
        public int GetCrateGoal()
        {
            return this.crateGoal;
        }
        public bool Start()
        {
            if (this.productionState == ProductionStates.Initialized)
            {
                this.productionState = ProductionStates.OnGoing;
                if (this.ProductionStateChange != null)
                {
                    ProductionStateChange(this);
                }
                this.productionThread.Start();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Suspend()
        {
            bool result;
            if (this.productionState == ProductionStates.OnGoing)
            {
                this.productionState = ProductionStates.Suspended;
                if (this.ProductionStateChange != null)
                {
                    ProductionStateChange(this);
                }
                result = true;
            } else
            {
                result = false;
            }
            return result;
        }
        public bool Resume()
        {
            bool result;
            if (this.productionState == ProductionStates.Suspended)
            {
                this.productionState = ProductionStates.OnGoing;
                if (this.ProductionStateChange != null)
                {
                    ProductionStateChange(this);
                }
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        public void ProductionTick(int _msEllapsed)
        {
            int msToProcess = _msEllapsed;
            DateTime now = DateTime.Now;
            while (msToProcess > 0 && this.productionState == ProductionStates.OnGoing)
            {
                if (msToProcess < this.msUntilNextCrate)
                {
                    this.msUntilNextCrate -= msToProcess;
                }
                else
                {
                    this.cratesProduced.Add(new Crate(new DateTime(now.Ticks - msToProcess), flawedCrateChancePercentage));
                    this.msUntilNextCrate = GetMsForEachCrates();
                    if(this.ProductionProducedCrates != null)
                    {
                        ProductionProducedCrates(this);
                    }
                }
                msToProcess -= this.msUntilNextCrate;
                if (GetValidCratesNb(this.cratesProduced) == this.crateGoal)
                {
                    this.productionState = ProductionStates.Finished;
                    if (this.ProductionStateChange != null)
                    {
                        ProductionStateChange(this);
                    }
                }
            }
        }
        public List<Crate> GetCratesProduced() { return this.cratesProduced; }
        public ProductionStates GetProductionState() { return this.productionState; }
        public int GetCratesPerHour() { return this.cratesPerHour; }
        public Thread GetThread() { return this.productionThread; }
        private void StartProduction()
        {
            while (this.productionThread.ThreadState == ThreadState.Running)
            {
                this.ProductionTick(this.prodThreadInterval);
                
                if (this.productionState == ProductionStates.Finished)
                {
                    this.productionThread.Abort();
                } else
                {
                    Thread.Sleep(this.prodThreadInterval);
                }
            }
        }
    }
    public enum ProductionStates
    {
        Initialized,
        OnGoing,
        Suspended,
        Finished
    }
}
