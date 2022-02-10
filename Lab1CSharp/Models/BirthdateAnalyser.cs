using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1CSharp.Models
{
    class BirthdateAnalyser
    {
        #region Fields
        private DateTime _birthdate;
        #endregion

        #region Properties
        public DateTime Birthdate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }
        #endregion

        public BirthdateAnalyser(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public int GetAge()
        {
            int yearsDifference = DateTime.Today.Year - Birthdate.Year;
            int monthDifference = DateTime.Today.Month - Birthdate.Month;
            int daysDifference = DateTime.Today.Day - Birthdate.Day;
            if(monthDifference>0 || (monthDifference == 0 && daysDifference >= 0))
            {
                return yearsDifference; // already celebrated the birthday in this year
            }
            return yearsDifference - 1; // will celebrate the birthday
        }

    }
}
