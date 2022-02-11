using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Lab1CSharp.Models;
using Lab1CSharp.Tools;

namespace Lab1CSharp.ViewModels
{
    class BirthdateAnalyserViewModel
    {
        #region Fields
        private BirthdateAnalyser _birthdateAnalyser;
        private RelayCommand<object> _okCommand;
        #endregion

        public RelayCommand<object> OKCommand
        {
            get
            {
                return _okCommand ??= new RelayCommand<object>(_ => OK(), CanExecute);
            }
        }

        private void OK()
        {
            MessageBox.Show($"OK");
        }

        private bool CanExecute(object obj)
        {
            return true;
        }

    }
}
