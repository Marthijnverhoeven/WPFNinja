using WPFNinjaV2.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPFNinjaV2.Model
{
    public class NinjaViewModel : INotifyPropertyChanged
    {
        public int money
        {
            get { return _ninja.money; }
            set { _ninja.money = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private Ninja _ninja;

        public NinjaViewModel()
        {
            this._ninja = new Ninja(100000);
        }

        public NinjaViewModel(Ninja ninja)
        {
            this._ninja = ninja;
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
