using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1CSharp.Models
{
    public class BirthdateAnalyser
    {
        #region Fields
        private DateTime _birthdate;
        private DateTime _todayDate;
        #endregion

        #region Properties
        public DateTime Birthdate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }

        public DateTime TodayDate
        {
            get { return _todayDate; }
            set { _todayDate = value; }
        }
        #endregion

        public BirthdateAnalyser(DateTime birthdate)
        {
            _birthdate = birthdate;
            _todayDate = DateTime.Today;
        }

        public BirthdateAnalyser(DateTime birthdate, DateTime todayDate)
        {
            _birthdate = birthdate;
            _todayDate = todayDate;
        }

        public int GetAge()
        {
            int yearsDifference = TodayDate.Year- Birthdate.Year;
            int monthDifference = TodayDate.Month - Birthdate.Month;
            int daysDifference = TodayDate.Day - Birthdate.Day;
            if(monthDifference>0 || (monthDifference == 0 && daysDifference >= 0))
            {
                return yearsDifference; // already celebrated the birthday in this year
            }
            return yearsDifference - 1; // will celebrate the birthday
        }

    }
}
