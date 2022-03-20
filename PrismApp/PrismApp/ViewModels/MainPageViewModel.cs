using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismApp.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        public INavigationService _navigationService;

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private bool _isChecked;
        public bool IsChecked
        {
            get { return _isChecked; }
            set { SetProperty(ref _isChecked, value); }
        }
        public DelegateCommand Button_Clicked { get; set; }

        public MainPageViewModel(INavigationService navigationService)
        {
            Button_Clicked = new DelegateCommand(ExecuteClick)
                .ObservesCanExecute(()=> IsChecked);
            _navigationService = navigationService;
            Title = "Main Page View";
        }

        private async void ExecuteClick()
        {
            var p = new NavigationParameters();
            p.Add("id", 3);

            await _navigationService.NavigateAsync("ViewA", p);

          
        }


    }
}
