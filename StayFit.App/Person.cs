using System.ComponentModel;

namespace StayFit.App
{
    public class Person : INotifyPropertyChanged
    {
        //this is hotfix
        //hofix 4
        string _name;
        int _age;

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public int Age
        {
            get { return _age; }
            set
            {
                if (_age != value)
                {
                    _age = value;
                    OnPropertyChanged("Age");
                }
            }
        }

        #region INotifyPropertyChanged 

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        #endregion
    }
}