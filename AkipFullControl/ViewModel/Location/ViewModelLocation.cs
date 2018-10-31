using AkipFullControl.Core;

namespace AkipFullControl
{
    public class ViewModelLocation
    {
        public static ViewModelLocation Instance { get; private set; } = new ViewModelLocation();
        
        public static ReadyConfigureButton ReadyConfigureButton => IoC.Get<ReadyConfigureButton>();
        public static ReadyToWorkButton ReadyToWorkButton => IoC.Get<ReadyToWorkButton>();
    }
}
