using System.ComponentModel;

namespace AvaloniaApp.Models
{
    public class MyModel : INotifyPropertyChanged
    {
        private string _x;
        private string _y;
        private string _z;

        public string X
        {
            get => _x;
            set
            {
                _x = value;
                OnPropertyChanged(nameof(X));
            }
        }

        public string Y
        {
            get => _y;
            set
            {
                _y = value;
                OnPropertyChanged(nameof(Y));
            }
        }

        public string Z
        {
            get => _z;
            set
            {
                _z = value;
                OnPropertyChanged(nameof(Z));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}