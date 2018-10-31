using AkipFullControl.Core;
using System.Windows.Input;

namespace AkipFullControl
{
    public class ConnectMethodDesignModel : Base
    {
        public static ConnectMethodDesignModel Instance => new ConnectMethodDesignModel();

        private string _buttonName;
        public string ButtonName
        {
            get { return _buttonName; }
            set { _buttonName = value; OnPropertyChanged(); }
        }

        private ICommand _buttonCommand;
        public ICommand ButtonCommand
        {
            get { return _buttonCommand; }
            set { _buttonCommand = value; OnPropertyChanged(); }
        }
    }
}
