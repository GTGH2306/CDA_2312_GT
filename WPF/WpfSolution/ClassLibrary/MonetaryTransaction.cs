using ClassLibraryExceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassLibrary
{
    public class MonetaryTransaction
    {
        const int MaxNameLength = 32;
        const int ZipCodeLength = 5;

        private string name = string.Empty;
        private DateTime date;
        private decimal amount;
        private string zipCode = string.Empty;

        public string Name
        {
            get { return name; }
            set {
                name = value;
                CheckName(Name);
            }
        }
        public DateTime Date
        {
            get { return date; }
            set
            {
                date = value;
                CheckDate(Date);
            }
        }
        public decimal Amount
        {
            get { return amount; }
            set
            {
                amount = value;
                CheckAmount(Amount);
            }
        }
        public string ZipCode
        {
            get { return zipCode; }
            set
            { 
                zipCode = value;
                CheckZipCode(ZipCode);
            }
        }

        public MonetaryTransaction()
        {

        }

        public static bool CheckName(string _name)
        {
            string property = nameof(Name);
            if (_name.Length <= 0)
            {
                throw new TransactionArgumentException(TransactionValidation.IsTooShort, property);
            }
            else if (_name.Length > MaxNameLength)
            {
                throw new TransactionArgumentException(TransactionValidation.IsTooLong, property);
            }

            if (!Regex.IsMatch(_name, "^[a-zA-Z-]+$") && _name.Length > 0)
            {
                throw new TransactionArgumentException(TransactionValidation.InvalidCharacter, property);
            }
            return true;
        }
        public static bool CheckDate(DateTime _date)
        {
            string property = nameof(Date);

            if (_date < DateTime.Now)
            {
                throw new TransactionArgumentException(TransactionValidation.AnteriorToToday, property);
            }
            return true;
        }
        public static bool CheckAmount(decimal _amount)
        {
            string property = nameof(Amount);

            if (_amount < 0)
            {
                throw new TransactionArgumentException(TransactionValidation.CannotBeNegative, property);
            }
            return true;
        }
        public static bool CheckZipCode(string _zipCode)
        {
            string property = nameof(ZipCode);


            if (_zipCode.Length < ZipCodeLength)
            {
                throw new TransactionArgumentException(TransactionValidation.IsTooShort, property);
            }
            else if (_zipCode.Length > ZipCodeLength)
            {
                throw new TransactionArgumentException(TransactionValidation.IsTooLong, property);
            }
            if (!Regex.IsMatch(_zipCode, "^[0-9]*$"))
            {
                throw new TransactionArgumentException(TransactionValidation.InvalidCharacter, property);
            }
            return true;
        }

        //private static readonly Dictionary<TransactionValidation, string> ValidationErrorMessages = new Dictionary<TransactionValidation, string>()
        //{
        //    {TransactionValidation.Valid, " is valid." },
        //    {TransactionValidation.InvalidCharacter, " contain an invalid character." },
        //    {TransactionValidation.IsTooShort, " don't contain enough caracters." },
        //    {TransactionValidation.IsTooLong, " contain too many caracters." },
        //    {TransactionValidation.AnteriorToToday, " is an anterior date to today." },
        //    {TransactionValidation.CannotBeNegative, " cannot be a negative number." }
        //};
    }
}
