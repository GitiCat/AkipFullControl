using AkipFullControl.Core;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AkipFullControl
{
    /// <summary>
    ///     Класс обработки главного окна приложения
    /// </summary>
    public class MainViewModel : Base
    {
        /// <summary>
        ///     Предоставляет указатель на главную форму приложения
        /// </summary>
        private Window mWindow;

        private Page _currentPage;
        /// <summary>
        ///     Задает или возвращает текущую вкладку для отображения
        /// </summary>
        public Page CurrentPage
        {
            get { return _currentPage; }
            set { _currentPage = value; OnPropertyChanged(); }
        }

        /// <summary>
        ///     Команда закрытия приложения
        /// </summary>
        public ICommand CloseApplication { get; set; }
        /// <summary>
        ///     Команда изменения размера главной формы
        /// </summary>
        public ICommand ResizeApplication { get; set; }
        /// <summary>
        ///     Команда скрытия главного окна приложения
        /// </summary>
        public ICommand HideApplication { get; set; }

        #region Menu Commands
        /// <summary>
        ///     Предоставляет команду для открытия вкладки настроек подключения
        /// </summary>
        public ICommand OpenCommunicationPage { get; set; }
        /// <summary>
        ///     Предоставляет команду для открытия вкладки помощи
        /// </summary>
        public ICommand OpenHelpPage { get; set; }
        /// <summary>
        ///     Предоставляет команды для открытия вкладки настроек приложения
        /// </summary>
        public ICommand OpenApplicationSettingsPage { get; set; }
        #endregion

        /// <summary>
        ///     Конструктор класса
        /// </summary>
        public MainViewModel()
        {
            //  Указатель на экземплям главной формы приложения
            mWindow = Application.Current.MainWindow;

            //  Создание команды завершния работы приложения
            CloseApplication = new RCommand(() =>
            {
                if(mWindow != null)
                    mWindow.Close();
            });

            //  Создане команды изменения размера главной формы
            ResizeApplication = new RCommand(() =>
            {
                if(mWindow != null)
                {
                    if (mWindow.WindowState == WindowState.Normal)
                        mWindow.WindowState = WindowState.Maximized;
                    else
                        mWindow.WindowState = WindowState.Normal;
                }
            });

            //  Создание команды скрытия главного окна приложения
            HideApplication = new RCommand(() =>
            {
                if (mWindow != null)
                    mWindow.WindowState = WindowState.Minimized;
            });
        }

        /// <summary>
        ///     Предоставляет метод инициализации команд главного меню приложения
        /// </summary>
        private void MenuCommandInitialization()
        {
            //  Создание команды открытия панели настройки соединения
            OpenCommunicationPage = new RCommand(() => { });
            //  Создание команды открытия панели помощи
            OpenHelpPage = new RCommand(() => { });
            //  Создание команды открытия панели настроек приложения
            OpenApplicationSettingsPage = new RCommand(() => { });
        }
    }
}
