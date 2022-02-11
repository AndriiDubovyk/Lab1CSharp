using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Lab1CSharp.Models;
using Lab1CSharp.Tools;

namespace Lab1CSharp.ViewModels
{
    class BirthdateAnalyserViewModel : INotifyPropertyChanged
    {
        #region Fields
        private BirthdateAnalyser _birthdateAnalyser = new BirthdateAnalyser(DateTime.Today);
        private string _age;
        private string _westernZodiacSign;
        private string _chineseZodiacSign;
        private RelayCommand<object> _analyseCommand;
        #endregion

        #region Properties
        public DateTime Birthdate
        {
            get
            {
                return _birthdateAnalyser.Birthdate;
            }
            set
            {
                _birthdateAnalyser.Birthdate = value;
            }
        }

        public string Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
                OnPropertyChanged();
            }
        }

        public string WesternZodiacSign
        {
            get
            {
                return _westernZodiacSign;
            }
            set
            {
                _westernZodiacSign = value;
                OnPropertyChanged();
            }
        }

        public string ChineseZodiacSign
        {
            get
            {
                return _chineseZodiacSign;
            }
            set
            {
                _chineseZodiacSign = value;
                OnPropertyChanged();
            }
        }


        public RelayCommand<object> AnalyseCommand
        {
            get
            {
                return _analyseCommand ??= new RelayCommand<object>(_ => Analyse(), CanExecute);
            }
        }
        #endregion

        private void Analyse()
        {
            if (_birthdateAnalyser.ValidateBirthdate())
            {
                Age = _birthdateAnalyser.GetAge().ToString();
                WesternZodiacSign = _birthdateAnalyser.GetWesternZodiacSign();
                ChineseZodiacSign = _birthdateAnalyser.GetChineseZodiacSign();
                if(_birthdateAnalyser.BirthdayIsToday())
                    MessageBox.Show("Happy birthday!");

            } 
            else
            {
                Age = "";
                WesternZodiacSign = "";
                ChineseZodiacSign = "";
                MessageBox.Show("Wrong date!\nYou cannot be over 135 years old and your date of birth must be today or earlier!");
            }
        }

        private bool CanExecute(object obj)
        {
            return true;
        }

        #region EventsAndHandlers
        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = this.PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        #endregion

    }
}

