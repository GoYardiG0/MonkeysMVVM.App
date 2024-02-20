using MonkeysMVVM.Models;
using MonkeysMVVM.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonkeysMVVM.ViewModels
{
    [QueryProperty(nameof(SelectedMonkey), "selectedMonkey")]
    public class ShowMonkeyViewModel:INotifyPropertyChanged
    {
        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
        private Monkey selectedMonkey;
        public Monkey SelectedMonkey
        {
            get { return selectedMonkey; }
            set
            {
                this.selectedMonkey = value;
                OnPropertyChanged();
            }
        }
        //private string name;
        //public string Name 
        //{ 
        //    get { return this.name; } 
        //    set
        //    {
        //        this.name = value;
        //        OnPropertyChanged();
        //    } 
        //}
        //private string location;
        //public string Location
        //{
        //    get { return this.location; }
        //    set
        //    {
        //        this.location = value;
        //        OnPropertyChanged();
        //    }
        //}

        //private string imageUrl;
        //public string ImageUrl
        //{
        //    get { return this.imageUrl; }
        //    set
        //    {
        //        this.imageUrl = value;
        //        OnPropertyChanged();
        //    }
        //}

        //public Command GetMonkeyCommand { get; set; }

        //public ShowMonkeyViewModel()
        //{
        //    GetMonkeyCommand = new Command(GetMonkey);
            
        //    GetMonkey();
        //}

        //private void GetMonkey()
        //{
        //    MonkeysService service = new MonkeysService();
        //    Monkey m = service.GetRandomMonkey();
        //    Name = m.Name;
        //    Location = m.Location;
        //    ImageUrl = m.ImageUrl;
        //}
        
    }
}
