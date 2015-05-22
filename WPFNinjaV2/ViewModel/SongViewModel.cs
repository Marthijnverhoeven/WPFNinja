using MusicCollectionMVVMLight.Model;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MusicCollectionMVVMMVVMLight.Model
{
    public class SongViewModel : INotifyPropertyChanged
    {
        public int Id
        {
            get { return _song.Id; }
            set { _song.Id = value; OnPropertyChanged(); }
        }


        public string Artist
        {
            get { return _song.Artist; }
            set { _song.Artist = value; OnPropertyChanged(); }
        }


        public string Title
        {
            get { return _song.Title; }
            set { _song.Title = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private Song _song;

        public SongViewModel()
        {
            this._song = new Song();
        }

        public SongViewModel(Song song)
        {
            this._song = song;
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
