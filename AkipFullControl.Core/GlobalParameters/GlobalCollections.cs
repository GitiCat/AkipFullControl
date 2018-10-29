using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;

namespace AkipFullControl.Core
{
    public class GlobalCollections : Base
    {
        /// <summary>
        ///     Команда для открытия вкладки из коллекции
        /// </summary>
        public ICommand ConnectedPageCommand { get; set; }
        /// <summary>
        ///     Задает или возвращает имя устройства подключенного к персональному компьютеру
        /// </summary>
        public string ConnectedPageName { get; set; }
        /// <summary>
        ///     Задает или возвращает адрес устройства, подключенного к персональному компьютеру
        /// </summary>
        public string ConnectedPageAddress { get; set; }
        /// <summary>
        ///     Коллекция вкладок подключенных устройств
        /// </summary>
        public ObservableCollection<Page> ConnectedPageCollection { get; set; }
        
        /// <summary>
        ///     Команда для открытия вкладки из коллекции для работы с оборудованием
        /// </summary>
        public ICommand WorkConnectedItemCommand { get; set; }
        /// <summary>
        ///     Коллекция вкладок для работы подключенных устройств
        /// </summary>
        public ObservableCollection<Page> ConnectedPageCollectionForWork { get; set; }

        /// <summary>
        ///     Конструктор класса <see cref="GlobalCollections"/>
        /// </summary>
        public GlobalCollections()
        {
            ConnectedPageCollection = new ObservableCollection<Page>();
            ConnectedPageCollectionForWork = new ObservableCollection<Page>();
        }
    }
}
