using OgreEdit.Events;
using OgreEdit.Model;
using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Xml;
using System.Xml.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Collections.ObjectModel;

namespace OgreEdit.ViewModels
{
    public class ItemsViewModel : BindableBase
    {
        private FileStream _fs;
        public FileStream fs
        {
            get { return _fs; }
            set { SetProperty(ref _fs, value); }
        }

        private int _intPage = 1;
        public int IntPage
        {
            get { return _intPage; }
            set { SetProperty(ref _intPage, value); }
        }

        private string _currentPage = "Page 1";
        public string CurrentPage
        {
            get { return _currentPage; }
            set { SetProperty(ref _currentPage, value); }
        }

        private int _currentItemOffset = 0x02191;
        public int CurrentItemOffset
        {
            get { return _currentItemOffset; }
            set { SetProperty(ref _currentItemOffset, value); }
        }

        private int _currentItemQuantityOffset = 0x02192;
        public int CurrentItemQuantityOffset
        {
            get { return _currentItemQuantityOffset; }
            set { SetProperty(ref _currentItemQuantityOffset, value); }
        }

        private ObservableCollection<string> _itemHexValue = new ObservableCollection<string>();
        public ObservableCollection<string> ItemHexValue
        {
            get { return _itemHexValue; }
            set { SetProperty(ref _itemHexValue, value); }
        }

        private ItemClass _selectedValue0 = new ItemClass();
        public ItemClass SelectedValue0
        {
            get { return _selectedValue0; }
            set
            {
                SetProperty(ref _selectedValue0, value);
                if (SelectedValue0 != null)
                {
                    ItemName[0] = SelectedValue0.ItemName;
                    ItemDescription[0] = SelectedValue0.ItemDescription;
                    ItemHexValue[0] = SelectedValue0.ItemHexValue;
                }
            }
        }

        private ItemClass _selectedValue1 = new ItemClass();
        public ItemClass SelectedValue1
        {
            get { return _selectedValue1; }
            set
            {
                SetProperty(ref _selectedValue1, value);
                if (SelectedValue1 != null)
                {
                    ItemName[1] = SelectedValue1.ItemName;
                    ItemDescription[1] = SelectedValue1.ItemDescription;
                    ItemHexValue[1] = SelectedValue1.ItemHexValue;
                }
            }
        }

        private ItemClass _selectedValue2 = new ItemClass();
        public ItemClass SelectedValue2
        {
            get { return _selectedValue2; }
            set
            {
                SetProperty(ref _selectedValue2, value);
                if (SelectedValue2 != null)
                {
                    ItemName[2] = SelectedValue2.ItemName;
                    ItemDescription[2] = SelectedValue2.ItemDescription;
                    ItemHexValue[2] = SelectedValue2.ItemHexValue;
                }
            }
        }

        private ItemClass _selectedValue3 = new ItemClass();
        public ItemClass SelectedValue3
        {
            get { return _selectedValue3; }
            set
            {
                SetProperty(ref _selectedValue3, value);
                if (SelectedValue3 != null)
                {
                    ItemName[3] = SelectedValue3.ItemName;
                    ItemDescription[3] = SelectedValue3.ItemDescription;
                    ItemHexValue[3] = SelectedValue3.ItemHexValue;
                }
            }
        }

        private ItemClass _selectedValue4 = new ItemClass();
        public ItemClass SelectedValue4
        {
            get { return _selectedValue4; }
            set
            {
                SetProperty(ref _selectedValue4, value);
                if (SelectedValue4 != null)
                {
                    ItemName[4] = SelectedValue4.ItemName;
                    ItemDescription[4] = SelectedValue4.ItemDescription;
                    ItemHexValue[4] = SelectedValue4.ItemHexValue;
                }
            }
        }

        private ItemClass _selectedValue5 = new ItemClass();
        public ItemClass SelectedValue5
        {
            get { return _selectedValue5; }
            set
            {
                SetProperty(ref _selectedValue5, value);
                if (SelectedValue5 != null)
                {
                    ItemName[5] = SelectedValue5.ItemName;
                    ItemDescription[5] = SelectedValue5.ItemDescription;
                    ItemHexValue[5] = SelectedValue5.ItemHexValue;
                }
            }
        }

