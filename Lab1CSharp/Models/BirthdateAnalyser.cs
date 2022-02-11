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

        private static String[] ChineseZodiacSignsNames = {
            "Monkey",
            "Rooster",
            "Dog",
            "Pig",
            "Rat",
            "Ox",
            "Tiger",
            "Rabbit",
            "Dragon",
            "Snake",
            "Horse",
            "Goat"
        };

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

        public String GetChineseZodiacSign()
        {
            return ChineseZodiacSignsNames[Birthdate.Year%12];
        }

        public String GetWesternZodiacSign()
        {
            double monthDotDay = Birthdate.Month + Birthdate.Day/100.0;
            if (monthDotDay < 1.20) return "Capricorn";
            if (monthDotDay < 2.19) return "Aquarius";
            if (monthDotDay < 3.21) return "Pisces";
            if (monthDotDay < 4.20) return "Aries";
            if (monthDotDay < 5.21) return "Taurus";
            if (monthDotDay < 6.22) return "Gemini";
            if (monthDotDay < 7.23) return "Cancer";
            if (monthDotDay < 8.23) return "Leo";
            if (monthDotDay < 9.23) return "Virgo";
            if (monthDotDay < 10.23) return "Libra";
            if (monthDotDay < 11.23) return "Scorpio";
            if (monthDotDay < 12.22) return "Sagittarius";
            return "Capricorn";
        }

        public bool birthdayIsToday()
        {
            return (TodayDate.Month == Birthdate.Month && TodayDate.Day == Birthdate.Day);
        }
    }
}
