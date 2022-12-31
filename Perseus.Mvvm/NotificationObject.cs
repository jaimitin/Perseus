using Perseus.Core;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Perseus.Mvvm
{
    public abstract class NotificationObject : PerseusObject, INotifyPropertyChanged, INotifyPropertyChanging
    {
        protected readonly Dictionary<string, List<string>> Dependencies = new();

        protected NotificationObject()
        {
            foreach (PropertyInfo property in GetType().GetProperties())
            {
                IEnumerable<DependsOnAttribute> attributes = property.GetCustomAttributes<DependsOnAttribute>();
                foreach (DependsOnAttribute attr in attributes)
                {
                    if (attr != null)
                    {
                        string dependency = attr.Dependency;

                        if (!Dependencies.ContainsKey(dependency))
                        {
                            Dependencies.Add(dependency, new List<string>());
                        }

                        Dependencies[dependency].Add(property.Name);
                    }
                }
            }
        }


        #region PropertyChanged

        /// <summary>
        /// Occurs when a property changes
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Sets the property
        /// </summary>
        /// <returns>
        /// <see langword="true"/> if the property was set, otherwise <see langword="false"/>
        /// </returns>
        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string propertyName = "", Action? onChanging = null, Action? onChanged = null, Func<T, T, bool>? validateValue = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
            {
                return false;
            }

            if (validateValue != null && !validateValue(field, value))
            {
                return false;
            }

            onChanging?.Invoke();
            OnPropertyChanging(propertyName);

            field = value;

            onChanged?.Invoke();
            OnPropertyChanged(propertyName);

            return true;
        }

        /// <summary>
        /// Raises the PropertyChanged event
        /// </summary>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            if (Dependencies.TryGetValue(propertyName, out List<string>? value))
            {
                foreach (string dependentProperty in value)
                {
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(dependentProperty));
                }
            }
        }

        #endregion


        #region PropertyChanging

        /// <summary>
        /// Occurs when a property is changing
        /// </summary>
        public event PropertyChangingEventHandler? PropertyChanging;

        /// <summary>
        /// Raises the PropertyChanging event
        /// </summary>
        protected virtual void OnPropertyChanging([CallerMemberName] string propertyName = "")
        {
            PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));
        }

        #endregion

    }
}
