using OgreEdit.Events;
using OgreEdit.Model;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace OgreEdit.ViewModels
{
    public class CharactersViewModel : BindableBase
    {
        private FileStream _fs;
        public FileStream fs
        {
            get { return _fs; }
            set { SetProperty(ref _fs, value); }
        }

        private int _currentCharOffset = 0x0146D;
        public int CurrentCharOffset
        {
            get { return _currentCharOffset; }
            set { SetProperty(ref _currentCharOffset, value); }
        }

        private int _currentCharHPOffset = 0x015AD;
        public int CurrentCharHPOffset
        {
            get { return _currentCharHPOffset; }
            set { SetProperty(ref _currentCharHPOffset, value); }
        }

        private int _currentCharMaxHPOffset = 0x016ED;
        public int CurrentCharMaxHPOffset
        {
            get { return _currentCharMaxHPOffset; }
            set { SetProperty(ref _currentCharMaxHPOffset, value); }
        }

        private int _currentCharAliOffset = 0x0182D;
        public int CurrentCharAliOffset
        {
            get { return _currentCharAliOffset; }
            set { SetProperty(ref _currentCharAliOffset, value); }
        }

        private int _currentCharLevelOffset = 0x0FD5B;
        public int CurrentCharLevelOffset
        {
            get { return _currentCharLevelOffset; }
            set { SetProperty(ref _currentCharLevelOffset, value); }
        }

        private int _currentCharStrOffset = 0x0FE5F;
        public int CurrentCharStrOffset
        {
            get { return _currentCharStrOffset; }
            set { SetProperty(ref _currentCharStrOffset, value); }
        }

        private int _currentCharAgiOffset = 0x0FEFF;
        public int CurrentCharAgiOffset
        {
            get { return _currentCharAgiOffset; }
            set { SetProperty(ref _currentCharAgiOffset, value); }
        }

        private int _currentCharIntOffset = 0x0FF9F;
        public int CurrentCharIntOffset
        {
            get { return _currentCharIntOffset; }
            set { SetProperty(ref _currentCharIntOffset, value); }
        }

        private int _currentCharChaOffset = 0x1003F;
        public int CurrentCharChaOffset
        {
            get { return _currentCharChaOffset; }
            set { SetProperty(ref _currentCharChaOffset, value); }
        }

        private int _currentCharLukOffset = 0x100A3;
        public int CurrentCharLukOffset
        {
            get { return _currentCharLukOffset; }
            set { SetProperty(ref _currentCharLukOffset, value); }
        }

        private int _currentCharItemOffset = 0x101CF;
        public int CurrentCharItemOffset
        {
            get { return _currentCharItemOffset; }
            set { SetProperty(ref _currentCharItemOffset, value); }
        }

        private ObservableCollection<CharacterClass> _charList = new ObservableCollection<CharacterClass>();
        public ObservableCollection<CharacterClass> CharList
        {
            get { return _charList; }
            set { SetProperty(ref _charList, value); }
        }

        private CharacterClass _selectedChar;
        public CharacterClass SelectedChar
        {
            get { return _selectedChar; }
            set
            {
                SetProperty(ref _selectedChar, value);
                CharType = SelectedChar.CharType;
                CharDescription = SelectedChar.CharDescription;
            }
        }

        private string _charType;
        public string CharType
        {
            get { return _charType; }
            set { SetProperty(ref _charType, value); }
        }

        private string _charDescription;
        public string CharDescription
        {
            get { return _charDescription; }
            set { SetProperty(ref _charDescription, value); }
        }



        public DelegateCommand SaveCommand { get; set; }
        public CharactersViewModel(IEventAggregator eventAggregator)
        {
            eventAggregator.GetEvent<FileStreamEvents>().Subscribe(Updated);

            SaveCommand = new DelegateCommand(SaveExecute);
        }

        private void Updated(FileStream incomingFS)
        {
            fs = incomingFS;
            ReadCharXML();
            FillData();
        }



        private void ReadCharXML()
        {
            XDocument xml = XDocument.Load(@"D:\Programming\Projects\OgreEdit\OgreEdit\Resources\Characters.xml");

            var query = from x in xml.Root.Descendants("character") select x;

            foreach (XElement node in query)
            {
                CharacterClass Character = new CharacterClass();

                Character.CharHexValue = node.Element("hexValue").Value;
                Character.CharType = node.Element("name").Value;
                Character.CharDescription = node.Element("description").Value;

                CharList.Add(Character);
            }
        }

        private void FillData()
        {

        }

        private void SaveExecute()
        {
            throw new NotImplementedException();
        }

    }
}
