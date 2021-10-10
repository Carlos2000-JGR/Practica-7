using PlatformSpecific.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PlatformSpecific.ViewModels
{
   public class MainViewModel : INotifyPropertyChanged
    {
        public bool FastScroll { get; set; }
       
        
        private void ActivateFastScroll()
        {
            FastScroll = !FastScroll;      
        }


        public ObservableCollection<Anime> AnimeList { get; set; } = new ObservableCollection<Anime>()
        {
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),
             new Anime("",""),


        };

        public event PropertyChangedEventHandler PropertyChanged;


    }
}