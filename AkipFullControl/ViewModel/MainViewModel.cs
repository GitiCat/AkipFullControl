using AkipFullControl.Core;
using System;
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

        private bool _isWorkPanelVisible;
        /// <summary>
        ///     Задает или возвращает состояния отображения 
        ///     панели подключенных устройств для работы
        /// </summary>
        public bool IsWorkPanelVisible
        {
            get { return _isWorkPanelVisible; }
            set { _isWorkPanelVisible = value; OnPropertyChanged(); }
        }


        /// <summary>
        ///     Возвращает или задает состояние активности 
        ///     кнопки подключенных устройств для работы
        /// </summary>
        public bool IsWorkToggleButtonChecked
        {
            get { return (bool)GetValue(IsWorkToggleButtonCheckedProperty); }
            set { SetValue(IsWorkToggleButtonCheckedProperty, value); }
        }

        public static readonly DependencyProperty IsWorkToggleButtonCheckedProperty =
            DependencyProperty.Register(
                nameof(IsWorkToggleButtonChecked), 
                typeof(bool), 
                typeof(MainViewModel), 
                new UIPropertyMetadata(false, new PropertyChangedCallback(WorkToggleButtonCheckedMethod)));

        private static void WorkToggleButtonCheckedMethod(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            
        }

        private bool _isProgramPanelVisible;
        /// <summary>
        ///     Задает или возвращает состояние отображения
        ///     панели подключенных устройст для настройки программы
        /// </summary>
        public bool IsProgramPanelVisible
        {
            get { return _isProgramPanelVisible; }
            set { _isProgramPanelVisible = value; OnPropertyChanged(); }
        }


        /// <summary>
        ///     Возвращает или задает состояние активности
        ///     кнопки подключенных устройст для настройки программы
        /// </summary>
        public bool IsProgramToggleButtonChecked
        {
            get { return (bool)GetValue(IsProgramToggleButtonCheckedProperty); }
            set { SetValue(IsProgramToggleButtonCheckedProperty, value); }
        }

        public static readonly DependencyProperty IsProgramToggleButtonCheckedProperty =
            DependencyProperty.Register(
                nameof(IsProgramToggleButtonChecked), 
                typeof(bool), 
                typeof(MainWindow), 
                new UIPropertyMetadata(false, new PropertyChangedCallback(ProgramToggleButtonCheckedMethod)));

        private static void ProgramToggleButtonCheckedMethod(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            
        }

        private bool _isConnectPanelVisible;
        /// <summary>
        ///     Задает или возвращает состояние отображения
        ///     панели подключения новых устройст
        /// </summary>
        public bool IsConnectPanelVisible
        {
            get { return _isConnectPanelVisible; }
            set { _isConnectPanelVisible = value; OnPropertyChanged(); }
        }


        /// <summary>
        ///     Возвращает или задает состояние активности
        ///     кнопки подключения новых устройств
        /// </summary>
        public bool IsConnectToggleButtonChecked
        {
            get { return (bool)GetValue(IsConnectToggleButtonCheckedProperty); }
            set { SetValue(IsConnectToggleButtonCheckedProperty, value); }
        }

        public static readonly DependencyProperty IsConnectToggleButtonCheckedProperty =
            DependencyProperty.Register(
                nameof(IsConnectToggleButtonChecked), 
                typeof(bool), 
                typeof(MainWindow), 
                new UIPropertyMetadata(false, new PropertyChangedCallback(ConnectToggleButtonCheckedMethod)));

        private static void ConnectToggleButtonCheckedMethod(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            
        }
    }
}