        private ItemClass _selectedValue6 = new ItemClass();
        public ItemClass SelectedValue6
        {
            get { return _selectedValue6; }
            set
            {
                SetProperty(ref _selectedValue6, value);
                if (SelectedValue6 != null)
                {
                    ItemName[6] = SelectedValue6.ItemName;
                    ItemDescription[6] = SelectedValue6.ItemDescription;
                    ItemHexValue[6] = SelectedValue6.ItemHexValue;
                }
            }
        }

        private ObservableCollection<string> _itemName = new ObservableCollection<string>();
        public ObservableCollection<string> ItemName
        {
            get { return _itemName; }
            set { SetProperty(ref _itemName, value); }
        }

        private ObservableCollection<string> _itemDescription = new ObservableCollection<string>();
        public ObservableCollection<string> ItemDescription
        {
            get { return _itemDescription; }
            set { SetProperty(ref _itemDescription, value); }
        }

        private ObservableCollection<string> _itemQuantity = new ObservableCollection<string>();
        public ObservableCollection<string> ItemQuantity
        {
            get { return _itemQuantity; }
            set { SetProperty(ref _itemQuantity, value); }
        }

        private string _quantity0;
        public string Quantity0
        {
            get { return _quantity0; }
            set
            {
                SetProperty(ref _quantity0, value);
                ItemQuantity[0] = Quantity0;
            }
        }

        private string _quantity1;
        public string Quantity1
        {
            get { return _quantity1; }
            set
            {
                SetProperty(ref _quantity1, value);
                ItemQuantity[1] = Quantity1;
            }
        }

        private string _quantity2;
        public string Quantity2
        {
            get { return _quantity2; }
            set
            {
                SetProperty(ref _quantity2, value);
                ItemQuantity[2] = Quantity2;
            }
        }
        private string _quantity3;
        public string Quantity3
        {
            get { return _quantity3; }
            set
            {
                SetProperty(ref _quantity3, value);
                ItemQuantity[3] = Quantity3;
            }
        }
        private string _quantity4;
        public string Quantity4
        {
            get { return _quantity4; }
            set
            {
                SetProperty(ref _quantity4, value);
                ItemQuantity[4] = Quantity4;
            }
        }

        private string _quantity5;
        public string Quantity5
        {
            get { return _quantity5; }
            set
            {
                SetProperty(ref _quantity5, value);
                ItemQuantity[5] = Quantity5;
            }
        }

        private string _quantity6;
        public string Quantity6
        {
            get { return _quantity6; }
            set
            {
                SetProperty(ref _quantity6, value);
                ItemQuantity[6] = Quantity6;
            }
        }

        private ObservableCollection<ItemClass> _itemsList = new ObservableCollection<ItemClass>();
        public ObservableCollection<ItemClass> ItemList
        {
            get { return _itemsList; }
            set { SetProperty(ref _itemsList, value); }
        }

        public DelegateCommand PreviousCommand { get; set; }
        public DelegateCommand NextCommand { get; set; }
        public DelegateCommand SaveCommand { get; set; }
        public ItemsViewModel(IEventAggregator eventAggregator)
        {
            eventAggregator.GetEvent<FileStreamEvents>().Subscribe(ReadFileStream);
            PreviousCommand = new DelegateCommand(PreviousExecute);
            NextCommand = new DelegateCommand(NextExecute);
            SaveCommand = new DelegateCommand(SaveExecute);
        }

        private void NextExecute()
        {
            IntPage += 1;


            int startOffset = ((14 * IntPage) - 13);
            for (int i = startOffset; i <= (startOffset + 13); i++)
            {
                CurrentItemOffset = 0x02191 + i;
                CurrentItemQuantityOffset = 0x02192 + i;
            }

            if (IntPage == 10)
            {
                IntPage = 1;
                CurrentItemOffset = 0x02191;
                CurrentItemQuantityOffset = 0x02192;
            }

            CurrentPage = "Page " + IntPage.ToString();
            FillData();
        }

