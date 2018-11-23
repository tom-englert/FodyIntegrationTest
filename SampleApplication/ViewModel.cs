using System.ComponentModel;

namespace SampleApplication
{
    public class ViewModel : INotifyPropertyChanged
    {
        public int Property1 { get; set; }

        public int Property2 { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
