using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace MusicCollectionMVVMLight.ViewModel
{
    public class WindowsViewModel : ViewModelBase
    {
        private MainWindow _mainWindow;
        private SecondWindow _secondWindow;

        public ICommand ShowMainWindowCommand {get; set;}

        public ICommand ShowSecondWindowCommand { get; set; }

        public WindowsViewModel()
        {
            _mainWindow = new MainWindow();
            _secondWindow = new SecondWindow();

            ShowMainWindowCommand = new RelayCommand(showMainWindow, canShowMainWindow);
            ShowSecondWindowCommand = new RelayCommand(showSecondWindow, canShowSecondWindow);
        }

     
        private bool canShowMainWindow()
        {
            return _mainWindow.IsVisible == false;
        }

        private void showMainWindow()
        {
            _mainWindow.Show();
        }

        private bool canShowSecondWindow()
        {
            return _secondWindow.IsVisible == false;
        }


        private void showSecondWindow()
        {
            _secondWindow.Show();
        }

    }
}
