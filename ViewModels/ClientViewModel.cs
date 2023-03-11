using System.Collections.ObjectModel;

namespace prog2.ViewModels
{
    class ClientViewModel : ViewModelBase
    {

        public ObservableCollection<Sushi> Sushi { get; set; }

        private Sushi selectedItem;
        public Sushi SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
            }
        }

        public ClientViewModel()
        {
            Sushi = new ObservableCollection<Sushi>
            {
                new Sushi{KitName="8 sushi kit",Price=325,AmountOfSoySouce=1,AmountOfWasabi=0,AmountOfGinger=0},
                new Sushi{KitName="12 sushi kit",Price=545,AmountOfSoySouce=2,AmountOfWasabi=1,AmountOfGinger=1},
            };
        }

        private Command makeOrderCommand;
        public Command MakeOrderCommand
        {
            get
            {
                return makeOrderCommand ??
                    (makeOrderCommand = new Command(obj =>
                    {
                        if (SelectedItem != null) SelectedItem.GetOrder();
                    }));
            }
        }

        private Command addCommand;
        public Command AddCommand
        {
            get
            {
                return addCommand ??
                    (addCommand = new Command(obj =>
                    {

                        if (newName != null)
                        {
                            Sushi.Add(new Sushi { KitName = newName, Price = newPrice, AmountOfSoySouce = SoySouce, AmountOfWasabi = Wasabi, AmountOfGinger = Ginger });
                            newName = ""; newPrice = 0; SoySouce = 0; Wasabi = 0; Ginger = 0;
                        }
                    }));
            }
        }

        private string _name;
        public string newName
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(newName));
            }
        }

        private int _price;
        public int newPrice
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
                OnPropertyChanged(nameof(newPrice));
            }
        }

        private int _soySouce;
        public int SoySouce
        {
            get
            {
                return _soySouce;
            }
            set
            {
                _soySouce = value;
                OnPropertyChanged(nameof(SoySouce));
            }
        }

        private int _wasabi;
        public int Wasabi
        {
            get
            {
                return _wasabi;
            }
            set
            {
                _wasabi = value;
                OnPropertyChanged(nameof(Wasabi));
            }
        }

        private int _ginger;
        public int Ginger
        {
            get
            {
                return _ginger;
            }
            set
            {
                _ginger = value;
                OnPropertyChanged(nameof(Ginger));
            }
        }

    }
}
