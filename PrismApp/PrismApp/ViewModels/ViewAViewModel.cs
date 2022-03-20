using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismApp.ViewModels
{
    public class ViewAViewModel : BindableBase, INavigationAware, IInitialize
    {
        public ViewAViewModel()
        {

        }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
           
        }

        public void Initialize(INavigationParameters parameters)
        {
            var id = parameters.GetValue<int>("id");

            Title = $"The page id is {id}";
        }
    }
}
