using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using WPFNinjaV2.Model;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Linq;

namespace WPFNinjaV2.ViewModel
{
    public class SongListViewModel : ViewModelBase
    {

        private int _index;

        ISongRepository songRepository;

        public ObservableCollection<SongViewModel> Songs { get; set; }

        private SongViewModel _selectedSong;
        public SongViewModel SelectedSong { 
            get
            {
                return _selectedSong;
            }
            set
            {
                _selectedSong = value;
                RaisePropertyChanged();
            }
        }

        public ICommand AddSong { get; set; }

        public ICommand ClearSongCommand { get; set; }

        public ICommand NextSongCommand { get; set; }

        public ICommand PrevSongCommand { get; set; }

        public SongListViewModel()
        {
            songRepository = new DummySongRepository();
            var songList = songRepository.ToList().Select(s => new SongViewModel(s));

            NextSongCommand = new RelayCommand(NextSong, CanNextSong);
            PrevSongCommand = new RelayCommand(PrevSong, CanPrevSong);

            AddSong = new RelayCommand(AddNewSong, CanAddNewSong);
            ClearSongCommand = new RelayCommand(ClearSong);

            Songs = new ObservableCollection<SongViewModel>(songList);
            SelectedSong = Songs.First();

            _index = 0;
        }

        private void ClearSong()
        {
            this.SelectedSong = new SongViewModel();
        }


        private void NextSong()
        {
            SelectedSong = Songs.ElementAt(_index + 1);
        }

        private bool CanNextSong()
        {
            return _index < Songs.Count() - 1;
        }

        private void PrevSong()
        {
            SelectedSong = Songs.ElementAt(_index- 1);
        }

        private bool CanPrevSong()
        {
            return  _index > 0;
        }

        private void AddNewSong()
        {
            var svm = new SongViewModel();

            svm.Artist = SelectedSong.Artist;
            svm.Title = SelectedSong.Title;
            svm.Id = SelectedSong.Id;

            Songs.Add(svm);
        }

        private bool CanAddNewSong()
        {
            if (SelectedSong == null)
                return false;

            if (SelectedSong.Id <= 0)
                return false;

            if (String.IsNullOrEmpty(SelectedSong.Artist) || String.IsNullOrEmpty(SelectedSong.Title))
                return false;

            return true;
        }



    }
}