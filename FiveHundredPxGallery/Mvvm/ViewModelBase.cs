﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;

namespace FiveHundredPxGallery.Mvvm
{
    public abstract class ViewModelBase : GalaSoft.MvvmLight.ViewModelBase, Template10.Services.NavigationService.INavigable
    {
        public virtual void OnNavigatedTo(object parameter, NavigationMode mode, IDictionary<string, object> state) { /* nothing by default */ }
        public virtual Task OnNavigatedFromAsync(IDictionary<string, object> state, bool suspending) => Task.FromResult<object>(null);
        public virtual void OnNavigatingFrom(Template10.Services.NavigationService.NavigatingEventArgs args) { /* nothing by default */ }

        [JsonIgnore]
        public Template10.Services.NavigationService.INavigationService NavigationService { get; set; }

        [JsonIgnore]
        public Template10.Common.IDispatcherWrapper Dispatcher { get; set; }

        [JsonIgnore]
        public Template10.Common.IStateItems SessionState { get; set; }
    }
}
