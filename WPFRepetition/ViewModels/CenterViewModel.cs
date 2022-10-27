using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WPFRepetition.Models;

namespace WPFRepetition.ViewModels
{
    class CenterViewModel : ObservableObject
    {
        #region Fields

        private readonly DataModel _dataModel;

        #endregion

        #region Properties

        public int Counter
        {
            get => _dataModel.Counter;
            set
            {
                _dataModel.Counter = value;
                OnPropertyChanged(nameof(Counter));
            }
        }

        #endregion

        #region Commands

        public IRelayCommand ResetCommand { get; }

        #endregion

        public CenterViewModel(DataModel dataModel)
        {
            _dataModel = dataModel;
            ResetCommand = new RelayCommand(() => Counter = 0);
        }
    }
}
