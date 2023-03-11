using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;

namespace prog2
{
    public class Sushi : INotifyPropertyChanged
    {

        private string kitName;
        private int price;
        private int amountOfSoySouce;
        private int amountOfWasabi;
        private int amountOfGinger;
        public string KitName
        {
            get
            {
                return kitName;
            }
            set
            {
                kitName = value;
                OnPropertyChanged(nameof(KitName));
            }
        }
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                OnPropertyChanged(nameof(Price));
            }
        }

        public int AmountOfSoySouce
        {
            get
            {
                return amountOfSoySouce;
            }
            set
            {
                amountOfSoySouce = value;
                OnPropertyChanged(nameof(AmountOfSoySouce));
            }
        }

        public int AmountOfWasabi
        {
            get
            {
                return amountOfWasabi;
            }
            set
            {
                amountOfWasabi = value;
                OnPropertyChanged(nameof(AmountOfWasabi));
            }
        }

        public int AmountOfGinger
        {
            get
            {
                return amountOfGinger;
            }
            set
            {
                amountOfGinger = value;
                OnPropertyChanged(nameof(AmountOfGinger));
            }
        }

        public void GetOrder()
        {
            int totalPrice = TotalPrice (price, amountOfSoySouce, amountOfWasabi, amountOfGinger);
            MessageBox.Show("Total bill is " + totalPrice.ToString());
            string toFile = $"Kit name: {KitName}\nSoy Souce: {amountOfSoySouce}\nWasabi: {amountOfWasabi}\nGinger: {amountOfGinger}\nTotal: {totalPrice}\n\n";
            using (StreamWriter writer = new StreamWriter(@"C:\Users\PC\source\repos\prog2\order.txt", append: true))
            {
                writer.Write(toFile);
            }
        }

        public int TotalPrice(int price, int soy, int wasabi, int ginger)
        {
            return price + soy * 25 + wasabi * 15 + ginger * 15;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }

}

