using AkipFullControl.Core;

namespace AkipFullControl
{
    public class ViewModelLocation
    {
        public static ViewModelLocation Instance { get; private set; } = new ViewModelLocation();
        /// <summary>
        ///     Глобальный класс коллекций приложения
        /// </summary>
        public static GlobalCollections GlobalCollections => IoC.Get<GlobalCollections>();
    }
}
