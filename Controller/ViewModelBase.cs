using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace familienfest.Controller
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        private readonly Dictionary<string, object> propertyValues;
        /// <summary>
        /// constructor
        /// </summary>
        protected ViewModelBase()
        {
            propertyValues = new Dictionary<string, object>();
        }

        /// <summary>
        /// set Property with comparer and raise PropertyChanged when value has changed
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="field"></param>
        /// <param name="value"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        [ObsoleteAttribute("change to Set")]
        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string name = null)
        {
            bool propertyChanged = false;
            string valueOld = field == null ? "" : field.ToString();
            string valueNew = value == null ? "" : value.ToString();

            //If we have a different value, do stuff
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                OnPropertyChanged(name);
                propertyChanged = true;
            }

            return propertyChanged;
        }
        /// <summary>
        /// set property with nerd event
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="field"></param>
        /// <param name="value"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        [ObsoleteAttribute("change to Set")]
        protected bool SetPropertyAndInform<T>(ref T field, T value, [CallerMemberName] string name = null)
        {
            bool propertyChanged = false;

            //If we have a different value, do stuff
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                OnPropertyChanged(name);
                propertyChanged = true;
            }

            return propertyChanged;
        }

        /// <summary>
        /// set the property
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">the new value</param>
        /// <param name="alsoInform">add names for PropertyChanged events if value has changed</param>
        /// <param name="propertyName">property name - is usually recognized automatically</param>
        /// <returns>true if there was an change</returns>
        protected bool Set<T>(T value, string[] alsoInform = null, [CallerMemberName] string propertyName = null)
        {
            if (propertyValues.ContainsKey(propertyName))
            {
                // check if there was a change
                if (!EqualityComparer<T>.Default.Equals((T)propertyValues[propertyName], value))
                {
                    Console.WriteLine($"{propertyName} has changed to {value}");
                    propertyValues[propertyName] = value;
                    OnPropertyChanged(propertyName);
                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

                    if (alsoInform != null)
                    {
                        foreach (string toInform in alsoInform)
                        {
                            if (!string.IsNullOrEmpty(toInform))
                            {
                                OnPropertyChanged(toInform);
                                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(toInform));
                            }
                        }
                    }
                    return true;
                }
                return false;
            }
            else
            {
                // set new "private"
                propertyValues.Add(propertyName, value);
                OnPropertyChanged(propertyName);
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                return true;
            }
        }

        /// <summary>
        /// get
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        protected T Get<T>([CallerMemberName] string propertyName = null)
        {
            if (propertyValues.ContainsKey(propertyName))
            {
                return (T)propertyValues[propertyName];
            }
            return default(T);
        }

        #region event
        /// <summary>
        /// property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// on property changed
        /// </summary>
        /// <param name="propname"></param>
        public void OnPropertyChanged(string propname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propname));
            }
        }
        #endregion
    }
}
