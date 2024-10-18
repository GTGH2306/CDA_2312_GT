using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLDomainePersistance
{
    public interface ILoanPersistance
    {
        public abstract int Insert(LoanStruct _loan);
        public abstract void Update(int _loanId, LoanStruct _loan);
        public abstract void Delete(int _loanId);
        public abstract bool Select(int _loanId, out LoanStruct _struct);
    }
}
