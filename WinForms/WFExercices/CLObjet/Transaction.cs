using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static CLObjet.Transaction;

namespace CLObjet
{
    public class Transaction
    {
        private static readonly int MaxNameLength = 30;
        private static readonly int CodeLength = 5;

        private readonly string name;
        private readonly DateTime Date;
        private readonly double Amount;
        private readonly string Code;
        public Transaction()
        {
            name = "";
            Date = new DateTime();
            Amount = 0;
            Code = "";
        }

        public Transaction(string name, DateTime date, double amount, string code)
        {
            this.name = name;
            Date = date;
            Amount = amount;
            Code = code;
        }
        public static DateTime StringToDate(string _date)
        {
            //string[] DateArray = _date.Split('/');
            //int[] DateIntegers = new int[3];
            //for(int i = 0; i < DateArray.Length; i++)
            //{
            //    DateIntegers[i] = int.Parse(DateArray[i]);
            //}

            //return DateTime.Parse(DateIntegers[2] + "-" + DateIntegers[1] + "-" + DateIntegers[0]);
            return DateTime.Parse(_date, new CultureInfo("fr-FR"), DateTimeStyles.None);

        }
        public static bool ValidateName(string _name, out List<Error> _errors)
        {
            _errors = new List<Error>();
            bool result = true;
            if (_name.Length <= 0)
            {
                result = false;
                _errors.Add(Error.NameIsTooShort);
            } else if (_name.Length > MaxNameLength)
            {
                result = false;
                _errors.Add(Error.NameIsTooLong);
            }
            
            if (!Regex.IsMatch(_name, "^[a-zA-Z-]+$") && _name.Length > 0)
            {
                result = false;
                _errors.Add(Error.NameInvalidCharacter);
            }

            return result;
        }

        public static bool ValidateDate(string _date, out List<Error> _errors)
        {
            _errors = new List<Error>();
            bool result = true;

            //string[] dateArray = _date.Split('/');
            //int[] dateIntegers = new int[3];

            //if (dateArray.Length > 3)
            //{
            //    result = false;
            //    _errors.Add(Error.DateTooManyParameters);
            //}
            //else if (dateArray.Length < 3)
            //{
            //    result = false;
            //    _errors.Add(Error.DateNotEnoughParameters);
            //}


            //int i = 0;
            //while (i < dateArray.Length && !_errors.Contains(Error.DateCouldNotIntParse))
            //{
            //    if (!int.TryParse(dateArray[i], out int _nb))
            //    {
            //        result = false;
            //        _errors.Add(Error.DateCouldNotIntParse);
            //    } else
            //    {
            //        dateIntegers[i] = _nb;
            //    }
            //    i++;
            //}

            //if(DateTime.TryParse((dateIntegers[2] + "-" + dateIntegers[1] + "-" + dateIntegers[0]), out DateTime date))
            //{

            //    if (DateTime.Compare(date, DateTime.Today) < 0)
            //    {
            //        result = false;
            //        _errors.Add(Error.DateAnteriorToToday);
            //    }
            //} else
            //{
            //    result = false;
            //    _errors.Add(Error.DateIsNotAValideDate);
            //}

            if(!DateTime.TryParse(_date,new CultureInfo("fr-FR"),DateTimeStyles.None, out DateTime _parsedDate))
            {
                result = false;
                _errors.Add(Error.DateIsNotAValideDate);
            } else if (_parsedDate < DateTime.Now)
            {
                result = false;
                _errors.Add(Error.DateAnteriorToToday);
            }


            return result;
        }

        public static bool ValidateCode(string _code, out List<Error> _errors)
        {
            _errors = new List<Error>();
            bool result = true;

            if (_code.Length < CodeLength)
            {
                result = false;
                _errors.Add(Error.CodeIsTooShort);
            } else if (_code.Length > CodeLength)
            {
                result = false;
                _errors.Add(Error.CodeIsTooLong);
            }
            if (!Regex.IsMatch(_code, "^[0-9]*$"))
            {
                result= false;
                _errors.Add(Error.CodeInvalidCharacter);
            }
            return result;
        }

        public static bool ValidateAmount(string _amount, out List<Error> _errors)
        {
            _errors= new List<Error>();
            bool result = true;

            if (!double.TryParse(_amount, out double _parsed))
            {
                result = false;
                _errors.Add(Error.AmountCouldNotDoubleParse);
            }
            else if (_parsed < 0)
            {
                result = false;
                _errors.Add(Error.AmountCannotBeNegative);
            }

            return result;
        }

        public string GetName()
        {
            return this.name;
        }
        public DateTime GetDate()
        {
            return this.Date;
        }
        public double GetAmount()
        {
            return this.Amount;
        }
        public string GetCode()
        {
            return this.Code;
        }

        public enum Error
        {
            NameInvalidCharacter,
            NameIsTooShort,
            NameIsTooLong,
            DateCouldNotIntParse,
            DateTooManyParameters,
            DateNotEnoughParameters,
            DateAnteriorToToday,
            DateIsNotAValideDate,
            CodeInvalidCharacter,
            CodeIsTooShort,
            CodeIsTooLong,
            AmountCannotBeNegative,
            AmountCouldNotDoubleParse
        }
    }
}