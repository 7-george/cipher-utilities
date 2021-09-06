using System;
using Cipher_Utilities.Internal;

namespace Cipher_Utilities.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {

        public RelayCommand WelcomeViewCommand { get; set; }
        public RelayCommand NvDriverStripperViewCommand { get; set; }
        public RelayCommand MsiModeViewCommand { get; set; }
        public RelayCommand BinaryConverterViewCommand { get; set; }
        public RelayCommand DeepCleanViewCommand { get; set; }
        public RelayCommand WinPrefViewCommand { get; set; }

        public WelcomeViewModel WelcomeVM { get; set; }
        public NvDriverStripperViewModel NvDriverStripperVM { get; set; }
        public MsiModeViewModel MsiModeVM { get; set; }
        public BinaryConverterViewModel BinaryConverterVM { get; set; }
        public DeepCleanViewModel DeepCleanVM { get; set; }
        public WinPrefViewModel WinPrefVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                onPropertyChanged();
            }
        }

        public MainViewModel()
        {
            WelcomeVM = new WelcomeViewModel();
            NvDriverStripperVM = new NvDriverStripperViewModel();
            MsiModeVM = new MsiModeViewModel();
            BinaryConverterVM = new BinaryConverterViewModel();
            DeepCleanVM = new DeepCleanViewModel();
            WinPrefVM = new WinPrefViewModel();


            CurrentView = WelcomeVM;



            //Switch To WelcomeVM
            WelcomeViewCommand = new RelayCommand(o => 
            {
            CurrentView = WelcomeVM;
            });

            //Switch To NvDriverStripperVM
            NvDriverStripperViewCommand = new RelayCommand(o =>
            {
                CurrentView = NvDriverStripperVM;
            });

            //Switch To MsiModeVM
            MsiModeViewCommand = new RelayCommand(o =>
            {
                CurrentView = MsiModeVM;
            });

            //Switch To DeepCleanVM
            DeepCleanViewCommand = new RelayCommand(o =>
            {
                CurrentView = DeepCleanVM;
            });

            //Switch To BinaryConverterVM
            BinaryConverterViewCommand = new RelayCommand(o =>
            {
                CurrentView = BinaryConverterVM;
            });

            //Switch To WinPrefVM
            WinPrefViewCommand = new RelayCommand(o =>
            {
                CurrentView = WinPrefVM;
            });
        }


    }
}
