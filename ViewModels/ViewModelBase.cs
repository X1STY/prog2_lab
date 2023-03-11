using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace prog2.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged

    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