        private void PreviousExecute()
        {
            IntPage -= 1;

            if (IntPage == 0)
            {
                IntPage = 9;
            }

            int startOffset = (14 * IntPage) - 13;
            for (int i = startOffset; i <= (startOffset + 13); i++)
            {
                CurrentItemOffset = 0x02191 + i;
                CurrentItemQuantityOffset = 0x02192 + i;
            }

            if (IntPage == 1)
            {
                CurrentItemOffset = 0x02191;
                CurrentItemQuantityOffset = 0x02192;
            }

            CurrentPage = "Page " + IntPage.ToString();
            FillData();
        }

        private void SaveExecute()
        {
            int startOffset = (14 * IntPage) - 13;
            for (int i = startOffset; i <= (startOffset + 13); i++)
            {
                CurrentItemOffset = 0x02191 + i;
                CurrentItemQuantityOffset = 0x02192 + i;
            }

            if (IntPage == 1)
            {
                CurrentItemOffset = 0x02191;
                CurrentItemQuantityOffset = 0x02192;
            }

            int iQty = 0;

            for (int i = 0; i <= 6; i++)
            {
                fs.Position = CurrentItemOffset;
                iQty = int.Parse(ItemHexValue[i], System.Globalization.NumberStyles.HexNumber);
                fs.WriteByte(Convert.ToByte((char)iQty));

                fs.Position = CurrentItemQuantityOffset;
                iQty = Convert.ToInt32(ItemQuantity[i]);
                fs.WriteByte(Convert.ToByte((char)iQty));

                if (iQty == 0)
                {
                    fs.Position = CurrentItemOffset;
                    fs.WriteByte(0);
                    fs.Position = CurrentItemQuantityOffset;
                    fs.WriteByte(0);
                }

                CurrentItemOffset = CurrentItemOffset + 2;
                CurrentItemQuantityOffset = CurrentItemQuantityOffset + 2;
            }
        }

        private void ReadFileStream(FileStream incomingFS)
        {
            fs = incomingFS;
            ReadItemXML();
            FillData();
        }

        private void ReadItemXML()
        {

            XDocument xml = XDocument.Load(@"D:\Programming\Projects\OgreEdit\OgreEdit\Resources\Items.xml");

            var query = from x in xml.Root.Descendants("item") select x;

            foreach (XElement node in query)
            {
                ItemClass items = new ItemClass();

                items.ItemHexValue = node.Element("hexValue").Value;
                items.ItemName = node.Element("name").Value;
                items.ItemDescription = node.Element("description").Value;
                ItemList.Add(items);
            }
        }

        private void FillData()
        {

            ObservableCollection<string> itemNameTemp = new ObservableCollection<string>();
            ObservableCollection<string> itemDescriptionTemp = new ObservableCollection<string>();
            ObservableCollection<string> itemQuantityTemp = new ObservableCollection<string>();
            ObservableCollection<string> itemHexValueTemp = new ObservableCollection<string>();

            for (int i = 0; i < 64; i++)
            {
                fs.Position = CurrentItemOffset;
                int OffsetValue = fs.ReadByte();
                fs.Position = CurrentItemQuantityOffset;
                int QuantityOffsetValue = fs.ReadByte();

                if (QuantityOffsetValue > 99 || QuantityOffsetValue == 0)
                {
                    itemHexValueTemp.Add(string.Empty);
                    itemNameTemp.Add(string.Empty);
                    itemDescriptionTemp.Add(string.Empty);
                    itemQuantityTemp.Add(string.Empty);
                    break;
                }


                foreach (ItemClass item in ItemList)
                {
                    if (item.ItemHexValue == string.Format("{0:X2}", OffsetValue))
                    {
                        itemHexValueTemp.Add(item.ItemHexValue);
                        itemNameTemp.Add(item.ItemName);
                        itemDescriptionTemp.Add(item.ItemDescription);
                        itemQuantityTemp.Add(QuantityOffsetValue.ToString());
                        break;
                    }
                }
                CurrentItemOffset += 2;
                CurrentItemQuantityOffset += 2;
            }


            ItemDescription = itemDescriptionTemp;
            ItemHexValue = itemHexValueTemp;
            ItemName = itemNameTemp;
            ItemQuantity = itemQuantityTemp;

        }


    }
}
