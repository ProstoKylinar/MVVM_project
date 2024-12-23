using System;
using System.ComponentModel;
using System.Windows.Input;
using AvaloniaApp.Models;

namespace AvaloniaApp.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private readonly MyModel _model;

        public MainWindowViewModel()
        {
            _model = new MyModel();
            SubmitCommand = new RelayCommand(OnSubmit);
        }

        public string X
        {
            get => _model.X;
            set
            {
                _model.X = value;
                OnPropertyChanged(nameof(X));
            }
        }

        public string Y
        {
            get => _model.Y;
            set
            {
                _model.Y = value;
                OnPropertyChanged(nameof(Y));
            }
        }

        public string Z
        {
            get => _model.Z;
            set
            {
                _model.Z = value;
                OnPropertyChanged(nameof(Z));
            }
        }

        public ICommand SubmitCommand { get; }

        private void OnSubmit()
        {
            Console.WriteLine($"Submitted values: X = {X}, Y = {Y}, Z = {Z}");
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class RelayCommand : ICommand
    {
        private readonly Action _execute;

        public RelayCommand(Action execute)
        {
            _execute = execute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter) => _execute();
    }
}