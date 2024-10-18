using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLPersistance.LoanPersistance
{
    public class LoanDbContextSingleton : LoanDbContext
    {
        private static LoanDbContext? dbContextInstance;
        public static LoanDbContext Instance
        {
            get
            {
                if (dbContextInstance is null)
                {
                    dbContextInstance = new LoanDbContext();
                }
                return dbContextInstance;
            }
        }
    }
}
