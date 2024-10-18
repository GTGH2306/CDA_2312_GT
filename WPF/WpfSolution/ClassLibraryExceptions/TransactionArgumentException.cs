using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryExceptions
{
    public class TransactionArgumentException : ArgumentException
    {
        public TransactionValidation InvalidInputReason { get; private set; }
        public string Property { get; private set; }
        public TransactionArgumentException(TransactionValidation _exception, string _property)
        {
            this.InvalidInputReason = _exception;
            this.Property = _property;
        }

    }
    public enum TransactionValidation
    {
        Valid,
        InvalidCharacter,
        IsTooShort,
        IsTooLong,
        AnteriorToToday,
        CannotBeNegative
    }
}
