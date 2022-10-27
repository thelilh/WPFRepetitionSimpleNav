﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WPFRepetition.Managers;

namespace WPFRepetition.ViewModels
{
    class RootViewModel : ObservableObject
    {
        private readonly NavigationManager _navigationManager;
        private readonly DataManager _dataManager;

        #region Commands
        
        #endregion

        public ObservableObject CurrentViewModel => _navigationManager.CurrentViewModel;
        
        public RootViewModel(NavigationManager navigationManager, DataManager dataManager)
        {
            _navigationManager = navigationManager;
            _dataManager = dataManager;
            _navigationManager.CurrentViewModelChanged += CurrentViewModelChanged;
        }


        private void CurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
        
    }
}
