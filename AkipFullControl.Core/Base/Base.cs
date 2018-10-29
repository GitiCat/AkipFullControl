using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace AkipFullControl.Core
{
    /// <summary>
    ///     Класс, предоставляющий базовые методы для работы приложения
    /// </summary>
    public class Base : DependencyObject, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        ///     Реализация интерфейса <see cref="INotifyPropertyChanged"/>
        ///     для обновления свойств переменных приложения
        /// </summary>
        /// <param name="propertyName"></param>
        public virtual void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
