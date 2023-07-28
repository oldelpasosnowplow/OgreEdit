using System;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System.Windows;
using Microsoft.Win32;
using System.IO;
using Prism.Events;
using OgreEdit.Events;

namespace OgreEdit.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private FileStream _fs;
        public FileStream fs
        {
            get { return _fs; }
            set { SetProperty(ref _fs, value); }
        }

        private string _title = "Ogre Battle Save State Editor";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _backGround = "/OgreEdit;component/Resources/SlateBG.jpg";
        public string BackGround
        {
            get { return _backGround; }
            set { SetProperty(ref _backGround, value); }
        }

        public DelegateCommand ExitCommand { get; set; }
        public DelegateCommand OpenCommand { get; set; }
        public DelegateCommand<string> NavigateCommand { get; set; }
        private readonly IRegionManager _regionManager;
        readonly IEventAggregator _eventAggregator;
        public MainWindowViewModel(IRegionManager regionManager, IEventAggregator eventAggregator)
        {
            _regionManager = regionManager.RegisterViewWithRegion("ContentRegion", typeof(Views.Characters)).RegisterViewWithRegion("ContentRegion", typeof(Views.Items));
            _eventAggregator = eventAggregator;

            ExitCommand = new DelegateCommand(ExitExecute);
            OpenCommand = new DelegateCommand(OpenExecute);
            NavigateCommand = new DelegateCommand<string>(NavigateExecute);
        }

        private void ExitExecute()
        {
            if (fs != null)
                fs.Close();
            Application.Current.MainWindow.Close();
        }

        private void OpenExecute()
        {
            string fileDirectory = string.Empty;
            OpenFileDialog openFilePath = new OpenFileDialog();
            openFilePath.Filter = "ZNES Save State Files | *.zst";
            openFilePath.ShowDialog();

            fileDirectory = openFilePath.FileName;
            if (string.IsNullOrWhiteSpace(fileDirectory))
                return;

            fs = new FileStream(fileDirectory, FileMode.Open, FileAccess.ReadWrite);
        }

        private void NavigateExecute(string uri)
        {
            _eventAggregator.GetEvent<FileStreamEvents>().Publish(fs);
            _regionManager.RequestNavigate("ContentRegion", uri);
        }
    }
}
