using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFNinja.ViewModel
{
    public abstract class ViewModelBase : INotifyPropertyChanged, IDisposable
    {
        protected ViewModelBase()
        {

        }

        public event PropertyChangedEventHandler propertyChanged;

        protected virtual void OnPropertyChanged(string _propertyName)
        {
            PropertyChangedEventHandler handler = this.propertyChanged;

            if(handler != null)
            {
                var e = new PropertyChangedEventArgs(_propertyName);
                handler(this, e);
            }
        }

        public void Dispose()
        {
            this.OnDispose();
        }

        protected virtual void OnDispose()
        {

        }
    }
}
